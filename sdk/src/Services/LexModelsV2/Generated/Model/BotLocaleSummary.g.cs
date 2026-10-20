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
    /// Summary information about bot locales returned by the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_ListBotLocales.html">ListBotLocales</a>
    /// operation.
    /// </summary>
    public partial class BotLocaleSummary
    {
        /// <summary>
        /// Gets and sets the property BotLocaleStatus. 
        /// <para>
        /// The current status of the bot locale. When the status is <c>Built</c> the locale is
        /// ready for use.
        /// </para>
        /// </summary>
        public BotLocaleStatus BotLocaleStatus { get; set; }

        /// <summary>
        /// Checks to see if the BotLocaleStatus property is set.
        /// </summary>
        internal bool IsSetBotLocaleStatus() => this.BotLocaleStatus != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the bot locale.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastBuildSubmittedDateTime. 
        /// <para>
        /// A timestamp of the date and time that the bot locale was last built.
        /// </para>
        /// </summary>
        public DateTime? LastBuildSubmittedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastBuildSubmittedDateTime property is set.
        /// </summary>
        internal bool IsSetLastBuildSubmittedDateTime() => this.LastBuildSubmittedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// A timestamp of the date and time that the bot locale was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The language and locale of the bot locale.
        /// </para>
        /// </summary>
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

        /// <summary>
        /// Gets and sets the property LocaleName. 
        /// <para>
        /// The name of the bot locale.
        /// </para>
        /// </summary>
        public string LocaleName { get; set; }

        /// <summary>
        /// Checks to see if the LocaleName property is set.
        /// </summary>
        internal bool IsSetLocaleName() => this.LocaleName != null;
    }
}
