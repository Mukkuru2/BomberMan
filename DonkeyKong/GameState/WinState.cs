﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DonkeyKong
{
    class WinState : GameObjectList
    {
        public WinState()
        {
            this.Add(new SpriteGameObject("WinScreen"));
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.KeyPressed(Keys.Space))
            {
                GameEnvironment.GameStateManager.SwitchTo("StartState");
            }
        }
    }
}  
