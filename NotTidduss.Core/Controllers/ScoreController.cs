using UnityEngine;
using UnityEngine.UI;

namespace NotTidduss.Core.Controllers
{
    public class ScoreController : MonoBehaviour
    {
        public Text scoreValueText;

        private int scoreValue = 0;

        /// <summary>
        /// Adjust the current score by [adjustValue] points
        /// </summary>
        /// <param name="adjustValue"></param>
        public void UpdateScore(int adjustValue)
        {
            scoreValue += adjustValue;
            scoreValueText.text = scoreValue.ToString();
        }

        /// <summary>
        /// Reset score to 0 or passed in [resetScore]
        /// </summary>
        /// <param name="resetScore"></param>
        public void ResetScore(int resetScore = 0)
        {
            scoreValue += resetScore;
            scoreValueText.text = scoreValue.ToString();
        }
    }
}
