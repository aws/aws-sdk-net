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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Information for a single API key. 
    /// 
    ///  
    /// <para>
    /// API keys are required for the integration of the CAPTCHA API in your JavaScript client
    /// applications. The API lets you customize the placement and characteristics of the
    /// CAPTCHA puzzle for your end users. For more information about the CAPTCHA JavaScript
    /// integration, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
    /// client application integration</a> in the <i>WAF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class APIKeySummary
    {
        /// <summary>
        /// Gets and sets the property APIKey. 
        /// <para>
        /// The generated, encrypted API key. You can copy this for use in your JavaScript CAPTCHA
        /// integration. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string APIKey { get; set; }

        /// <summary>
        /// Checks to see if the APIKey property is set.
        /// </summary>
        internal bool IsSetAPIKey() => this.APIKey != null;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The date and time that the key was created. 
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimestamp property is set.
        /// </summary>
        internal bool IsSetCreationTimestamp() => this.CreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property TokenDomains. 
        /// <para>
        /// The token domains that are defined in this API key. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TokenDomains { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TokenDomains property is set.
        /// </summary>
        internal bool IsSetTokenDomains() => this.TokenDomains != null && (this.TokenDomains.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Internal value used by WAF to manage the key. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
