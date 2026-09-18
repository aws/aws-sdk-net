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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Configuration parameters for customizing HTTP requests sent to the ad decision server
    /// (ADS). This allows you to specify the HTTP method, headers, request body, and compression
    /// settings for ADS requests.
    /// </summary>
    public partial class AdDecisionServerConfiguration
    {
        /// <summary>
        /// Gets and sets the property HttpRequest. 
        /// <para>
        /// The HTTP request configuration parameters for the ad decision server.
        /// </para>
        /// </summary>
        public HttpRequest HttpRequest { get; set; }

        /// <summary>
        /// Checks to see if the HttpRequest property is set.
        /// </summary>
        internal bool IsSetHttpRequest() => this.HttpRequest != null;

        /// <summary>
        /// Gets and sets the property VastResponse. 
        /// <para>
        /// The settings that control how MediaTailor processes VAST responses from the ad decision
        /// server.
        /// </para>
        /// </summary>
        public VastResponse VastResponse { get; set; }

        /// <summary>
        /// Checks to see if the VastResponse property is set.
        /// </summary>
        internal bool IsSetVastResponse() => this.VastResponse != null;
    }
}
