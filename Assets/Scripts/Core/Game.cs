using UnityEngine;

public class Game
{
    private static Camera m_MainCamera = null;

    public Camera mainCamera
    {
        get
        {
            if (m_MainCamera == null)
            {
                m_MainCamera = Camera.main;
            }

            return m_MainCamera;
        }
    }
}
