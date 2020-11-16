using UnityEngine;
using System.Collections;
using System.IO;

//Este clasa responsabila pentru capturile de ecran

public class SS : MonoBehaviour
{
  
    public int captureWidth = 1080;
    public int captureHeight = 2160;

    public GameObject hideGameObject;

    public bool screenS = true;

    // Formate in care pot fi salvate imaginile
    public enum Format { RAW, JPG, PNG, PPM };
    public Format format = Format.PPM;

    public string folder;

    private Rect rect;
    private RenderTexture renderTexture;
    private Texture2D screenShot;
    private int counter = 1;

    private bool captureScreenshot = false;
    private bool captureVideo = false;

    // Creare Nume fisier si path-ul acestuia
    private string uniqueFilename(int width, int height)
    {
     
        if (folder == null || folder.Length == 0)
        {
            //dataPat este pentru a salva in editor
            //persistentDataPath este pentru a salva pe dispozitiv
            //folder = Application.persistentDataPath;
            folder = Application.dataPath + "/Assets/";
            if (Application.isEditor)
            {
                var stringPath = folder + "/..";
                folder = Path.GetFullPath(stringPath);
            }
            folder += "/screenshots";

            System.IO.Directory.CreateDirectory(folder);

            // numarul de imagini salvate
            string mask = string.Format("screen_{1}x{1}*.{2}", width, height, format.ToString().ToLower());
            counter = Directory.GetFiles(folder, mask, SearchOption.TopDirectoryOnly).Length;
        }

        // Setare nume imagine
        var filename = string.Format("{0}/P000{3}.{4}", folder, width, height, counter, format.ToString().ToLower());

        ++counter;
        return filename;
    }

    //Capturare ecran
    public void CaptureScreenshot()
    {
        captureScreenshot = true;
    }

    void Update()
    {
        //Taste pentru a face captura de ecran
        captureScreenshot |= Input.GetKeyDown("k");
        captureVideo = Input.GetKey("v");

        if (captureScreenshot || captureVideo)
        {
            captureScreenshot = false;
            if (hideGameObject != null) hideGameObject.SetActive(false);

            if (renderTexture == null)
            {

                int startX = 500;
                int startY = 500;
               
                //Crearea texturii imaginii
                rect = new Rect(0, 0, captureWidth, captureHeight);
                renderTexture = new RenderTexture(captureWidth, captureHeight, 24);
                screenShot = new Texture2D(captureWidth, captureHeight, TextureFormat.RGB24, false);
            }

            // Folosirea camerei  pentru a prelua textura
            Camera camera = this.GetComponent<Camera>(); 
            camera.targetTexture = renderTexture;
            camera.Render();

            //Se randeaza textura si apoi se citesc pixelii
            RenderTexture.active = renderTexture;
            screenShot.ReadPixels(rect, 0, 0);

            camera.targetTexture = null;
            RenderTexture.active = null;

            //Nume unic pentru fiecare imagine
            string filename = uniqueFilename((int)rect.width, (int)rect.height);

            // Se face captura de ecran cu extensia optata
            byte[] fileHeader = null;
            byte[] fileData = null;
            if (format == Format.RAW)
            {
                fileData = screenShot.GetRawTextureData();
            }
            else if (format == Format.PNG)
            {
                fileData = screenShot.EncodeToPNG();
            }
            else if (format == Format.JPG)
            {
                fileData = screenShot.EncodeToJPG();
            }
            else 
            {
                string headerStr = string.Format("P6\n{0} {1}\n255\n", rect.width, rect.height);
                fileHeader = System.Text.Encoding.ASCII.GetBytes(headerStr);
                fileData = screenShot.GetRawTextureData();
            }

            // Se creeaza un thread pentru a salva imaginea
            new System.Threading.Thread(() =>
            {
                // Crearea imaginii 
                var f = System.IO.File.Create(filename);
                if (fileHeader != null) f.Write(fileHeader, 0, fileHeader.Length);
                f.Write(fileData, 0, fileData.Length);
                f.Close();
                Debug.Log(string.Format("Wrote screenshot {0} of size {1}", filename, fileData.Length));
            }).Start();

    
            if (hideGameObject != null) hideGameObject.SetActive(true);
            if (screenS == false)
            {
                Destroy(renderTexture);
                renderTexture = null;
                screenShot = null;
            }
        }
    }


}
