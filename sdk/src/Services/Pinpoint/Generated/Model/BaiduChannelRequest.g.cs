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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the status and settings of the Baidu (Baidu Cloud Push) channel for an application.
    /// </summary>
    public partial class BaiduChannelRequest
    {
        /// <summary>
        /// Gets and sets the property ApiKey. 
        /// <para>
        /// The API key that you received from the Baidu Cloud Push service to communicate with
        /// the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApiKey { get; set; }

        /// <summary>
        /// Checks to see if the ApiKey property is set.
        /// </summary>
        internal bool IsSetApiKey() => this.ApiKey != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether to enable the Baidu channel for the application.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property SecretKey. 
        /// <para>
        /// The secret key that you received from the Baidu Cloud Push service to communicate
        /// with the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SecretKey { get; set; }

        /// <summary>
        /// Checks to see if the SecretKey property is set.
        /// </summary>
        internal bool IsSetSecretKey() => this.SecretKey != null;
    }
}
