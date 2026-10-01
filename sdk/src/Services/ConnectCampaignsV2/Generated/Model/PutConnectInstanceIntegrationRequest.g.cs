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

namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutConnectInstanceIntegration operation. Put or
    /// update the integration for the specified Amazon Connect instance.
    /// </summary>
    public partial class PutConnectInstanceIntegrationRequest : AmazonConnectCampaignsV2Request
    {
        /// <summary>
        /// Gets and sets the property ConnectInstanceId.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ConnectInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectInstanceId property is set.
        /// </summary>
        internal bool IsSetConnectInstanceId() => this.ConnectInstanceId != null;

        /// <summary>
        /// Gets and sets the property IntegrationConfig.
        /// </summary>
        [AWSProperty(Required = true)]
        public IntegrationConfig IntegrationConfig { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationConfig property is set.
        /// </summary>
        internal bool IsSetIntegrationConfig() => this.IntegrationConfig != null;
    }
}
