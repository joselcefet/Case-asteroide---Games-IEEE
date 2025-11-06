using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuOpcoes : MonoBehaviour
{
    public Toggle musicaToggle;
    public AudioSource musicaDeFundo;

    void Start()
    {
        if (musicaToggle != null && musicaDeFundo != null)
            musicaToggle.isOn = musicaDeFundo.isPlaying;
    }

    public void AlternarMusica()
    {
        if (musicaDeFundo == null) return;

        if (musicaToggle.isOn)
            musicaDeFundo.Play();
        else
            musicaDeFundo.Pause();
    }

    public void VoltarAoMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
