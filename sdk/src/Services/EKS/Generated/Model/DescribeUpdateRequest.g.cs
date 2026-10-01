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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeUpdate operation. Describes an update
    /// to an Amazon EKS resource. <para> When the status of the update is <c>Successful</c>,
    /// the update is complete. If an update fails, the status is <c>Failed</c>, and an error
    /// detail explains the reason for the failure. </para>
    /// </summary>
    public partial class DescribeUpdateRequest : AmazonEKSRequest
    {
        /// <summary>
        /// Gets and sets the property AddonName. 
        /// <para>
        /// The name of the add-on. The name must match one of the names returned by <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_ListAddons.html">
        /// <c>ListAddons</c> </a>. This parameter is required if the update is an add-on update.
        /// </para>
        /// </summary>
        public string AddonName { get; set; }

        /// <summary>
        /// Checks to see if the AddonName property is set.
        /// </summary>
        internal bool IsSetAddonName() => this.AddonName != null;

        /// <summary>
        /// Gets and sets the property CapabilityName. 
        /// <para>
        /// The name of the capability for which you want to describe updates.
        /// </para>
        /// </summary>
        public string CapabilityName { get; set; }

        /// <summary>
        /// Checks to see if the CapabilityName property is set.
        /// </summary>
        internal bool IsSetCapabilityName() => this.CapabilityName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon EKS cluster associated with the update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NodegroupName. 
        /// <para>
        /// The name of the Amazon EKS node group associated with the update. This parameter is
        /// required if the update is a node group update.
        /// </para>
        /// </summary>
        public string NodegroupName { get; set; }

        /// <summary>
        /// Checks to see if the NodegroupName property is set.
        /// </summary>
        internal bool IsSetNodegroupName() => this.NodegroupName != null;

        /// <summary>
        /// Gets and sets the property UpdateId. 
        /// <para>
        /// The ID of the update to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UpdateId { get; set; }

        /// <summary>
        /// Checks to see if the UpdateId property is set.
        /// </summary>
        internal bool IsSetUpdateId() => this.UpdateId != null;
    }
}
