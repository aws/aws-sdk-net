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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains configurations for a knowledge base connected to an SQL database. Specify
    /// the SQL database type in the <c>type</c> field and include the corresponding field.
    /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-build-structured.html">Build
    /// a knowledge base by connecting to a structured data source</a> in the Amazon Bedrock
    /// User Guide.
    /// </summary>
    public partial class SqlKnowledgeBaseConfiguration
    {
        private RedshiftConfiguration _redshiftConfiguration;
        private QueryEngineType _type;

        /// <summary>
        /// Gets and sets the property RedshiftConfiguration. 
        /// <para>
        /// Specifies configurations for a knowledge base connected to an Amazon Redshift database.
        /// </para>
        /// </summary>
        public RedshiftConfiguration RedshiftConfiguration
        {
            get { return this._redshiftConfiguration; }
            set { this._redshiftConfiguration = value; }
        }

        // Check to see if RedshiftConfiguration property is set
        internal bool IsSetRedshiftConfiguration()
        {
            return this._redshiftConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of SQL database to connect to the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueryEngineType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}