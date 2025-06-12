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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// The input schema supported by provider service.
    /// </summary>
    public partial class ProviderComponentSchema
    {
        private List<ProviderSchemaAttribute> _providerSchemaAttributes = AWSConfigs.InitializeCollections ? new List<ProviderSchemaAttribute>() : null;
        private List<List<string>> _schemas = AWSConfigs.InitializeCollections ? new List<List<string>>() : null;

        /// <summary>
        /// Gets and sets the property ProviderSchemaAttributes. 
        /// <para>
        /// The provider schema attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProviderSchemaAttribute> ProviderSchemaAttributes
        {
            get { return this._providerSchemaAttributes; }
            set { this._providerSchemaAttributes = value; }
        }

        // Check to see if ProviderSchemaAttributes property is set
        internal bool IsSetProviderSchemaAttributes()
        {
            return this._providerSchemaAttributes != null && (this._providerSchemaAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Schemas. 
        /// <para>
        /// Input schema for the provider service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<List<string>> Schemas
        {
            get { return this._schemas; }
            set { this._schemas = value; }
        }

        // Check to see if Schemas property is set
        internal bool IsSetSchemas()
        {
            return this._schemas != null && (this._schemas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}