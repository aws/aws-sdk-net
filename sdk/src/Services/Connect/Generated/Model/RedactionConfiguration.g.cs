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
    /// The redaction configuration for conversational analytics.
    /// </summary>
    public partial class RedactionConfiguration
    {
        /// <summary>
        /// Gets and sets the property Behavior. 
        /// <para>
        /// Controls whether redaction is applied to the analytics output. Valid values: <c>Enable</c>
        /// | <c>Disable</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Behavior Behavior { get; set; }

        /// <summary>
        /// Checks to see if the Behavior property is set.
        /// </summary>
        internal bool IsSetBehavior() => this.Behavior != null;

        /// <summary>
        /// Gets and sets the property Entities. 
        /// <para>
        /// The list of PII entity types to redact from the transcript (for example, <c>NAME</c>,
        /// <c>ADDRESS</c>, <c>CREDIT_DEBIT_NUMBER</c>).
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
        /// The masking mode that determines how redacted content is replaced in the output. Valid
        /// values: <c>PII</c> (replaces with the literal string [PII]) | <c>EntityType</c> (replaces
        /// with the entity type name, for example [NAME]).
        /// </para>
        /// </summary>
        public MaskMode MaskMode { get; set; }

        /// <summary>
        /// Checks to see if the MaskMode property is set.
        /// </summary>
        internal bool IsSetMaskMode() => this.MaskMode != null;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The redaction output policy that determines which versions of the transcript are stored.
        /// Valid values: <c>None</c> | <c>RedactedOnly</c> | <c>RedactedAndOriginal</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Policy Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;
    }
}
