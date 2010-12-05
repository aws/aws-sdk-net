/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.RDS.Model
{
    /// <summary>Describe Reserved D B Instances Offerings Result
    /// </summary>
    public class DescribeReservedDBInstancesOfferingsResult  
    {
        
        private string marker;
        private List<ReservedDBInstancesOffering> reservedDBInstancesOfferings = new List<ReservedDBInstancesOffering>();
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        public DescribeReservedDBInstancesOfferingsResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            
        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;         
        }
        public List<ReservedDBInstancesOffering> ReservedDBInstancesOfferings
        {
            get { return this.reservedDBInstancesOfferings; }
            set { this.reservedDBInstancesOfferings = value; }
        }
        /// <summary>
        /// Adds elements to the ReservedDBInstancesOfferings collection
        /// </summary>
        /// <param name="reservedDBInstancesOfferings">The values to add to the ReservedDBInstancesOfferings collection </param>
        /// <returns>this instance</returns>
        public DescribeReservedDBInstancesOfferingsResult WithReservedDBInstancesOfferings(params ReservedDBInstancesOffering[] reservedDBInstancesOfferings)
        {
            foreach (ReservedDBInstancesOffering element in reservedDBInstancesOfferings)
            {
                this.reservedDBInstancesOfferings.Add(element);
            }

            return this;
        }
        // Check to see if ReservedDBInstancesOfferings property is set
        internal bool IsSetReservedDBInstancesOfferings()
        {
            return this.reservedDBInstancesOfferings.Count > 0;         
        }
    }
}
