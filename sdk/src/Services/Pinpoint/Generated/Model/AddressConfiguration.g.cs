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
    /// Specifies address-based configuration settings for a message that's sent directly
    /// to an endpoint.
    /// </summary>
    public partial class AddressConfiguration
    {
        /// <summary>
        /// Gets and sets the property BodyOverride. 
        /// <para>
        /// The message body to use instead of the default message body. This value overrides
        /// the default message body.
        /// </para>
        /// </summary>
        public string BodyOverride { get; set; }

        /// <summary>
        /// Checks to see if the BodyOverride property is set.
        /// </summary>
        internal bool IsSetBodyOverride() => this.BodyOverride != null;

        /// <summary>
        /// Gets and sets the property ChannelType. 
        /// <para>
        /// The channel to use when sending the message.
        /// </para>
        /// </summary>
        public ChannelType ChannelType { get; set; }

        /// <summary>
        /// Checks to see if the ChannelType property is set.
        /// </summary>
        internal bool IsSetChannelType() => this.ChannelType != null;

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// An object that maps custom attributes to attributes for the address and is attached
        /// to the message. Attribute names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// For a push notification, this payload is added to the data.pinpoint object. For an
        /// email or text message, this payload is added to email/SMS delivery receipt event attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Context { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null && (this.Context.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RawContent. 
        /// <para>
        /// The raw, JSON-formatted string to use as the payload for the message. If specified,
        /// this value overrides all other values for the message.
        /// </para>
        /// </summary>
        public string RawContent { get; set; }

        /// <summary>
        /// Checks to see if the RawContent property is set.
        /// </summary>
        internal bool IsSetRawContent() => this.RawContent != null;

        /// <summary>
        /// Gets and sets the property Substitutions. 
        /// <para>
        /// A map of the message variables to merge with the variables specified by properties
        /// of the DefaultMessage object. The variables specified in this map take precedence
        /// over all other variables.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> Substitutions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Substitutions property is set.
        /// </summary>
        internal bool IsSetSubstitutions() => this.Substitutions != null && (this.Substitutions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TitleOverride. 
        /// <para>
        /// The message title to use instead of the default message title. This value overrides
        /// the default message title.
        /// </para>
        /// </summary>
        public string TitleOverride { get; set; }

        /// <summary>
        /// Checks to see if the TitleOverride property is set.
        /// </summary>
        internal bool IsSetTitleOverride() => this.TitleOverride != null;
    }
}
