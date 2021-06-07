using UnityEngine;
using UnityEngine.SceneManagement;

namespace NotTidduss.Core.Controllers
{
    public abstract class BaseInitController : MonoBehaviour
    {
        public void Awake()
        {
            ResetPlayerPrefs();
            SceneManager.LoadScene("Main");
        }

        protected abstract void ResetPlayerPrefs();
    }
}
