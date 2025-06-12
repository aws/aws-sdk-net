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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the PutInstancePublicPorts operation.
    /// Opens ports for a specific Amazon Lightsail instance, and specifies the IP addresses
    /// allowed to connect to the instance through the ports, and the protocol. This action
    /// also closes all currently open ports that are not included in the request. Include
    /// all of the ports and the protocols you want to open in your <c>PutInstancePublicPorts</c>request.
    /// Or use the <c>OpenInstancePublicPorts</c> action to open ports without closing currently
    /// open ports.
    /// 
    ///  
    /// <para>
    /// The <c>PutInstancePublicPorts</c> action supports tag-based access control via resource
    /// tags applied to the resource identified by <c>instanceName</c>. For more information,
    /// see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-controlling-access-using-tags">Amazon
    /// Lightsail Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class PutInstancePublicPortsRequest : AmazonLightsailRequest
    {
        private string _instanceName;
        private List<PortInfo> _portInfos = AWSConfigs.InitializeCollections ? new List<PortInfo>() : null;

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of the instance for which to open ports.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

        /// <summary>
        /// Gets and sets the property PortInfos. 
        /// <para>
        /// An array of objects to describe the ports to open for the specified instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PortInfo> PortInfos
        {
            get { return this._portInfos; }
            set { this._portInfos = value; }
        }

        // Check to see if PortInfos property is set
        internal bool IsSetPortInfos()
        {
            return this._portInfos != null && (this._portInfos.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}