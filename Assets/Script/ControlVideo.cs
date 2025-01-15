using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Evereal.VRVideoPlayer;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Android;

public class ControlVideo : MonoBehaviour
{
    public GameObject Enviroment, Video360Sphere, Video360Sphere2, Video360Sphere3, Video360Sphere4;
    public VRVideoPlayer mediaPlayer360, mediaPlayer360SecondVideo, mediaPlayer360ThirdVideo, mediaPlayer360FouthVideo, mediaPlayer2D;
    public InputField inputFieldURL360, inputFieldURL2D;
    public Text info;
    public TMP_Text infoText;
    public URPScreenFade screenFade;
    // Start is called before the first frame update
    void Start()
    {
        if (!Permission.HasUserAuthorizedPermission(Permission.ExternalStorageWrite))
            Permission.RequestUserPermission(Permission.ExternalStorageWrite);

        if (!Permission.HasUserAuthorizedPermission(Permission.ExternalStorageRead))
            Permission.RequestUserPermission(Permission.ExternalStorageRead);
    }

    public void showInfo(string url)
    {
        info.text = url;
        infoText.text = url;

    }
    public void setURLVideoLiveStream()
    {
        mediaPlayer360.videoUrl = inputFieldURL360.text;
    }
    public void setURLVideoLiveStream2D()
    {
        mediaPlayer2D.videoUrl = inputFieldURL2D.text;
    }
    IEnumerator HideEnviroment()
    {
        yield return new WaitForSeconds(2f);
        screenFade.SceneFadeIn(1);
        Enviroment.SetActive(false);
        Video360Sphere.SetActive(true);
        mediaPlayer360.Play();
    }

    IEnumerator HideEnviroment2ndVideo()
    {
        yield return new WaitForSeconds(2f);
        screenFade.SceneFadeIn(1);
        Enviroment.SetActive(false);
        Video360Sphere2.SetActive(true);
        mediaPlayer360SecondVideo.Play();
    }

    IEnumerator HideEnviroment3rdVideo()
    {
        yield return new WaitForSeconds(2f);
        screenFade.SceneFadeIn(1);
        Enviroment.SetActive(false);
        Video360Sphere3.SetActive(true);
        mediaPlayer360ThirdVideo.Play();
    }

    IEnumerator HideEnviroment4thVideo()
    {
        yield return new WaitForSeconds(2f);
        screenFade.SceneFadeIn(1);
        Enviroment.SetActive(false);
        Video360Sphere4.SetActive(true);
        mediaPlayer360FouthVideo.Play();
    }

    IEnumerator ShowEnviroment()
    {
        yield return new WaitForSeconds(2f);
        screenFade.SceneFadeIn(1);
        mediaPlayer360.Stop();
        Enviroment.SetActive(true);
        Video360Sphere.SetActive(false);
    }

    IEnumerator ShowEnviroment2ndVideo()
    {
        yield return new WaitForSeconds(2f);
        screenFade.SceneFadeIn(1);
        mediaPlayer360SecondVideo.Stop();
        Enviroment.SetActive(true);
        Video360Sphere2.SetActive(false);
    }

    IEnumerator ShowEnviroment3rdVideo()
    {
        yield return new WaitForSeconds(2f);
        screenFade.SceneFadeIn(1);
        mediaPlayer360ThirdVideo.Stop();
        Enviroment.SetActive(true);
        Video360Sphere3.SetActive(false);
    }

    IEnumerator ShowEnviroment4thVideo()
    {
        yield return new WaitForSeconds(2f);
        screenFade.SceneFadeIn(1);
        mediaPlayer360FouthVideo.Stop();
        Enviroment.SetActive(true);
        Video360Sphere4.SetActive(false);
    }

    public void PlayVideo360()
    {
        screenFade.SceneFadeOut(2f);
        StartCoroutine(HideEnviroment());
        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        //if (player != null)
        //    player.transform.GetComponent<Rigidbody>().isKinematic = true;
        //if (photonView != null)
        //    photonView.RPC("PlayVideo360_RPC", RpcTarget.Others);
    }

    public void PlayVideo360SecondVideo()
    {
        screenFade.SceneFadeOut(2f);
        StartCoroutine(HideEnviroment2ndVideo());
        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        //if (player != null)
        //    player.transform.GetComponent<Rigidbody>().isKinematic = true;
        //if (photonView != null)
        //    photonView.RPC("PlayVideo360_RPC", RpcTarget.Others);
    }

    public void PlayVideo360ThirdVideo()
    {
        screenFade.SceneFadeOut(2f);
        StartCoroutine(HideEnviroment3rdVideo());
        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        //if (player != null)
        //    player.transform.GetComponent<Rigidbody>().isKinematic = true;
        //if (photonView != null)
        //    photonView.RPC("PlayVideo360_RPC", RpcTarget.Others);
    }

    public void PlayVideo360FouthVideo()
    {
        screenFade.SceneFadeOut(2f);
        StartCoroutine(HideEnviroment4thVideo());
        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        //if (player != null)
        //    player.transform.GetComponent<Rigidbody>().isKinematic = true;
        //if (photonView != null)
        //    photonView.RPC("PlayVideo360_RPC", RpcTarget.Others);
    }

    public void BackVideo360()
    {
        screenFade.SceneFadeOut(2f);
        StartCoroutine(ShowEnviroment());
        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        //if (player != null)
        //    player.transform.GetComponent<Rigidbody>().isKinematic = false;
        //   if (photonView != null)
        //     photonView.RPC("BackVideo360_RPC", RpcTarget.Others);
    }

    public void BackVideo360SecondVideo()
    {
        screenFade.SceneFadeOut(2f);
        StartCoroutine(ShowEnviroment2ndVideo());
        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        //if (player != null)
        //    player.transform.GetComponent<Rigidbody>().isKinematic = false;
        //   if (photonView != null)
        //     photonView.RPC("BackVideo360_RPC", RpcTarget.Others);
    }

    public void BackVideo360ThirdVideo()
    {
        screenFade.SceneFadeOut(2f);
        StartCoroutine(ShowEnviroment3rdVideo());
        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        //if (player != null)
        //    player.transform.GetComponent<Rigidbody>().isKinematic = false;
        //   if (photonView != null)
        //     photonView.RPC("BackVideo360_RPC", RpcTarget.Others);
    }

    public void BackVideo360FouthVideo()
    {
        screenFade.SceneFadeOut(2f);
        StartCoroutine(ShowEnviroment4thVideo());
        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        //if (player != null)
        //    player.transform.GetComponent<Rigidbody>().isKinematic = false;
        //   if (photonView != null)
        //     photonView.RPC("BackVideo360_RPC", RpcTarget.Others);
    }
}
