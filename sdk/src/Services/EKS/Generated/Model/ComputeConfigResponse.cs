/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EKS.Model
{
    /// <summary>
    /// Indicates the status of the request to update the compute capability of your EKS Auto
    /// Mode cluster.
    /// </summary>
    public partial class ComputeConfigResponse
    {
        private bool? _enabled;
        private List<string> _nodePools = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _nodeRoleArn;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates if the compute capability is enabled on your EKS Auto Mode cluster. If the
        /// compute capability is enabled, EKS Auto Mode will create and delete EC2 Managed Instances
        /// in your Amazon Web Services account.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodePools. 
        /// <para>
        /// Indicates the current configuration of node pools in your EKS Auto Mode cluster. For
        /// more information, see EKS Auto Mode Node Pools in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NodePools
        {
            get { return this._nodePools; }
            set { this._nodePools = value; }
        }

        // Check to see if NodePools property is set
        internal bool IsSetNodePools()
        {
            return this._nodePools != null && (this._nodePools.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodeRoleArn. 
        /// <para>
        /// The ARN of the IAM Role EKS will assign to EC2 Managed Instances in your EKS Auto
        /// Mode cluster.
        /// </para>
        /// </summary>
        public string NodeRoleArn
        {
            get { return this._nodeRoleArn; }
            set { this._nodeRoleArn = value; }
        }

        // Check to see if NodeRoleArn property is set
        internal bool IsSetNodeRoleArn()
        {
            return this._nodeRoleArn != null;
        }

    }
}