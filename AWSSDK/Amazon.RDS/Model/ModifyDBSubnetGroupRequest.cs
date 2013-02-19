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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBSubnetGroup operation.
    /// <para> Modifies an existing DB subnet group. DB subnet groups must contain at least one subnet in at least two AZs in the region. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.ModifyDBSubnetGroup"/>
    public class ModifyDBSubnetGroupRequest : AmazonWebServiceRequest
    {
        private string dBSubnetGroupName;
        private string dBSubnetGroupDescription;
        private List<string> subnetIds = new List<string>();

        /// <summary>
        /// The name for the DB Subnet Group. This value is stored as a lowercase string. Constraints: Must contain no more than 255 alphanumeric
        /// characters or hyphens. Must not be "Default". Example: <c>mySubnetgroup</c>
        ///  
        /// </summary>
        public string DBSubnetGroupName
        {
            get { return this.dBSubnetGroupName; }
            set { this.dBSubnetGroupName = value; }
        }

        /// <summary>
        /// Sets the DBSubnetGroupName property
        /// </summary>
        /// <param name="dBSubnetGroupName">The value to set for the DBSubnetGroupName property </param>
        /// <returns>this instance</returns>
        public ModifyDBSubnetGroupRequest WithDBSubnetGroupName(string dBSubnetGroupName)
        {
            this.dBSubnetGroupName = dBSubnetGroupName;
            return this;
        }
            

        // Check to see if DBSubnetGroupName property is set
        internal bool IsSetDBSubnetGroupName()
        {
            return this.dBSubnetGroupName != null;
        }

        /// <summary>
        /// The description for the DB Subnet Group.
        ///  
        /// </summary>
        public string DBSubnetGroupDescription
        {
            get { return this.dBSubnetGroupDescription; }
            set { this.dBSubnetGroupDescription = value; }
        }

        /// <summary>
        /// Sets the DBSubnetGroupDescription property
        /// </summary>
        /// <param name="dBSubnetGroupDescription">The value to set for the DBSubnetGroupDescription property </param>
        /// <returns>this instance</returns>
        public ModifyDBSubnetGroupRequest WithDBSubnetGroupDescription(string dBSubnetGroupDescription)
        {
            this.dBSubnetGroupDescription = dBSubnetGroupDescription;
            return this;
        }
            

        // Check to see if DBSubnetGroupDescription property is set
        internal bool IsSetDBSubnetGroupDescription()
        {
            return this.dBSubnetGroupDescription != null;
        }

        /// <summary>
        /// The EC2 Subnet IDs for the DB Subnet Group.
        ///  
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this.subnetIds; }
            set { this.subnetIds = value; }
        }
        /// <summary>
        /// Adds elements to the SubnetIds collection
        /// </summary>
        /// <param name="subnetIds">The values to add to the SubnetIds collection </param>
        /// <returns>this instance</returns>
        public ModifyDBSubnetGroupRequest WithSubnetIds(params string[] subnetIds)
        {
            foreach (string element in subnetIds)
            {
                this.subnetIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the SubnetIds collection
        /// </summary>
        /// <param name="subnetIds">The values to add to the SubnetIds collection </param>
        /// <returns>this instance</returns>
        public ModifyDBSubnetGroupRequest WithSubnetIds(IEnumerable<string> subnetIds)
        {
            foreach (string element in subnetIds)
            {
                this.subnetIds.Add(element);
            }

            return this;
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this.subnetIds.Count > 0;
        }
    }
}
    
