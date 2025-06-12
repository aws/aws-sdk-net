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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private string _falseyCellValue;
        private List<string> _falseyCellValueSynonyms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _subTypeName;
        private string _truthyCellValue;
        private List<string> _truthyCellValueSynonyms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _typeName;
        private Dictionary<string, string> _typeParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property FalseyCellValue. 
        /// <para>
        /// The semantic type falsey cell value.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string FalseyCellValue
        {
            get { return this._falseyCellValue; }
            set { this._falseyCellValue = value; }
        }

        // Check to see if FalseyCellValue property is set
        internal bool IsSetFalseyCellValue()
        {
            return this._falseyCellValue != null;
        }

        /// <summary>
        /// Gets and sets the property FalseyCellValueSynonyms. 
        /// <para>
        /// The other names or aliases for the false cell value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FalseyCellValueSynonyms
        {
            get { return this._falseyCellValueSynonyms; }
            set { this._falseyCellValueSynonyms = value; }
        }

        // Check to see if FalseyCellValueSynonyms property is set
        internal bool IsSetFalseyCellValueSynonyms()
        {
            return this._falseyCellValueSynonyms != null && (this._falseyCellValueSynonyms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubTypeName. 
        /// <para>
        /// The semantic type sub type name.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string SubTypeName
        {
            get { return this._subTypeName; }
            set { this._subTypeName = value; }
        }

        // Check to see if SubTypeName property is set
        internal bool IsSetSubTypeName()
        {
            return this._subTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property TruthyCellValue. 
        /// <para>
        /// The semantic type truthy cell value.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string TruthyCellValue
        {
            get { return this._truthyCellValue; }
            set { this._truthyCellValue = value; }
        }

        // Check to see if TruthyCellValue property is set
        internal bool IsSetTruthyCellValue()
        {
            return this._truthyCellValue != null;
        }

        /// <summary>
        /// Gets and sets the property TruthyCellValueSynonyms. 
        /// <para>
        /// The other names or aliases for the true cell value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TruthyCellValueSynonyms
        {
            get { return this._truthyCellValueSynonyms; }
            set { this._truthyCellValueSynonyms = value; }
        }

        // Check to see if TruthyCellValueSynonyms property is set
        internal bool IsSetTruthyCellValueSynonyms()
        {
            return this._truthyCellValueSynonyms != null && (this._truthyCellValueSynonyms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The semantic type name.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

        /// <summary>
        /// Gets and sets the property TypeParameters. 
        /// <para>
        /// The semantic type parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> TypeParameters
        {
            get { return this._typeParameters; }
            set { this._typeParameters = value; }
        }

        // Check to see if TypeParameters property is set
        internal bool IsSetTypeParameters()
        {
            return this._typeParameters != null && (this._typeParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}