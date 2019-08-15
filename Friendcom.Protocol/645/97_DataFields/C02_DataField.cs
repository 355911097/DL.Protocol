﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DL.Protocol._645._97_DataFields
{
    public class C02_DataField : DataField
    {
        public C02_DataField() : base(2) { }

        protected override void SetChildren()
        {
            Children.Clear();
            Children.Add(FDataIdentifer);
        }

        private DataIdentifier97 _fDataIdentifer = new DataIdentifier97();

        public DataIdentifier97 FDataIdentifer
        {
            get { return _fDataIdentifer; }
            set { _fDataIdentifer = value; }
        }
    }
}
