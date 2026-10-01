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

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Provides information about a built in slot type.
    /// </summary>
    public partial class BuiltinSlotTypeMetadata
    {
        /// <summary>
        /// Gets and sets the property Signature. 
        /// <para>
        /// A unique identifier for the built-in slot type. To find the signature for a slot type,
        /// see <a href="https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/built-in-intent-ref/slot-type-reference">Slot
        /// Type Reference</a> in the <i>Alexa Skills Kit</i>.
        /// </para>
        /// </summary>
        public string Signature { get; set; }

        /// <summary>
        /// Checks to see if the Signature property is set.
        /// </summary>
        internal bool IsSetSignature() => this.Signature != null;

        /// <summary>
        /// Gets and sets the property SupportedLocales. 
        /// <para>
        /// A list of target locales for the slot. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedLocales { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedLocales property is set.
        /// </summary>
        internal bool IsSetSupportedLocales() => this.SupportedLocales != null && (this.SupportedLocales.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
