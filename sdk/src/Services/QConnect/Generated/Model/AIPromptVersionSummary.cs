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
    /// The summary of the AI Prompt version.
    /// </summary>
    public partial class AIPromptVersionSummary
    {
        private AIPromptSummary _aiPromptSummary;
        private long? _versionNumber;

        /// <summary>
        /// Gets and sets the property AiPromptSummary. 
        /// <para>
        /// The date for the summary of the AI Prompt version.
        /// </para>
        /// </summary>
        public AIPromptSummary AiPromptSummary
        {
            get { return this._aiPromptSummary; }
            set { this._aiPromptSummary = value; }
        }

        // Check to see if AiPromptSummary property is set
        internal bool IsSetAiPromptSummary()
        {
            return this._aiPromptSummary != null;
        }

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number for this AI Prompt version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? VersionNumber
        {
            get { return this._versionNumber; }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}