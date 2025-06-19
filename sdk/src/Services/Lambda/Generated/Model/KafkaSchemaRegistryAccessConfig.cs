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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Specific access configuration settings that tell Lambda how to authenticate with your
    /// schema registry.
    /// 
    ///  
    /// <para>
    /// If you're working with an Glue schema registry, don't provide authentication details
    /// in this object. Instead, ensure that your execution role has the required permissions
    /// for Lambda to access your cluster.
    /// </para>
    ///  
    /// <para>
    /// If you're working with a Confluent schema registry, choose the authentication method
    /// in the <c>Type</c> field, and provide the Secrets Manager secret ARN in the <c>URI</c>
    /// field.
    /// </para>
    /// </summary>
    public partial class KafkaSchemaRegistryAccessConfig
    {
        private KafkaSchemaRegistryAuthType _type;
        private string _uri;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of authentication Lambda uses to access your schema registry. 
        /// </para>
        /// </summary>
        public KafkaSchemaRegistryAuthType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property URI. 
        /// <para>
        ///  The URI of the secret (Secrets Manager secret ARN) to authenticate with your schema
        /// registry. 
        /// </para>
        /// </summary>
        public string URI
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if URI property is set
        internal bool IsSetURI()
        {
            return this._uri != null;
        }

    }
}