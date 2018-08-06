﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Final
{
    public class Melee_Enemy : Enemy
    {
        public Squad squad;

        public override void EvaluateDetection()
        {
            if (sense.PlayerDetect())
            {
                squad.PlayerDetectionLevel += Time.deltaTime * detectionGain;
            }
        }
    }
}

