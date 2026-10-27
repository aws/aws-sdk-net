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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteSlotType operation. Deletes a slot type
    /// from a bot locale. <para> If a slot is using the slot type, Amazon Lex throws a <c>ResourceInUseException</c>
    /// exception. To avoid the exception, set the <c>skipResourceInUseCheck</c> parameter
    /// to <c>true</c>. </para>
    /// </summary>
    public partial class DeleteSlotTypeRequest : AmazonLexModelsV2Request
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot associated with the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot associated with the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The identifier of the language and locale that the slot type will be deleted from.
        /// The string must match one of the supported locales. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
        /// languages</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

        /// <summary>
        /// Gets and sets the property SkipResourceInUseCheck. 
        /// <para>
        /// By default, the <c>DeleteSlotType</c> operations throws a <c>ResourceInUseException</c>
        /// exception if you try to delete a slot type used by a slot. Set the <c>skipResourceInUseCheck</c>
        /// parameter to <c>true</c> to skip this check and remove the slot type even if a slot
        /// uses it.
        /// </para>
        /// </summary>
        public bool? SkipResourceInUseCheck { get; set; }

        /// <summary>
        /// Checks to see if the SkipResourceInUseCheck property is set.
        /// </summary>
        internal bool IsSetSkipResourceInUseCheck() => this.SkipResourceInUseCheck.HasValue;

        /// <summary>
        /// Gets and sets the property SlotTypeId. 
        /// <para>
        /// The identifier of the slot type to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string SlotTypeId { get; set; }

        /// <summary>
        /// Checks to see if the SlotTypeId property is set.
        /// </summary>
        internal bool IsSetSlotTypeId() => this.SlotTypeId != null;
    }
}
