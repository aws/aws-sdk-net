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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
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
namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Contains details about a schema field in the V2 format. This field format supports
    /// nested and complex data types such as <c>struct</c>, <c>list</c>, and <c>map</c>,
    /// in addition to primitive types.
    /// </summary>
    public partial class SchemaV2Field
    {
        private string _doc;
        private int? _id;
        private string _name;
        private bool? _required;
        private Amazon.Runtime.Documents.Document _type;

        /// <summary>
        /// Gets and sets the property Doc. 
        /// <para>
        /// An optional description of the field.
        /// </para>
        /// </summary>
        public string Doc
        {
            get { return this._doc; }
            set { this._doc = value; }
        }

        // Check to see if Doc property is set
        internal bool IsSetDoc()
        {
            return this._doc != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the schema field. Field IDs are used by Apache Iceberg to
        /// track schema evolution and maintain compatibility across schema changes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Required. 
        /// <para>
        /// A Boolean value that specifies whether values are required for each row in this field.
        /// If this is <c>true</c>, the field does not allow null values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Required
        {
            get { return this._required; }
            set { this._required = value; }
        }

        // Check to see if Required property is set
        internal bool IsSetRequired()
        {
            return this._required.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data type of the field. This can be a primitive type string such as <c>boolean</c>,
        /// <c>int</c>, <c>long</c>, <c>float</c>, <c>double</c>, <c>string</c>, <c>binary</c>,
        /// <c>date</c>, <c>timestamp</c>, or <c>timestamptz</c>, or a complex type represented
        /// as a JSON object for nested types such as <c>struct</c>, <c>list</c>, or <c>map</c>.
        /// For more information, see the <a href="https://iceberg.apache.org/spec/#schemas-and-data-types">Apache
        /// Iceberg schemas and data types documentation</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amazon.Runtime.Documents.Document Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return !this._type.IsNull();
        }

    }
}