/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the CreateClusterSubnetGroup operation.
    /// Creates a new Amazon Redshift subnet group. You must provide a list of
    /// one or more subnets in             your existing Amazon Virtual Private Cloud (Amazon
    /// VPC) when creating Amazon Redshift subnet group.                   
    /// 
    ///         
    /// <para>
    ///  For information about subnet groups, go to<a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-cluster-subnet-groups.html">Amazon
    /// Redshift Cluster Subnet Groups</a> in the <i>Amazon Redshift Management Guide</i>.
    ///        
    /// </para>
    /// </summary>
    public partial class CreateClusterSubnetGroupRequest : AmazonWebServiceRequest
    {
        private string _clusterSubnetGroupName;
        private string _description;
        private List<string> _subnetIds = new List<string>();


        /// <summary>
        /// Gets and sets the property ClusterSubnetGroupName. 
        /// <para>
        ///             The name for the subnet group.            Amazon Redshift stores the value
        /// as a lowercase string.        
        /// </para>
        ///         
        /// <para>
        /// Constraints: 
        /// </para>
        ///         <ul>            <li>Must contain no more than 255 alphanumeric characters
        /// or hyphens.</li>            <li>Must not be "Default".</li>            <li>Must be
        /// unique for all subnet groups that are created by your AWS account.</li>        </ul>
        ///                
        /// <para>
        /// Example: <code>examplesubnetgroup</code>
        /// </para>
        /// </summary>
        public string ClusterSubnetGroupName
        {
            get { return this._clusterSubnetGroupName; }
            set { this._clusterSubnetGroupName = value; }
        }


        /// <summary>
        /// Sets the ClusterSubnetGroupName property
        /// </summary>
        /// <param name="clusterSubnetGroupName">The value to set for the ClusterSubnetGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterSubnetGroupRequest WithClusterSubnetGroupName(string clusterSubnetGroupName)
        {
            this._clusterSubnetGroupName = clusterSubnetGroupName;
            return this;
        }

        // Check to see if ClusterSubnetGroupName property is set
        internal bool IsSetClusterSubnetGroupName()
        {
            return this._clusterSubnetGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the subnet group.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }


        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterSubnetGroupRequest WithDescription(string description)
        {
            this._description = description;
            return this;
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }


        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        ///             An array of VPC subnet IDs.              A maximum of 20 subnets can be
        /// modified in a single request.        
        /// </para>
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        /// <summary>
        /// Sets the SubnetIds property
        /// </summary>
        /// <param name="subnetIds">The values to add to the SubnetIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterSubnetGroupRequest WithSubnetIds(params string[] subnetIds)
        {
            foreach (var element in subnetIds)
            {
                this._subnetIds.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the SubnetIds property
        /// </summary>
        /// <param name="subnetIds">The values to add to the SubnetIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterSubnetGroupRequest WithSubnetIds(IEnumerable<string> subnetIds)
        {
            foreach (var element in subnetIds)
            {
                this._subnetIds.Add(element);
            }
            return this;
        }
        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

    }
}