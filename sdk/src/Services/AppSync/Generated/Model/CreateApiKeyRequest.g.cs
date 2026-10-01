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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApiKey operation. Creates a unique key that
    /// you can distribute to clients who invoke your API.
    /// </summary>
    public partial class CreateApiKeyRequest : AmazonAppSyncRequest
    {
        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The ID for your GraphQL API.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApiId { get; set; }

        /// <summary>
        /// Checks to see if the ApiId property is set.
        /// </summary>
        internal bool IsSetApiId() => this.ApiId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the purpose of the API key.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Expires. 
        /// <para>
        /// From the creation time, the time after which the API key expires. The date is represented
        /// as seconds since the epoch, rounded down to the nearest hour. The default value for
        /// this parameter is 7 days from creation time. For more information, see .
        /// </para>
        /// </summary>
        public long? Expires { get; set; }

        /// <summary>
        /// Checks to see if the Expires property is set.
        /// </summary>
        internal bool IsSetExpires() => this.Expires.HasValue;
    }
}
