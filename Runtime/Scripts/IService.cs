using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NKTools.ServiceLocator
{
    public interface IService
    {
        void OnRegister();
        void OnDeregister();
    }
}