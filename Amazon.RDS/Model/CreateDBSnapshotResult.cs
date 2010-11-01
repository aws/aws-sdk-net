
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The results from the CreateDBSnapshot action.
    /// </summary>
    public class CreateDBSnapshotResult : AmazonWebServiceResponse
    {
        private DBSnapshot dBSnapshotValue;

        /// 
        /// Gets and sets the CreateDBSnapshotResult property.
        /// Contains the result of a successful invocation of the CreateDBSnapshot
        /// action.
        /// 
        public DBSnapshot DBSnapshot
        {
            get { return this.dBSnapshotValue; }
            set { this.dBSnapshotValue = value; }
        }
    }
}
    
