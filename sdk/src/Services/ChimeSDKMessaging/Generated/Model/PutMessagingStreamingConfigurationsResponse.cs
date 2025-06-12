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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// This is the response object from the PutMessagingStreamingConfigurations operation.
    /// </summary>
    public partial class PutMessagingStreamingConfigurationsResponse : AmazonWebServiceResponse
    {
        private List<StreamingConfiguration> _streamingConfigurations = AWSConfigs.InitializeCollections ? new List<StreamingConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property StreamingConfigurations. 
        /// <para>
        /// The requested streaming configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._streamingConfigurations != null && (this._streamingConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}