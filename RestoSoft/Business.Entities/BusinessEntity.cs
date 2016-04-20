using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoSoft.Business.Entities
{
    public class BusinessEntity
    {
        #region Variables

        private int _ID;
        private States _State;

        #endregion
        #region Propiedades

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public States State
        {
            get { return _State; }
            set { _State = value; }
        }

        #endregion
        #region Constructores
        public BusinessEntity()
        {
            this.State = States.New;
        }

        #endregion
        #region Metodos



        #endregion
        #region Enumeradores
        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }

        #endregion
    }
}
