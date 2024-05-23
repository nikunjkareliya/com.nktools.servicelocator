using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NKTools.ServiceLocator
{
    public interface IAudioService : IService
    {
        float GetVolume();
        void SetVolume(float volume);

        void PlayClip(int clipID);

        void Pause();
        void Resume();
    }
}