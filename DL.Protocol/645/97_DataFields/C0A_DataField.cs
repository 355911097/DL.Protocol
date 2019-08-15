﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DL.Protocol._645._97_DataFields
{
    public class C0A_DataField : DataField
    {
        public C0A_DataField() : base(6) { }

        protected override void SetChildren()
        {
            Children.Clear();
            Children.Add(FAddress);
        }

        private AddressField _fAddress = new AddressField();

        public AddressField FAddress
        {
            get { return _fAddress; }
            set { _fAddress = value; }
        }

    }
}
