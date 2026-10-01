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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// This is the response object from the SaveBrowserSessionProfile operation.
    /// </summary>
    public partial class SaveBrowserSessionProfileResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BrowserIdentifier. 
        /// <para>
        /// The unique identifier of the browser associated with the session from which the profile
        /// was saved.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BrowserIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the BrowserIdentifier property is set.
        /// </summary>
        internal bool IsSetBrowserIdentifier() => this.BrowserIdentifier != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the browser profile was last updated. This value is in ISO 8601
        /// format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ProfileIdentifier. 
        /// <para>
        /// The unique identifier of the saved browser profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProfileIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProfileIdentifier property is set.
        /// </summary>
        internal bool IsSetProfileIdentifier() => this.ProfileIdentifier != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the browser session from which the profile was saved.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;
    }
}
