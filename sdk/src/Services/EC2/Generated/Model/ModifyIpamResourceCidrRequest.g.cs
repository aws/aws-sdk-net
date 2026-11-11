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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ModifyIpamResourceCidr operation. Modify a resource
    /// CIDR. You can use this action to transfer resource CIDRs between scopes and ignore
    /// resource CIDRs that you do not want to manage. If set to false, the resource will
    /// not be tracked for overlap, it cannot be auto-imported into a pool, and it will be
    /// removed from any pool it has an allocation in. <para> For more information, see <a
    /// href="https://docs.aws.amazon.com/vpc/latest/ipam/move-resource-ipam.html">Move resource
    /// CIDRs between scopes</a> and <a href="https://docs.aws.amazon.com/vpc/latest/ipam/change-monitoring-state-ipam.html">Change
    /// the monitoring state of resource CIDRs</a> in the <i>Amazon VPC IPAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyIpamResourceCidrRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property CurrentIpamScopeId. 
        /// <para>
        /// The ID of the current scope that the resource CIDR is in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CurrentIpamScopeId { get; set; }

        /// <summary>
        /// Checks to see if the CurrentIpamScopeId property is set.
        /// </summary>
        internal bool IsSetCurrentIpamScopeId() => this.CurrentIpamScopeId != null;

        /// <summary>
        /// Gets and sets the property DestinationIpamScopeId. 
        /// <para>
        /// The ID of the scope you want to transfer the resource CIDR to.
        /// </para>
        /// </summary>
        public string DestinationIpamScopeId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationIpamScopeId property is set.
        /// </summary>
        internal bool IsSetDestinationIpamScopeId() => this.DestinationIpamScopeId != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property Monitored. 
        /// <para>
        /// Determines if the resource is monitored by IPAM. If a resource is monitored, the resource
        /// is discovered by IPAM and you can view details about the resource’s CIDR.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Monitored { get; set; }

        /// <summary>
        /// Checks to see if the Monitored property is set.
        /// </summary>
        internal bool IsSetMonitored() => this.Monitored.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceCidr. 
        /// <para>
        /// The CIDR of the resource you want to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceCidr { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCidr property is set.
        /// </summary>
        internal bool IsSetResourceCidr() => this.ResourceCidr != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource you want to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceRegion. 
        /// <para>
        /// The Amazon Web Services Region of the resource you want to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceRegion { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRegion property is set.
        /// </summary>
        internal bool IsSetResourceRegion() => this.ResourceRegion != null;
    }
}
