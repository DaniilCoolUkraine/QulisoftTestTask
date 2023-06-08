using UnityEngine.SceneManagement;

namespace QulisoftTestTask.Ui.ButtonControllers
{
    public class ReloadSceneButtonController : ButtonController
    {
        protected override void DoAction()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}