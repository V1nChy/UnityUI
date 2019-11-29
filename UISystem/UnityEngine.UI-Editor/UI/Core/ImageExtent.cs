using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityEngine.UI
{
    public class ImageExtent:Image
    {
        private float _alpha = 1.0F;
        private Outline[] _outLine;
        public float alpha
        {
            get { return _alpha; }
            set { SetAlpha(value); }
        }
        private void SetAlpha(float value)
        {
            _alpha = value;
            color = new UnityEngine.Color(color.r, color.g, color.b, _alpha);
        }

        private bool _gray = false;
        public bool gray
        {
            get { return _gray; }
            set { SetGray(value); }
        }
        private void SetGray(bool value)
        {
            _gray = value;
            if (_gray)
            {
                material = Resources.Load("material/Gray") as Material;
            }
            else
            {
                material = null;
            }
            if (_outLine == null)
            {
                _outLine = GetComponentsInChildren<Outline>(true);
            }
            foreach (var line in _outLine)
            {
                line.enabled = !value;
            }
        }
    }
}
