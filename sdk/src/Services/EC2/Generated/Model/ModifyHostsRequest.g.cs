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
    /// Container for the parameters to the ModifyHosts operation. Modify the auto-placement
    /// setting of a Dedicated Host. When auto-placement is enabled, any instances that you
    /// launch with a tenancy of <c>host</c> but without a specific host ID are placed onto
    /// any available Dedicated Host in your account that has auto-placement enabled. When
    /// auto-placement is disabled, you need to provide a host ID to have the instance launch
    /// onto a specific host. If no host ID is provided, the instance is launched onto a suitable
    /// host with auto-placement enabled. <para> You can also use this API action to modify
    /// a Dedicated Host to support either multiple instance types in an instance family,
    /// or to support a specific instance type only. </para>
    /// </summary>
    public partial class ModifyHostsRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AutoPlacement. 
        /// <para>
        /// Specify whether to enable or disable auto-placement.
        /// </para>
        /// </summary>
        public AutoPlacement AutoPlacement { get; set; }

        /// <summary>
        /// Checks to see if the AutoPlacement property is set.
        /// </summary>
        internal bool IsSetAutoPlacement() => this.AutoPlacement != null;

        /// <summary>
        /// Gets and sets the property HostIds. 
        /// <para>
        /// The IDs of the Dedicated Hosts to modify.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> HostIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the HostIds property is set.
        /// </summary>
        internal bool IsSetHostIds() => this.HostIds != null && (this.HostIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HostMaintenance. 
        /// <para>
        /// Indicates whether to enable or disable host maintenance for the Dedicated Host. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-hosts-maintenance.html">Host
        /// maintenance</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public HostMaintenance HostMaintenance { get; set; }

        /// <summary>
        /// Checks to see if the HostMaintenance property is set.
        /// </summary>
        internal bool IsSetHostMaintenance() => this.HostMaintenance != null;

        /// <summary>
        /// Gets and sets the property HostRecovery. 
        /// <para>
        /// Indicates whether to enable or disable host recovery for the Dedicated Host. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-hosts-recovery.html">Host
        /// recovery</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public HostRecovery HostRecovery { get; set; }

        /// <summary>
        /// Checks to see if the HostRecovery property is set.
        /// </summary>
        internal bool IsSetHostRecovery() => this.HostRecovery != null;

        /// <summary>
        /// Gets and sets the property InstanceFamily. 
        /// <para>
        /// Specifies the instance family to be supported by the Dedicated Host. Specify this
        /// parameter to modify a Dedicated Host to support multiple instance types within its
        /// current instance family.
        /// </para>
        ///  
        /// <para>
        /// If you want to modify a Dedicated Host to support a specific instance type only, omit
        /// this parameter and specify <b>InstanceType</b> instead. You cannot specify <b>InstanceFamily</b>
        /// and <b>InstanceType</b> in the same request.
        /// </para>
        /// </summary>
        public string InstanceFamily { get; set; }

        /// <summary>
        /// Checks to see if the InstanceFamily property is set.
        /// </summary>
        internal bool IsSetInstanceFamily() => this.InstanceFamily != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Specifies the instance type to be supported by the Dedicated Host. Specify this parameter
        /// to modify a Dedicated Host to support only a specific instance type.
        /// </para>
        ///  
        /// <para>
        /// If you want to modify a Dedicated Host to support multiple instance types in its current
        /// instance family, omit this parameter and specify <b>InstanceFamily</b> instead. You
        /// cannot specify <b>InstanceType</b> and <b>InstanceFamily</b> in the same request.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;
    }
}
