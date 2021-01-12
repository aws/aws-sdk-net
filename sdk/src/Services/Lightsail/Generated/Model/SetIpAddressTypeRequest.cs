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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the SetIpAddressType operation.
    /// Sets the IP address type for a Amazon Lightsail resource.
    /// 
    ///  
    /// <para>
    /// Use this action to enable dual-stack for a resource, which enables IPv4 and IPv6 for
    /// the specified resource. Alternately, you can use this action to disable dual-stack,
    /// and enable IPv4 only.
    /// </para>
    /// </summary>
    public partial class SetIpAddressTypeRequest : AmazonLightsailRequest
    {
        private IpAddressType _ipAddressType;
        private string _resourceName;
        private ResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type to set for the specified resource.
        /// </para>
        ///  
        /// <para>
        /// The possible values are <code>ipv4</code> for IPv4 only, and <code>dualstack</code>
        /// for IPv4 and IPv6.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IpAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the resource for which to set the IP address type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type.
        /// </para>
        ///  
        /// <para>
        /// The possible values are <code>Distribution</code>, <code>Instance</code>, and <code>LoadBalancer</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Distribution-related APIs are available only in the N. Virginia (<code>us-east-1</code>)
        /// AWS Region. Set your AWS Region configuration to <code>us-east-1</code> to create,
        /// view, or edit distributions.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}