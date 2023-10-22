using System.Collections;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UltimateClean
{
    public class SkillProgressAnimation : MonoBehaviour
    {
        public TextMeshProUGUI text;
        private SlicedFilledImage slicedImage;

        private StringBuilder strBuilder = new StringBuilder(4);
        public Skill skill;

        private void Update()
        {
            // if (skill.getCurrentLevel() == skill.getMaxLevel())
            // {
            //     text.text = "100.0%";
            //     slicedImage.fillAmount = 1f;
            // }
            // else if (!skill.isOnLearning())
            // {
            //     text.text = "0.0%";
            //     slicedImage.fillAmount = 0f;
            // }
            // else
            // {
            //     float duration = skill.getDevelopTime();
            //     float ratio = 1 - skill.TimeNeedToFinish() / duration;
            //     text.text = (ratio*100).ToString("f1") + "%";
            //     slicedImage.fillAmount = ratio;
            //     StartCoroutine(AnimateProgress());
            // }
        }
        private void Awake()
        {
            slicedImage = GetComponent<SlicedFilledImage>();
        }

        public IEnumerator AnimateProgress()
        {
            float duration = skill.getDevelopTime();
            var ratio = 1 - skill.TimeNeedToFinish() / duration;
            var multiplier = 1.0f / duration;
            while (ratio < 1.0f)
            {
                ratio += Time.deltaTime * multiplier;
                if (slicedImage != null)
                    slicedImage.fillAmount = ratio;

                var percentage = (int)(ratio / 1.0f * 100);
                if (text != null)
                {
                    strBuilder.Clear();
                    text.text = strBuilder.Append(percentage).Append("%").ToString();
                }

                yield return null;
            }

            text.text = "100%";
            yield return null;
        }
    }
}

