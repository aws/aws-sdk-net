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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApnsSandboxChannel operation.
    /// Enables the APNs sandbox channel for an application or updates the status and settings
    /// of the APNs sandbox channel for an application.
    /// </summary>
    public partial class UpdateApnsSandboxChannelRequest : AmazonPinpointRequest
    {
        private APNSSandboxChannelRequest _apnsSandboxChannelRequest;
        private string _applicationId;

        /// <summary>
        /// Gets and sets the property APNSSandboxChannelRequest.
        /// </summary>
        [AWSProperty(Required=true)]
        public APNSSandboxChannelRequest APNSSandboxChannelRequest
        {
            get { return this._apnsSandboxChannelRequest; }
            set { this._apnsSandboxChannelRequest = value; }
        }

        // Check to see if APNSSandboxChannelRequest property is set
        internal bool IsSetAPNSSandboxChannelRequest()
        {
            return this._apnsSandboxChannelRequest != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application. This identifier is displayed as the <b>Project
        /// ID</b> on the Amazon Pinpoint console.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

    }
}