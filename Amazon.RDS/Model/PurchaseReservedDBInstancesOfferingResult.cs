
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The results from the PurchaseReservedDBInstancesOffering action.
    /// </summary>
    public class PurchaseReservedDBInstancesOfferingResult : AmazonWebServiceResponse
    {
        private ReservedDBInstance reservedDBInstanceValue;

        /// 
        /// Gets and sets the PurchaseReservedDBInstancesOfferingResult property.
        /// Contains the result of a successful invocation of the PurchaseReservedDBInstancesOffering
        /// action.
        /// 
        public ReservedDBInstance ReservedDBInstance
        {
            get { return this.reservedDBInstanceValue; }
            set { this.reservedDBInstanceValue = value; }
        }
    }
}
    
