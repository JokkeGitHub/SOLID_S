using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_S
{
    public class Person
    {
        // Our objects private proterties
        private string _firstName;
        private string _lastName;

        // Encapsulation of the private properties
        #region Encapsulation
        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                this._firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                this._lastName = value;
            }
        }
        #endregion

        // Constructors of the object
        #region Constructors
        public Person()
        {

        }

        public Person(string _firstName, string _lastName)
        {
            FirstName = _firstName;
            LastName = _lastName;
        }
        #endregion
    }
}
