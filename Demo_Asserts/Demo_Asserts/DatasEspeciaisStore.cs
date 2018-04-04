using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Asserts
{
    public class DatasEspeciaisStore
    {
        public DateTime Data(DatasEspeciais datasEspeciais)
        {
            switch (datasEspeciais)
            {
                case DatasEspeciais.AnoNovo:
                    // Data: 01/01/2018 00:00:00
                    return new DateTime(2018, 01, 01, 0, 0, 0);
                case DatasEspeciais.Natal:
                    return new DateTime(2018, 12, 25, 0, 0, 0);
                default:
                    throw new ArgumentOutOfRangeException("datasEspeciais");
            }
        }
    }
}
