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
    /// Contains specifications about the generative AI capabilities from Amazon Bedrock that
    /// you can turn on for your bot.
    /// </summary>
    public partial class GenerativeAISettings
    {
        private BuildtimeSettings _buildtimeSettings;
        private RuntimeSettings _runtimeSettings;

        /// <summary>
        /// Gets and sets the property BuildtimeSettings.
        /// </summary>
        public BuildtimeSettings BuildtimeSettings
        {
            get { return this._buildtimeSettings; }
            set { this._buildtimeSettings = value; }
        }

        // Check to see if BuildtimeSettings property is set
        internal bool IsSetBuildtimeSettings()
        {
            return this._buildtimeSettings != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeSettings.
        /// </summary>
        public RuntimeSettings RuntimeSettings
        {
            get { return this._runtimeSettings; }
            set { this._runtimeSettings = value; }
        }

        // Check to see if RuntimeSettings property is set
        internal bool IsSetRuntimeSettings()
        {
            return this._runtimeSettings != null;
        }

    }
}