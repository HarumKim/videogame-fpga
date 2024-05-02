using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Instancia est�tica para permitir el acceso desde otros scripts
    public static AudioManager instance;
    private AudioSource audioSource;

    private void Awake()
    {
        // Verificar si ya existe una instancia de AudioManager
        if (instance == null)
        {
            // Si no existe, establecer esta instancia como la instancia activa
            instance = this;
            // Mantener este objeto vivo al cargar nuevas escenas
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Si ya existe una instancia, destruir este objeto
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Obtener el componente AudioSource adjunto a este objeto
        audioSource = GetComponent<AudioSource>();
    }

    // M�todo para reproducir la m�sica
    public void PlayMusic()
    {
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    // M�todo para detener la m�sica
    public void StopMusic()
    {
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
