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
    /// <summary>Describe Reserved D B Instances Result
    /// </summary>
    public class DescribeReservedDBInstancesResult  
    {
        
        private string marker;
        private List<ReservedDBInstance> reservedDBInstances = new List<ReservedDBInstance>();
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
        public DescribeReservedDBInstancesResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            
        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;         
        }
        public List<ReservedDBInstance> ReservedDBInstances
        {
            get { return this.reservedDBInstances; }
            set { this.reservedDBInstances = value; }
        }
        /// <summary>
        /// Adds elements to the ReservedDBInstances collection
        /// </summary>
        /// <param name="reservedDBInstances">The values to add to the ReservedDBInstances collection </param>
        /// <returns>this instance</returns>
        public DescribeReservedDBInstancesResult WithReservedDBInstances(params ReservedDBInstance[] reservedDBInstances)
        {
            foreach (ReservedDBInstance element in reservedDBInstances)
            {
                this.reservedDBInstances.Add(element);
            }

            return this;
        }
        // Check to see if ReservedDBInstances property is set
        internal bool IsSetReservedDBInstances()
        {
            return this.reservedDBInstances.Count > 0;      
        }
    }
}
