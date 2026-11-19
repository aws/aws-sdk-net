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
    /// The redaction configuration for conversational analytics transcripts.
    /// </summary>
    public partial class ContactLensRedactionConfiguration
    {
        /// <summary>
        /// Gets and sets the property Behavior. 
        /// <para>
        /// Specifies whether redaction is enabled for sensitive data, such as personal information,
        /// in the conversational analytics output. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Enable</c> – Redaction is applied according to the other values in this object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Disable</c> – Redaction is not applied, and all other values in this object are
        /// ignored.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Behavior { get; set; }

        /// <summary>
        /// Checks to see if the Behavior property is set.
        /// </summary>
        internal bool IsSetBehavior() => this.Behavior != null;

        /// <summary>
        /// Gets and sets the property Entities. 
        /// <para>
        /// The entity types to redact from the transcript (for example, <c>NAME</c>, <c>EMAIL</c>,
        /// <c>ADDRESS</c>).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Entities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Entities property is set.
        /// </summary>
        internal bool IsSetEntities() => this.Entities != null && (this.Entities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaskMode. 
        /// <para>
        /// How sensitive information is masked in the transcript. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PII</c> – All redacted entities are replaced with the <c>[PII]</c> string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EntityType</c> – All redacted entities are replaced with the label of the entity.
        /// For example, when the <c>EMAIL</c> entity is configured for redaction, emails in the
        /// transcript are replaced with the <c>[EMAIL]</c> string.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string MaskMode { get; set; }

        /// <summary>
        /// Checks to see if the MaskMode property is set.
        /// </summary>
        internal bool IsSetMaskMode() => this.MaskMode != null;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The redaction policy that determines which versions of the transcript are stored.
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>None</c> – No redaction is applied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RedactedOnly</c> – Only the redacted transcript is stored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RedactedAndOriginal</c> – Both the redacted and the original transcript are stored.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;
    }
}
