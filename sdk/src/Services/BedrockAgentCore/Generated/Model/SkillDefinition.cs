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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// The structured skill definition with a schema version and inline content.
    /// </summary>
    public partial class SkillDefinition
    {
        private string _inlineContent;
        private string _schemaVersion;

        /// <summary>
        /// Gets and sets the property InlineContent. 
        /// <para>
        ///  The inline content of the skill definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=409600)]
        public string InlineContent
        {
            get { return this._inlineContent; }
            set { this._inlineContent = value; }
        }

        // Check to see if InlineContent property is set
        internal bool IsSetInlineContent()
        {
            return this._inlineContent != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        ///  The schema version of the skill definition. If you don't specify a version, the service
        /// detects it automatically.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SchemaVersion
        {
            get { return this._schemaVersion; }
            set { this._schemaVersion = value; }
        }

        // Check to see if SchemaVersion property is set
        internal bool IsSetSchemaVersion()
        {
            return this._schemaVersion != null;
        }

    }
}