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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyIpamResourceCidr operation.
    /// Modify a resource CIDR. You can use this action to transfer resource CIDRs between
    /// scopes and ignore resource CIDRs that you do not want to manage. If set to false,
    /// the resource will not be tracked for overlap, it cannot be auto-imported into a pool,
    /// and it will be removed from any pool it has an allocation in.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/move-resource-ipam.html">Move
    /// resource CIDRs between scopes</a> and <a href="https://docs.aws.amazon.com/vpc/latest/ipam/change-monitoring-state-ipam.html">Change
    /// the monitoring state of resource CIDRs</a> in the <i>Amazon VPC IPAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyIpamResourceCidrRequest : AmazonEC2Request
    {
        private string _currentIpamScopeId;
        private string _destinationIpamScopeId;
        private bool? _dryRun;
        private bool? _monitored;
        private string _resourceCidr;
        private string _resourceId;
        private string _resourceRegion;

        /// <summary>
        /// Gets and sets the property CurrentIpamScopeId. 
        /// <para>
        /// The ID of the current scope that the resource CIDR is in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CurrentIpamScopeId
        {
            get { return this._currentIpamScopeId; }
            set { this._currentIpamScopeId = value; }
        }

        // Check to see if CurrentIpamScopeId property is set
        internal bool IsSetCurrentIpamScopeId()
        {
            return this._currentIpamScopeId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationIpamScopeId. 
        /// <para>
        /// The ID of the scope you want to transfer the resource CIDR to.
        /// </para>
        /// </summary>
        public string DestinationIpamScopeId
        {
            get { return this._destinationIpamScopeId; }
            set { this._destinationIpamScopeId = value; }
        }

        // Check to see if DestinationIpamScopeId property is set
        internal bool IsSetDestinationIpamScopeId()
        {
            return this._destinationIpamScopeId != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Monitored. 
        /// <para>
        /// Determines if the resource is monitored by IPAM. If a resource is monitored, the resource
        /// is discovered by IPAM and you can view details about the resource’s CIDR.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Monitored
        {
            get { return this._monitored; }
            set { this._monitored = value; }
        }

        // Check to see if Monitored property is set
        internal bool IsSetMonitored()
        {
            return this._monitored.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceCidr. 
        /// <para>
        /// The CIDR of the resource you want to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceCidr
        {
            get { return this._resourceCidr; }
            set { this._resourceCidr = value; }
        }

        // Check to see if ResourceCidr property is set
        internal bool IsSetResourceCidr()
        {
            return this._resourceCidr != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource you want to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceRegion. 
        /// <para>
        /// The Amazon Web Services Region of the resource you want to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceRegion
        {
            get { return this._resourceRegion; }
            set { this._resourceRegion = value; }
        }

        // Check to see if ResourceRegion property is set
        internal bool IsSetResourceRegion()
        {
            return this._resourceRegion != null;
        }

    }
}