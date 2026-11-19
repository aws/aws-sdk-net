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
    /// Container for the parameters to the ModifyTrafficMirrorFilterNetworkServices operation.
    /// Allows or restricts mirroring network services. <para> By default, Amazon DNS network
    /// services are not eligible for Traffic Mirror. Use <c>AddNetworkServices</c> to add
    /// network services to a Traffic Mirror filter. When a network service is added to the
    /// Traffic Mirror filter, all traffic related to that network service will be mirrored.
    /// When you no longer want to mirror network services, use <c>RemoveNetworkServices</c>
    /// to remove the network services from the Traffic Mirror filter. </para>
    /// </summary>
    public partial class ModifyTrafficMirrorFilterNetworkServicesRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AddNetworkServices. 
        /// <para>
        /// The network service, for example Amazon DNS, that you want to mirror.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddNetworkServices { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AddNetworkServices property is set.
        /// </summary>
        internal bool IsSetAddNetworkServices() => this.AddNetworkServices != null && (this.AddNetworkServices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property RemoveNetworkServices. 
        /// <para>
        /// The network service, for example Amazon DNS, that you no longer want to mirror.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveNetworkServices { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveNetworkServices property is set.
        /// </summary>
        internal bool IsSetRemoveNetworkServices() => this.RemoveNetworkServices != null && (this.RemoveNetworkServices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrafficMirrorFilterId. 
        /// <para>
        /// The ID of the Traffic Mirror filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TrafficMirrorFilterId { get; set; }

        /// <summary>
        /// Checks to see if the TrafficMirrorFilterId property is set.
        /// </summary>
        internal bool IsSetTrafficMirrorFilterId() => this.TrafficMirrorFilterId != null;
    }
}
