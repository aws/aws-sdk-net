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
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Kind. 
        /// <para>
        /// Specifies the classification of data. For example, this could be set to values like
        /// <code>Scalar</code> or <code>NonNull</code> to indicate a fundamental property of
        /// the field.
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Scalar</code>: Indicates the value is a primitive type (scalar).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NonNull</code>: Indicates the field cannot be <code>null</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>List</code>: Indicates the field contains a list.
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
        /// The name of the data type that represents the field. For example, <code>String</code>
        /// is a valid <code>name</code> value.
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
        /// The <code>DataSourceIntrospectionModelFieldType</code> object data. The <code>type</code>
        /// is only present if <code>DataSourceIntrospectionModelFieldType.kind</code> is set
        /// to <code>NonNull</code> or <code>List</code>. 
        /// </para>
        ///  
        /// <para>
        /// The <code>type</code> typically contains its own <code>kind</code> and <code>name</code>
        /// fields to represent the actual type data. For instance, <code>type</code> could contain
        /// a <code>kind</code> value of <code>Scalar</code> with a <code>name</code> value of
        /// <code>String</code>. The values <code>Scalar</code> and <code>String</code> will be
        /// collectively stored in the <code>values</code> field.
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
        /// The values of the <code>type</code> field. This field represents the AppSync data
        /// type equivalent of the introspected field.
        /// </para>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}