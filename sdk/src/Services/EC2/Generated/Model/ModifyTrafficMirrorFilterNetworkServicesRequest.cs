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
    /// Container for the parameters to the ModifyTrafficMirrorFilterNetworkServices operation.
    /// Allows or restricts mirroring network services.
    /// 
    ///  
    /// <para>
    ///  By default, Amazon DNS network services are not eligible for Traffic Mirror. Use
    /// <code>AddNetworkServices</code> to add network services to a Traffic Mirror filter.
    /// When a network service is added to the Traffic Mirror filter, all traffic related
    /// to that network service will be mirrored. When you no longer want to mirror network
    /// services, use <code>RemoveNetworkServices</code> to remove the network services from
    /// the Traffic Mirror filter. 
    /// </para>
    ///  
    /// <para>
    /// For information about filter rule properties, see <a href="https://docs.aws.amazon.com/vpc/latest/mirroring/traffic-mirroring-considerations.html">Network
    /// Services</a> in the <i>Traffic Mirroring User Guide </i>.
    /// </para>
    /// </summary>
    public partial class ModifyTrafficMirrorFilterNetworkServicesRequest : AmazonEC2Request
    {
        private List<string> _addNetworkServices = new List<string>();
        private List<string> _removeNetworkServices = new List<string>();
        private string _trafficMirrorFilterId;

        /// <summary>
        /// Gets and sets the property AddNetworkServices. 
        /// <para>
        /// The network service, for example Amazon DNS, that you want to mirror.
        /// </para>
        /// </summary>
        public List<string> AddNetworkServices
        {
            get { return this._addNetworkServices; }
            set { this._addNetworkServices = value; }
        }

        // Check to see if AddNetworkServices property is set
        internal bool IsSetAddNetworkServices()
        {
            return this._addNetworkServices != null && this._addNetworkServices.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RemoveNetworkServices. 
        /// <para>
        /// The network service, for example Amazon DNS, that you no longer want to mirror.
        /// </para>
        /// </summary>
        public List<string> RemoveNetworkServices
        {
            get { return this._removeNetworkServices; }
            set { this._removeNetworkServices = value; }
        }

        // Check to see if RemoveNetworkServices property is set
        internal bool IsSetRemoveNetworkServices()
        {
            return this._removeNetworkServices != null && this._removeNetworkServices.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TrafficMirrorFilterId. 
        /// <para>
        /// The ID of the Traffic Mirror filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TrafficMirrorFilterId
        {
            get { return this._trafficMirrorFilterId; }
            set { this._trafficMirrorFilterId = value; }
        }

        // Check to see if TrafficMirrorFilterId property is set
        internal bool IsSetTrafficMirrorFilterId()
        {
            return this._trafficMirrorFilterId != null;
        }

    }
}