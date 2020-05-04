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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the UpdateGatewayCapabilityConfiguration operation.
    /// </summary>
    public partial class UpdateGatewayCapabilityConfigurationResponse : AmazonWebServiceResponse
    {
        private string _capabilityNamespace;
        private CapabilitySyncStatus _capabilitySyncStatus;

        /// <summary>
        /// Gets and sets the property CapabilityNamespace. 
        /// <para>
        /// The namespace of the gateway capability.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string CapabilityNamespace
        {
            get { return this._capabilityNamespace; }
            set { this._capabilityNamespace = value; }
        }

        // Check to see if CapabilityNamespace property is set
        internal bool IsSetCapabilityNamespace()
        {
            return this._capabilityNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property CapabilitySyncStatus. 
        /// <para>
        /// The synchronization status of the capability configuration. The sync status can be
        /// one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>IN_SYNC</code> – The gateway is running the capability configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OUT_OF_SYNC</code> – The gateway hasn't received the capability configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SYNC_FAILED</code> – The gateway rejected the capability configuration.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After you update a capability configuration, its sync status is <code>OUT_OF_SYNC</code>
        /// until the gateway receives and applies or rejects the updated configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CapabilitySyncStatus CapabilitySyncStatus
        {
            get { return this._capabilitySyncStatus; }
            set { this._capabilitySyncStatus = value; }
        }

        // Check to see if CapabilitySyncStatus property is set
        internal bool IsSetCapabilitySyncStatus()
        {
            return this._capabilitySyncStatus != null;
        }

    }
}