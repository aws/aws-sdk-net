/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// The event criteria that specify when a webhook notification is sent to your URL.
    /// </summary>
    public partial class WebhookFilterRule
    {
        private string _jsonPath;
        private string _matchEquals;

        /// <summary>
        /// Gets and sets the property JsonPath. 
        /// <para>
        /// A JsonPath expression that will be applied to the body/payload of the webhook. The
        /// value selected by JsonPath expression must match the value specified in the matchEquals
        /// field, otherwise the request will be ignored. More information on JsonPath expressions
        /// can be found here: https://github.com/json-path/JsonPath.
        /// </para>
        /// </summary>
        public string JsonPath
        {
            get { return this._jsonPath; }
            set { this._jsonPath = value; }
        }

        // Check to see if JsonPath property is set
        internal bool IsSetJsonPath()
        {
            return this._jsonPath != null;
        }

        /// <summary>
        /// Gets and sets the property MatchEquals. 
        /// <para>
        /// The value selected by the JsonPath expression must match what is supplied in the MatchEquals
        /// field, otherwise the request will be ignored. Properties from the target action configuration
        /// can be included as placeholders in this value by surrounding the action configuration
        /// key with curly braces. For example, if the value supplied here is "refs/heads/{Branch}"
        /// and the target action has an action configuration property called "Branch" with a
        /// value of "master", the MatchEquals value will be evaluated as "refs/heads/master".
        /// A list of action configuration properties for built-in action types can be found here:
        /// <a href="http://docs.aws.amazon.com/codepipeline/latest/userguide/reference-pipeline-structure.html#action-requirements">Pipeline
        /// Structure Reference Action Requirements</a>.
        /// </para>
        /// </summary>
        public string MatchEquals
        {
            get { return this._matchEquals; }
            set { this._matchEquals = value; }
        }

        // Check to see if MatchEquals property is set
        internal bool IsSetMatchEquals()
        {
            return this._matchEquals != null;
        }

    }
}