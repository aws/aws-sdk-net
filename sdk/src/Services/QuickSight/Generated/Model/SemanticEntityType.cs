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
    /// A structure that represents a semantic entity type.
    /// </summary>
    public partial class SemanticEntityType
    {
        private string _subTypeName;
        private string _typeName;
        private Dictionary<string, string> _typeParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property SubTypeName. 
        /// <para>
        /// The semantic entity sub type name.
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
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The semantic entity type name.
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
        /// The semantic entity type parameters.
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