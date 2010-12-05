
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The results from the DeleteDBInstance action.
    /// </summary>
    public class DeleteDBInstanceResult : AmazonWebServiceResponse
    {
        private DBInstance dBInstanceValue;

        /// 
        /// Gets and sets the DeleteDBInstanceResult property.
        /// Contains the result of a successful invocation of the DeleteDBInstance
        /// action.
        /// 
        public DBInstance DBInstance
        {
            get { return this.dBInstanceValue; }
            set { this.dBInstanceValue = value; }
        }
    }
}
    
