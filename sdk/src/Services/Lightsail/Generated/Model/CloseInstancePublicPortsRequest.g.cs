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
    /// Container for the parameters to the CloseInstancePublicPorts operation. Closes ports
    /// for a specific Amazon Lightsail instance. <para> The <c>CloseInstancePublicPorts</c>
    /// action supports tag-based access control via resource tags applied to the resource
    /// identified by <c>instanceName</c>. For more information, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-controlling-access-using-tags">Amazon
    /// Lightsail Developer Guide</a>. </para>
    /// </summary>
    public partial class CloseInstancePublicPortsRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of the instance for which to close ports.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceName property is set.
        /// </summary>
        internal bool IsSetInstanceName() => this.InstanceName != null;

        /// <summary>
        /// Gets and sets the property PortInfo. 
        /// <para>
        /// An object to describe the ports to close for the specified instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PortInfo PortInfo { get; set; }

        /// <summary>
        /// Checks to see if the PortInfo property is set.
        /// </summary>
        internal bool IsSetPortInfo() => this.PortInfo != null;
    }
}
