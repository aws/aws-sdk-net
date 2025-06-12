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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
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
namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes the data schema for a code generation job.
    /// </summary>
    public partial class CodegenJobGenericDataSchema
    {
        private CodegenJobGenericDataSourceType _dataSourceType;
        private Dictionary<string, CodegenGenericDataEnum> _enums = AWSConfigs.InitializeCollections ? new Dictionary<string, CodegenGenericDataEnum>() : null;
        private Dictionary<string, CodegenGenericDataModel> _models = AWSConfigs.InitializeCollections ? new Dictionary<string, CodegenGenericDataModel>() : null;
        private Dictionary<string, CodegenGenericDataNonModel> _nonModels = AWSConfigs.InitializeCollections ? new Dictionary<string, CodegenGenericDataNonModel>() : null;

        /// <summary>
        /// Gets and sets the property DataSourceType. 
        /// <para>
        /// The type of the data source for the schema. Currently, the only valid value is an
        /// Amplify <c>DataStore</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CodegenJobGenericDataSourceType DataSourceType
        {
            get { return this._dataSourceType; }
            set { this._dataSourceType = value; }
        }

        // Check to see if DataSourceType property is set
        internal bool IsSetDataSourceType()
        {
            return this._dataSourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Enums. 
        /// <para>
        /// The name of a <c>CodegenGenericDataEnum</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, CodegenGenericDataEnum> Enums
        {
            get { return this._enums; }
            set { this._enums = value; }
        }

        // Check to see if Enums property is set
        internal bool IsSetEnums()
        {
            return this._enums != null && (this._enums.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Models. 
        /// <para>
        /// The name of a <c>CodegenGenericDataModel</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, CodegenGenericDataModel> Models
        {
            get { return this._models; }
            set { this._models = value; }
        }

        // Check to see if Models property is set
        internal bool IsSetModels()
        {
            return this._models != null && (this._models.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NonModels. 
        /// <para>
        /// The name of a <c>CodegenGenericDataNonModel</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, CodegenGenericDataNonModel> NonModels
        {
            get { return this._nonModels; }
            set { this._nonModels = value; }
        }

        // Check to see if NonModels property is set
        internal bool IsSetNonModels()
        {
            return this._nonModels != null && (this._nonModels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}