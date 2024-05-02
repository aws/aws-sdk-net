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
 * Do not modify this file. This file is generated from the schemas-2019-12-02.normal.json service model.
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
namespace Amazon.Schemas.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSchema operation.
    /// Updates the schema definition
    /// 
    ///  <note>
    /// <para>
    /// Inactive schemas will be deleted after two years.
    /// </para>
    /// </note>
    /// </summary>
    public partial class UpdateSchemaRequest : AmazonSchemasRequest
    {
        private string _clientTokenId;
        private string _content;
        private string _description;
        private string _registryName;
        private string _schemaName;
        private Type _type;

        /// <summary>
        /// Gets and sets the property ClientTokenId. 
        /// <para>
        /// The ID of the client token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=36)]
        public string ClientTokenId
        {
            get { return this._clientTokenId; }
            set { this._clientTokenId = value; }
        }

        // Check to see if ClientTokenId property is set
        internal bool IsSetClientTokenId()
        {
            return this._clientTokenId != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The source of the schema definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryName. 
        /// <para>
        /// The name of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RegistryName
        {
            get { return this._registryName; }
            set { this._registryName = value; }
        }

        // Check to see if RegistryName property is set
        internal bool IsSetRegistryName()
        {
            return this._registryName != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaName. 
        /// <para>
        /// The name of the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SchemaName
        {
            get { return this._schemaName; }
            set { this._schemaName = value; }
        }

        // Check to see if SchemaName property is set
        internal bool IsSetSchemaName()
        {
            return this._schemaName != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The schema type for the events schema.
        /// </para>
        /// </summary>
        public Type Type
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