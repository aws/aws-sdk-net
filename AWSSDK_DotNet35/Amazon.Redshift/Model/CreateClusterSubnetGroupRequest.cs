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
    public partial class CreateClusterSubnetGroupRequest : AmazonRedshiftRequest
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

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

    }
}