
public class App
{
#if UNITY_EDITOR
    [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
    public static void ResetStaticVariables()
    {
        m_Game = null;
    }
#endif

    private static Game m_Game = null;

    public static Game game
    {
        get
        {
            if (m_Game == null)
            {
                m_Game = new Game();
            }

            return m_Game;
        }
    }
    
}
