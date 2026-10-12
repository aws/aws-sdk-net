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

namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProfile operation. Creates a customer profile.
    /// You can have up to five customer profiles, each representing a distinct private network.
    /// A profile is the mechanism used to create the concept of a private network.
    /// </summary>
    public partial class CreateProfileRequest : AmazonB2biRequest
    {
        /// <summary>
        /// Gets and sets the property BusinessName. 
        /// <para>
        /// Specifies the name for the business associated with this profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 254)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Checks to see if the BusinessName property is set.
        /// </summary>
        internal bool IsSetBusinessName() => this.BusinessName != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// Specifies the email address associated with this customer profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 5, Max = 254)]
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property Logging. 
        /// <para>
        /// Specifies whether or not logging is enabled for this profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Logging Logging { get; set; }

        /// <summary>
        /// Checks to see if the Logging property is set.
        /// </summary>
        internal bool IsSetLogging() => this.Logging != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 254)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Phone. 
        /// <para>
        /// Specifies the phone number associated with the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 7, Max = 22)]
        public string Phone { get; set; }

        /// <summary>
        /// Checks to see if the Phone property is set.
        /// </summary>
        internal bool IsSetPhone() => this.Phone != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies the key-value pairs assigned to ARNs that you can use to group and search
        /// for resources by type. You can attach this metadata to resources (capabilities, partnerships,
        /// and so on) for any purpose.
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
