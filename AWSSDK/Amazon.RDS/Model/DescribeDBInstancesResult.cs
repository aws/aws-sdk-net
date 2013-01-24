/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <summary>
    /// <para> Contains the result of a successful invocation of the DescribeDBInstances action. </para>
    /// </summary>
    public class DescribeDBInstancesResult
    {
        
        private string marker;
        private List<DBInstance> dBInstances = new List<DBInstance>();

        /// <summary>
        /// An optional pagination token provided by a previous request. If this parameter is specified, the response includes only records beyond the
        /// marker, up to the value specified by <c>MaxRecords</c> .
        ///  
        /// </summary>
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
        public DescribeDBInstancesResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// A list of <a>DBInstance</a> instances.
        ///  
        /// </summary>
        public List<DBInstance> DBInstances
        {
            get { return this.dBInstances; }
            set { this.dBInstances = value; }
        }
        /// <summary>
        /// Adds elements to the DBInstances collection
        /// </summary>
        /// <param name="dBInstances">The values to add to the DBInstances collection </param>
        /// <returns>this instance</returns>
        public DescribeDBInstancesResult WithDBInstances(params DBInstance[] dBInstances)
        {
            foreach (DBInstance element in dBInstances)
            {
                this.dBInstances.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the DBInstances collection
        /// </summary>
        /// <param name="dBInstances">The values to add to the DBInstances collection </param>
        /// <returns>this instance</returns>
        public DescribeDBInstancesResult WithDBInstances(IEnumerable<DBInstance> dBInstances)
        {
            foreach (DBInstance element in dBInstances)
            {
                this.dBInstances.Add(element);
            }

            return this;
        }

        // Check to see if DBInstances property is set
        internal bool IsSetDBInstances()
        {
            return this.dBInstances.Count > 0;
        }
    }
}
