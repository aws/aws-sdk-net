
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The results from the CreateDBInstance action.
    /// </summary>
    public class CreateDBInstanceResult : AmazonWebServiceResponse
    {
        private DBInstance dBInstanceValue;

        /// 
        /// Gets and sets the CreateDBInstanceResult property.
        /// Contains the result of a successful invocation of the CreateDBInstance
        /// action.
        /// 
        public DBInstance DBInstance
        {
            get { return this.dBInstanceValue; }
            set { this.dBInstanceValue = value; }
        }
    }
}
    
