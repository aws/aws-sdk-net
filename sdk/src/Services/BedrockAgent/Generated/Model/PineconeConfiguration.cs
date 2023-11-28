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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains the configurations to use Pinecone to store knowledge base data.
    /// </summary>
    public partial class PineconeConfiguration
    {
        private string _connectionString;
        private string _credentialsSecretArn;
        private PineconeFieldMapping _fieldMapping;
        private string _awsNamespace;

        /// <summary>
        /// Gets and sets the property ConnectionString.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string ConnectionString
        {
            get { return this._connectionString; }
            set { this._connectionString = value; }
        }

        // Check to see if ConnectionString property is set
        internal bool IsSetConnectionString()
        {
            return this._connectionString != null;
        }

        /// <summary>
        /// Gets and sets the property CredentialsSecretArn.
        /// </summary>
        [AWSProperty(Required=true)]
        public string CredentialsSecretArn
        {
            get { return this._credentialsSecretArn; }
            set { this._credentialsSecretArn = value; }
        }

        // Check to see if CredentialsSecretArn property is set
        internal bool IsSetCredentialsSecretArn()
        {
            return this._credentialsSecretArn != null;
        }

        /// <summary>
        /// Gets and sets the property FieldMapping.
        /// </summary>
        [AWSProperty(Required=true)]
        public PineconeFieldMapping FieldMapping
        {
            get { return this._fieldMapping; }
            set { this._fieldMapping = value; }
        }

        // Check to see if FieldMapping property is set
        internal bool IsSetFieldMapping()
        {
            return this._fieldMapping != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace.
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

    }
}