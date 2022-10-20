using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Widget_Text_Reminder : MonoBehaviour
{
    public string m_Key;
    public InputField m_Input;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (Manager_Network.Instance == null)
            yield return new WaitForFixedUpdate();

        if (PlayerPrefs.HasKey(m_Key))
            m_Input.SetTextWithoutNotify(PlayerPrefs.GetString(m_Key));
        Manager_Network.Instance.Change_IP(m_Input.text);

        yield return null;
    }

    public void onTextChange(string _text)
    {
        PlayerPrefs.SetString(m_Key, _text);
    }
}
