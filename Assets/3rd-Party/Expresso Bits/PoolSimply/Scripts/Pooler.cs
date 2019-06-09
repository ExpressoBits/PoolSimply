﻿using System;
using UnityEngine;
using UnityEngine.Events;

namespace ExpressoBits.PoolSimply
{
    [AddComponentMenu("PoolSimply/Pooler")]
    public class Pooler : MonoBehaviour, IPooler
    {
        
        public Pool pool;

        [Header("Events")]
        public UnityEvent OnEnableFromPool;
        public UnityEvent OnDisableFromPool;

        public void OnPoolerEnable()
        {
            OnEnableFromPool.Invoke();
        }

        public void OnPoolerDisable()
        {
            OnDisableFromPool.Invoke();
        }

    }
}
