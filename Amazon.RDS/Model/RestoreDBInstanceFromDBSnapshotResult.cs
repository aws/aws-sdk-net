
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The results from the RestoreDBInstanceFromDBSnapshot action.
    /// </summary>
    public class RestoreDBInstanceFromDBSnapshotResult : AmazonWebServiceResponse
    {
        private DBInstance dBInstanceValue;

        /// 
        /// Gets and sets the RestoreDBInstanceFromDBSnapshotResult property.
        /// Contains the result of a successful invocation of the RestoreDBInstanceFromDBSnapshot
        /// action.
        /// 
        public DBInstance DBInstance
        {
            get { return this.dBInstanceValue; }
            set { this.dBInstanceValue = value; }
        }
    }
}
    
