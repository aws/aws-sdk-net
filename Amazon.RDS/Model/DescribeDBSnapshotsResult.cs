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
    /// <summary>
    /// <para> </para>
    /// </summary>
    public class DescribeDBSnapshotsResult  
    {
        
        private string marker;
        private List<DBSnapshot> dBSnapshots = new List<DBSnapshot>();

        /// <summary>
        /// The marker obtained from a previous operation response.
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
        public DescribeDBSnapshotsResult WithMarker(string marker)
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
        /// A list of <a>DBSnapshot</a> instances.
        ///  
        /// </summary>
        public List<DBSnapshot> DBSnapshots
        {
            get { return this.dBSnapshots; }
            set { this.dBSnapshots = value; }
        }
        /// <summary>
        /// Adds elements to the DBSnapshots collection
        /// </summary>
        /// <param name="dBSnapshots">The values to add to the DBSnapshots collection </param>
        /// <returns>this instance</returns>
        public DescribeDBSnapshotsResult WithDBSnapshots(params DBSnapshot[] dBSnapshots)
        {
            foreach (DBSnapshot element in dBSnapshots)
            {
                this.dBSnapshots.Add(element);
            }

            return this;
        }
        // Check to see if DBSnapshots property is set
        internal bool IsSetDBSnapshots()
        {
            return this.dBSnapshots.Count > 0;      
        }
    }
}
