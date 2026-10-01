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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property DataSourceType. 
        /// <para>
        /// The type of the data source for the schema. Currently, the only valid value is an
        /// Amplify <c>DataStore</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CodegenJobGenericDataSourceType DataSourceType { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceType property is set.
        /// </summary>
        internal bool IsSetDataSourceType() => this.DataSourceType != null;

        /// <summary>
        /// Gets and sets the property Enums. 
        /// <para>
        /// The name of a <c>CodegenGenericDataEnum</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, CodegenGenericDataEnum> Enums { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, CodegenGenericDataEnum>() : null;

        /// <summary>
        /// Checks to see if the Enums property is set.
        /// </summary>
        internal bool IsSetEnums() => this.Enums != null && (this.Enums.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Models. 
        /// <para>
        /// The name of a <c>CodegenGenericDataModel</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, CodegenGenericDataModel> Models { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, CodegenGenericDataModel>() : null;

        /// <summary>
        /// Checks to see if the Models property is set.
        /// </summary>
        internal bool IsSetModels() => this.Models != null && (this.Models.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NonModels. 
        /// <para>
        /// The name of a <c>CodegenGenericDataNonModel</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, CodegenGenericDataNonModel> NonModels { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, CodegenGenericDataNonModel>() : null;

        /// <summary>
        /// Checks to see if the NonModels property is set.
        /// </summary>
        internal bool IsSetNonModels() => this.NonModels != null && (this.NonModels.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
