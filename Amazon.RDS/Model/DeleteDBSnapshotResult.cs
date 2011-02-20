
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The results from the DeleteDBSnapshot action.
    /// </summary>
    public class DeleteDBSnapshotResult : AmazonWebServiceResponse
    {
        private DBSnapshot dBSnapshotValue;

        /// 
        /// Gets and sets the DeleteDBSnapshotResult property.
        /// Contains the result of a successful invocation of the DeleteDBSnapshot
        /// action.
        /// 
        public DBSnapshot DBSnapshot
        {
            get { return this.dBSnapshotValue; }
            set { this.dBSnapshotValue = value; }
        }
    }
}
    
