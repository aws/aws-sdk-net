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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Configuration settings for the EMAIL_OVERVIEW AI agent including prompt ID and locale
    /// settings.
    /// </summary>
    public partial class EmailOverviewAIAgentConfiguration
    {
        private string _emailOverviewAIPromptId;
        private string _locale;

        /// <summary>
        /// Gets and sets the property EmailOverviewAIPromptId. 
        /// <para>
        /// The ID of the System AI prompt used for generating structured email conversation summaries.
        /// </para>
        /// </summary>
        public string EmailOverviewAIPromptId
        {
            get { return this._emailOverviewAIPromptId; }
            set { this._emailOverviewAIPromptId = value; }
        }

        // Check to see if EmailOverviewAIPromptId property is set
        internal bool IsSetEmailOverviewAIPromptId()
        {
            return this._emailOverviewAIPromptId != null;
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale setting for language-specific email overview processing (for example, en_US,
        /// es_ES).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

    }
}