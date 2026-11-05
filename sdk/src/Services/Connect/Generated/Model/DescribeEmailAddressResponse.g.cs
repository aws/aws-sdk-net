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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the DescribeEmailAddress operation.
    /// </summary>
    public partial class DescribeEmailAddressResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AliasConfigurations. 
        /// <para>
        /// A list of alias configurations associated with this email address. Contains details
        /// about email addresses that forward to this primary email address. The list can contain
        /// at most one alias configuration per email address.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<AliasConfiguration> AliasConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<AliasConfiguration>() : null;

        /// <summary>
        /// Checks to see if the AliasConfigurations property is set.
        /// </summary>
        internal bool IsSetAliasConfigurations() => this.AliasConfigurations != null && (this.AliasConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// The email address creation timestamp in ISO 8601 Datetime.
        /// </para>
        /// </summary>
        public string CreateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreateTimestamp property is set.
        /// </summary>
        internal bool IsSetCreateTimestamp() => this.CreateTimestamp != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the email address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of email address
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address, including the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null;

        /// <summary>
        /// Gets and sets the property EmailAddressArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the email address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string EmailAddressArn { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddressArn property is set.
        /// </summary>
        internal bool IsSetEmailAddressArn() => this.EmailAddressArn != null;

        /// <summary>
        /// Gets and sets the property EmailAddressId. 
        /// <para>
        /// The identifier of the email address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string EmailAddressId { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddressId property is set.
        /// </summary>
        internal bool IsSetEmailAddressId() => this.EmailAddressId != null;

        /// <summary>
        /// Gets and sets the property ModifiedTimestamp. 
        /// <para>
        /// The email address last modification timestamp in ISO 8601 Datetime.
        /// </para>
        /// </summary>
        public string ModifiedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedTimestamp property is set.
        /// </summary>
        internal bool IsSetModifiedTimestamp() => this.ModifiedTimestamp != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "Tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
