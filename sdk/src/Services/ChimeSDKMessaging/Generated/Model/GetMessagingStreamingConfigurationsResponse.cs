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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// This is the response object from the GetMessagingStreamingConfigurations operation.
    /// </summary>
    public partial class GetMessagingStreamingConfigurationsResponse : AmazonWebServiceResponse
    {
        private List<StreamingConfiguration> _streamingConfigurations = new List<StreamingConfiguration>();

        /// <summary>
        /// Gets and sets the property StreamingConfigurations. 
        /// <para>
        /// The streaming settings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<StreamingConfiguration> StreamingConfigurations
        {
            get { return this._streamingConfigurations; }
            set { this._streamingConfigurations = value; }
        }

        // Check to see if StreamingConfigurations property is set
        internal bool IsSetStreamingConfigurations()
        {
            return this._streamingConfigurations != null && this._streamingConfigurations.Count > 0; 
        }

    }
}