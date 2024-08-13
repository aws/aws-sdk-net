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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
    /// Container for the parameters to the DeleteSlotType operation.
    /// Deletes a slot type from a bot locale.
    /// 
    ///  
    /// <para>
    /// If a slot is using the slot type, Amazon Lex throws a <c>ResourceInUseException</c>
    /// exception. To avoid the exception, set the <c>skipResourceInUseCheck</c> parameter
    /// to <c>true</c>.
    /// </para>
    /// </summary>
    public partial class DeleteSlotTypeRequest : AmazonLexModelsV2Request
    {
        private string _botId;
        private string _botVersion;
        private string _localeId;
        private bool? _skipResourceInUseCheck;
        private string _slotTypeId;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot associated with the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string BotId
        {
            get { return this._botId; }
            set { this._botId = value; }
        }

        // Check to see if BotId property is set
        internal bool IsSetBotId()
        {
            return this._botId != null;
        }

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot associated with the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=5)]
        public string BotVersion
        {
            get { return this._botVersion; }
            set { this._botVersion = value; }
        }

        // Check to see if BotVersion property is set
        internal bool IsSetBotVersion()
        {
            return this._botVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The identifier of the language and locale that the slot type will be deleted from.
        /// The string must match one of the supported locales. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
        /// languages</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LocaleId
        {
            get { return this._localeId; }
            set { this._localeId = value; }
        }

        // Check to see if LocaleId property is set
        internal bool IsSetLocaleId()
        {
            return this._localeId != null;
        }

        /// <summary>
        /// Gets and sets the property SkipResourceInUseCheck. 
        /// <para>
        /// By default, the <c>DeleteSlotType</c> operations throws a <c>ResourceInUseException</c>
        /// exception if you try to delete a slot type used by a slot. Set the <c>skipResourceInUseCheck</c>
        /// parameter to <c>true</c> to skip this check and remove the slot type even if a slot
        /// uses it.
        /// </para>
        /// </summary>
        public bool? SkipResourceInUseCheck
        {
            get { return this._skipResourceInUseCheck; }
            set { this._skipResourceInUseCheck = value; }
        }

        // Check to see if SkipResourceInUseCheck property is set
        internal bool IsSetSkipResourceInUseCheck()
        {
            return this._skipResourceInUseCheck.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SlotTypeId. 
        /// <para>
        /// The identifier of the slot type to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string SlotTypeId
        {
            get { return this._slotTypeId; }
            set { this._slotTypeId = value; }
        }

        // Check to see if SlotTypeId property is set
        internal bool IsSetSlotTypeId()
        {
            return this._slotTypeId != null;
        }

    }
}