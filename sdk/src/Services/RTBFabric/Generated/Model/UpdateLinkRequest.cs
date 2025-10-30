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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
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
namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLink operation.
    /// Updates the configuration of a link between gateways.
    /// 
    ///  
    /// <para>
    /// Allows you to modify settings and parameters for an existing link.
    /// </para>
    /// </summary>
    public partial class UpdateLinkRequest : AmazonRTBFabricRequest
    {
        private string _gatewayId;
        private string _linkId;
        private LinkLogSettings _logSettings;

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The unique identifier of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GatewayId
        {
            get { return this._gatewayId; }
            set { this._gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this._gatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property LinkId. 
        /// <para>
        /// The unique identifier of the link.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LinkId
        {
            get { return this._linkId; }
            set { this._linkId = value; }
        }

        // Check to see if LinkId property is set
        internal bool IsSetLinkId()
        {
            return this._linkId != null;
        }

        /// <summary>
        /// Gets and sets the property LogSettings. 
        /// <para>
        /// Settings for the application logs.
        /// </para>
        /// </summary>
        public LinkLogSettings LogSettings
        {
            get { return this._logSettings; }
            set { this._logSettings = value; }
        }

        // Check to see if LogSettings property is set
        internal bool IsSetLogSettings()
        {
            return this._logSettings != null;
        }

    }
}