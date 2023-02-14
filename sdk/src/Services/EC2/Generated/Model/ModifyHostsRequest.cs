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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyHosts operation.
    /// Modify the auto-placement setting of a Dedicated Host. When auto-placement is enabled,
    /// any instances that you launch with a tenancy of <code>host</code> but without a specific
    /// host ID are placed onto any available Dedicated Host in your account that has auto-placement
    /// enabled. When auto-placement is disabled, you need to provide a host ID to have the
    /// instance launch onto a specific host. If no host ID is provided, the instance is launched
    /// onto a suitable host with auto-placement enabled.
    /// 
    ///  
    /// <para>
    /// You can also use this API action to modify a Dedicated Host to support either multiple
    /// instance types in an instance family, or to support a specific instance type only.
    /// </para>
    /// </summary>
    public partial class ModifyHostsRequest : AmazonEC2Request
    {
        private AutoPlacement _autoPlacement;
        private List<string> _hostIds = new List<string>();
        private HostMaintenance _hostMaintenance;
        private HostRecovery _hostRecovery;
        private string _instanceFamily;
        private string _instanceType;

        /// <summary>
        /// Gets and sets the property AutoPlacement. 
        /// <para>
        /// Specify whether to enable or disable auto-placement.
        /// </para>
        /// </summary>
        public AutoPlacement AutoPlacement
        {
            get { return this._autoPlacement; }
            set { this._autoPlacement = value; }
        }

        // Check to see if AutoPlacement property is set
        internal bool IsSetAutoPlacement()
        {
            return this._autoPlacement != null;
        }

        /// <summary>
        /// Gets and sets the property HostIds. 
        /// <para>
        /// The IDs of the Dedicated Hosts to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> HostIds
        {
            get { return this._hostIds; }
            set { this._hostIds = value; }
        }

        // Check to see if HostIds property is set
        internal bool IsSetHostIds()
        {
            return this._hostIds != null && this._hostIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HostMaintenance. 
        /// <para>
        /// Indicates whether to enable or disable host maintenance for the Dedicated Host. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-hosts-maintenance.html">
        /// Host maintenance</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public HostMaintenance HostMaintenance
        {
            get { return this._hostMaintenance; }
            set { this._hostMaintenance = value; }
        }

        // Check to see if HostMaintenance property is set
        internal bool IsSetHostMaintenance()
        {
            return this._hostMaintenance != null;
        }

        /// <summary>
        /// Gets and sets the property HostRecovery. 
        /// <para>
        /// Indicates whether to enable or disable host recovery for the Dedicated Host. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-hosts-recovery.html">
        /// Host recovery</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public HostRecovery HostRecovery
        {
            get { return this._hostRecovery; }
            set { this._hostRecovery = value; }
        }

        // Check to see if HostRecovery property is set
        internal bool IsSetHostRecovery()
        {
            return this._hostRecovery != null;
        }

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
        public string InstanceFamily
        {
            get { return this._instanceFamily; }
            set { this._instanceFamily = value; }
        }

        // Check to see if InstanceFamily property is set
        internal bool IsSetInstanceFamily()
        {
            return this._instanceFamily != null;
        }

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
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

    }
}