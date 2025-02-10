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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains configurations for transforming the natural language query into SQL.
    /// </summary>
    public partial class TransformationConfiguration
    {
        private QueryTransformationMode _mode;
        private TextToSqlConfiguration _textToSqlConfiguration;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode of the transformation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueryTransformationMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property TextToSqlConfiguration. 
        /// <para>
        /// Specifies configurations for transforming text to SQL.
        /// </para>
        /// </summary>
        public TextToSqlConfiguration TextToSqlConfiguration
        {
            get { return this._textToSqlConfiguration; }
            set { this._textToSqlConfiguration = value; }
        }

        // Check to see if TextToSqlConfiguration property is set
        internal bool IsSetTextToSqlConfiguration()
        {
            return this._textToSqlConfiguration != null;
        }

    }
}