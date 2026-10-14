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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Contains information about a client secret, including its unique identifier, value,
    /// and creation timestamp.
    /// </summary>
    public partial class ClientSecretDescriptorType
    {
        /// <summary>
        /// Gets and sets the property ClientSecretCreateDate. 
        /// <para>
        /// The date and time when the client secret was created.
        /// </para>
        /// </summary>
        public DateTime? ClientSecretCreateDate { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecretCreateDate property is set.
        /// </summary>
        internal bool IsSetClientSecretCreateDate() => this.ClientSecretCreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property ClientSecretId. 
        /// <para>
        /// The unique identifier for the client secret. This identifier follows the format &lt;client-id&gt;--&lt;epoch-create-time&gt;.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientSecretId { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecretId property is set.
        /// </summary>
        internal bool IsSetClientSecretId() => this.ClientSecretId != null;

        /// <summary>
        /// Gets and sets the property ClientSecretValue. 
        /// <para>
        /// The actual secret value. This is only returned when creating a new secret and only
        /// if Amazon Cognito generated the secret. For custom secrets that you provide, this
        /// field is not included in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 24, Max = 64)]
        public string ClientSecretValue { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecretValue property is set.
        /// </summary>
        internal bool IsSetClientSecretValue() => this.ClientSecretValue != null;
    }
}
