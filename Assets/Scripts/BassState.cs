using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yoruyami
{
    public abstract class BassState : MonoBehaviour
    {
        public uint DamageReceived(uint def, uint damege)
        {
            uint damageReceived = def / ( 100 + def ) / 100 * damege;
            return damageReceived;
        }
    }
}