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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyClusterSubnetGroup operation.
    /// <para> Modifies a cluster subnet group to include the specified list of VPC subnets. The operation replaces the existing list of subnets
    /// with the new list of subnets. </para>
    /// </summary>
    /// <seealso cref="Amazon.Redshift.AmazonRedshift.ModifyClusterSubnetGroup"/>
    public class ModifyClusterSubnetGroupRequest : AmazonWebServiceRequest
    {
        private string clusterSubnetGroupName;
        private string description;
        private List<string> subnetIds = new List<string>();

        /// <summary>
        /// The name of the subnet group to be modified.
        ///  
        /// </summary>
        public string ClusterSubnetGroupName
        {
            get { return this.clusterSubnetGroupName; }
            set { this.clusterSubnetGroupName = value; }
        }

        /// <summary>
        /// Sets the ClusterSubnetGroupName property
        /// </summary>
        /// <param name="clusterSubnetGroupName">The value to set for the ClusterSubnetGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterSubnetGroupRequest WithClusterSubnetGroupName(string clusterSubnetGroupName)
        {
            this.clusterSubnetGroupName = clusterSubnetGroupName;
            return this;
        }
            

        // Check to see if ClusterSubnetGroupName property is set
        internal bool IsSetClusterSubnetGroupName()
        {
            return this.clusterSubnetGroupName != null;
        }

        /// <summary>
        /// A text description of the subnet group to be modified.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterSubnetGroupRequest WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// An array of VPC subnet IDs. A maximum of 20 subnets can be modified in a single request.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterSubnetGroupRequest WithSubnetIds(params string[] subnetIds)
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterSubnetGroupRequest WithSubnetIds(IEnumerable<string> subnetIds)
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
    
