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

namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Object specifying a participant token in a stage.
    /// 
    ///  
    /// <para>
    ///  <b>Important</b>: Treat tokens as opaque; i.e., do not build functionality based
    /// on token contents. The format of tokens could change in the future.
    /// </para>
    /// </summary>
    public partial class ParticipantToken
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Application-provided attributes to encode into the token and attach to a stage. Map
        /// keys and values can contain UTF-8 encoded text. The maximum length of this field is
        /// 1 KB total. <i>This field is exposed to all stage participants and should not be used
        /// for personally identifying, confidential, or sensitive information.</i> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// Set of capabilities that the user is allowed to perform in the stage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<string> Capabilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null && (this.Capabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// Duration (in minutes), after which the participant token expires. Default: 720 (12
        /// hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20160)]
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// ISO 8601 timestamp (returned as a string) for when this token expires.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationTime property is set.
        /// </summary>
        internal bool IsSetExpirationTime() => this.ExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// Unique identifier for this participant token, assigned by IVS.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string ParticipantId { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantId property is set.
        /// </summary>
        internal bool IsSetParticipantId() => this.ParticipantId != null;

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The issued client token, encrypted.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Token { get; set; }

        /// <summary>
        /// Checks to see if the Token property is set.
        /// </summary>
        internal bool IsSetToken() => this.Token != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// Customer-assigned name to help identify the token; this can be used to link a participant
        /// to a user in the customer’s own systems. This can be any UTF-8 encoded text. <i>This
        /// field is exposed to all stage participants and should not be used for personally identifying,
        /// confidential, or sensitive information.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
