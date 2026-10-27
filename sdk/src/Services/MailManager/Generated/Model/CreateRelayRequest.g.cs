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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRelay operation. Creates a relay resource
    /// which can be used in rules to relay incoming emails to defined relay destinations.
    /// </summary>
    public partial class CreateRelayRequest : AmazonMailManagerRequest
    {
        /// <summary>
        /// Gets and sets the property Authentication. 
        /// <para>
        /// Authentication for the relay destination server—specify the secretARN where the SMTP
        /// credentials are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RelayAuthentication Authentication { get; set; }

        /// <summary>
        /// Checks to see if the Authentication property is set.
        /// </summary>
        internal bool IsSetAuthentication() => this.Authentication != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique token that Amazon SES uses to recognize subsequent retries of the same request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property RelayName. 
        /// <para>
        /// The unique name of the relay resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string RelayName { get; set; }

        /// <summary>
        /// Checks to see if the RelayName property is set.
        /// </summary>
        internal bool IsSetRelayName() => this.RelayName != null;

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The destination relay server address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ServerName { get; set; }

        /// <summary>
        /// Checks to see if the ServerName property is set.
        /// </summary>
        internal bool IsSetServerName() => this.ServerName != null;

        /// <summary>
        /// Gets and sets the property ServerPort. 
        /// <para>
        /// The destination relay server port.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 65535)]
        public int? ServerPort { get; set; }

        /// <summary>
        /// Checks to see if the ServerPort property is set.
        /// </summary>
        internal bool IsSetServerPort() => this.ServerPort.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for the resource. For example,
        /// { "tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
