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
    public class DescribeDBSecurityGroupsResult  
    {
        
        private string marker;
        private List<DBSecurityGroup> dBSecurityGroups = new List<DBSecurityGroup>();

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
        public DescribeDBSecurityGroupsResult WithMarker(string marker)
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
        /// A list of <a>DBSecurityGroup</a> instances.
        ///  
        /// </summary>
        public List<DBSecurityGroup> DBSecurityGroups
        {
            get { return this.dBSecurityGroups; }
            set { this.dBSecurityGroups = value; }
        }
        /// <summary>
        /// Adds elements to the DBSecurityGroups collection
        /// </summary>
        /// <param name="dBSecurityGroups">The values to add to the DBSecurityGroups collection </param>
        /// <returns>this instance</returns>
        public DescribeDBSecurityGroupsResult WithDBSecurityGroups(params DBSecurityGroup[] dBSecurityGroups)
        {
            foreach (DBSecurityGroup element in dBSecurityGroups)
            {
                this.dBSecurityGroups.Add(element);
            }

            return this;
        }
        // Check to see if DBSecurityGroups property is set
        internal bool IsSetDBSecurityGroups()
        {
            return this.dBSecurityGroups.Count > 0;         
        }
    }
}
