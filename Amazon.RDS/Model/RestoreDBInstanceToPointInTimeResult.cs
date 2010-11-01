
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The results from the RestoreDBInstanceToPointInTime action.
    /// </summary>
    public class RestoreDBInstanceToPointInTimeResult : AmazonWebServiceResponse
    {
        private DBInstance dBInstanceValue;

        /// 
        /// Gets and sets the RestoreDBInstanceToPointInTimeResult property.
        /// Contains the result of a successful invocation of the RestoreDBInstanceToPointInTime
        /// action.
        /// 
        public DBInstance DBInstance
        {
            get { return this.dBInstanceValue; }
            set { this.dBInstanceValue = value; }
        }
    }
}
    
