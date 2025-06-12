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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Represents the type data for each field retrieved from the introspection.
    /// </summary>
    public partial class DataSourceIntrospectionModelFieldType
    {
        private string _kind;
        private string _name;
        private DataSourceIntrospectionModelFieldType _type;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Kind. 
        /// <para>
        /// Specifies the classification of data. For example, this could be set to values like
        /// <c>Scalar</c> or <c>NonNull</c> to indicate a fundamental property of the field.
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Scalar</c>: Indicates the value is a primitive type (scalar).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NonNull</c>: Indicates the field cannot be <c>null</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>List</c>: Indicates the field contains a list.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Kind
        {
            get { return this._kind; }
            set { this._kind = value; }
        }

        // Check to see if Kind property is set
        internal bool IsSetKind()
        {
            return this._kind != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data type that represents the field. For example, <c>String</c> is
        /// a valid <c>name</c> value.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The <c>DataSourceIntrospectionModelFieldType</c> object data. The <c>type</c> is only
        /// present if <c>DataSourceIntrospectionModelFieldType.kind</c> is set to <c>NonNull</c>
        /// or <c>List</c>. 
        /// </para>
        ///  
        /// <para>
        /// The <c>type</c> typically contains its own <c>kind</c> and <c>name</c> fields to represent
        /// the actual type data. For instance, <c>type</c> could contain a <c>kind</c> value
        /// of <c>Scalar</c> with a <c>name</c> value of <c>String</c>. The values <c>Scalar</c>
        /// and <c>String</c> will be collectively stored in the <c>values</c> field.
        /// </para>
        /// </summary>
        public DataSourceIntrospectionModelFieldType Type
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
        /// Gets and sets the property Values. 
        /// <para>
        /// The values of the <c>type</c> field. This field represents the AppSync data type equivalent
        /// of the introspected field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}