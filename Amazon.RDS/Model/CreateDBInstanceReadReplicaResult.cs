
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The results from the CreateDBInstanceReadReplica action.
    /// </summary>
    public class CreateDBInstanceReadReplicaResult : AmazonWebServiceResponse
    {
        private DBInstance dBInstanceValue;

        /// 
        /// Gets and sets the CreateDBInstanceReadReplicaResult property.
        /// Contains the result of a successful invocation of the CreateDBInstanceReadReplica
        /// action.
        /// 
        public DBInstance DBInstance
        {
            get { return this.dBInstanceValue; }
            set { this.dBInstanceValue = value; }
        }
    }
}
    
