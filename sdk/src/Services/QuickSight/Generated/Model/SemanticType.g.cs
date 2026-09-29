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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that represents a semantic type.
    /// </summary>
    public partial class SemanticType
    {
        /// <summary>
        /// Gets and sets the property FalseyCellValue. 
        /// <para>
        /// The semantic type falsey cell value.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string FalseyCellValue { get; set; }

        /// <summary>
        /// Checks to see if the FalseyCellValue property is set.
        /// </summary>
        internal bool IsSetFalseyCellValue() => this.FalseyCellValue != null;

        /// <summary>
        /// Gets and sets the property FalseyCellValueSynonyms. 
        /// <para>
        /// The other names or aliases for the false cell value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FalseyCellValueSynonyms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FalseyCellValueSynonyms property is set.
        /// </summary>
        internal bool IsSetFalseyCellValueSynonyms() => this.FalseyCellValueSynonyms != null && (this.FalseyCellValueSynonyms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubTypeName. 
        /// <para>
        /// The semantic type sub type name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SubTypeName { get; set; }

        /// <summary>
        /// Checks to see if the SubTypeName property is set.
        /// </summary>
        internal bool IsSetSubTypeName() => this.SubTypeName != null;

        /// <summary>
        /// Gets and sets the property TruthyCellValue. 
        /// <para>
        /// The semantic type truthy cell value.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string TruthyCellValue { get; set; }

        /// <summary>
        /// Checks to see if the TruthyCellValue property is set.
        /// </summary>
        internal bool IsSetTruthyCellValue() => this.TruthyCellValue != null;

        /// <summary>
        /// Gets and sets the property TruthyCellValueSynonyms. 
        /// <para>
        /// The other names or aliases for the true cell value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TruthyCellValueSynonyms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TruthyCellValueSynonyms property is set.
        /// </summary>
        internal bool IsSetTruthyCellValueSynonyms() => this.TruthyCellValueSynonyms != null && (this.TruthyCellValueSynonyms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The semantic type name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;

        /// <summary>
        /// Gets and sets the property TypeParameters. 
        /// <para>
        /// The semantic type parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> TypeParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the TypeParameters property is set.
        /// </summary>
        internal bool IsSetTypeParameters() => this.TypeParameters != null && (this.TypeParameters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
