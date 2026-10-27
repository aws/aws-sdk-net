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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the AttachStaticIp operation. Attaches a static IP
    /// address to a specific Amazon Lightsail instance.
    /// </summary>
    public partial class AttachStaticIpRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The instance name to which you want to attach the static IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceName property is set.
        /// </summary>
        internal bool IsSetInstanceName() => this.InstanceName != null;

        /// <summary>
        /// Gets and sets the property StaticIpName. 
        /// <para>
        /// The name of the static IP.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StaticIpName { get; set; }

        /// <summary>
        /// Checks to see if the StaticIpName property is set.
        /// </summary>
        internal bool IsSetStaticIpName() => this.StaticIpName != null;
    }
}
