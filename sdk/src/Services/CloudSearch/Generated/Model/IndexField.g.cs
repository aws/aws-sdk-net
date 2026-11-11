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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Configuration information for a field in the index, including its name, type, and
    /// options. The supported options depend on the <c><a>IndexFieldType</a></c>.
    /// </summary>
    public partial class IndexField
    {
        /// <summary>
        /// Gets and sets the property DateArrayOptions.
        /// </summary>
        public DateArrayOptions DateArrayOptions { get; set; }

        /// <summary>
        /// Checks to see if the DateArrayOptions property is set.
        /// </summary>
        internal bool IsSetDateArrayOptions() => this.DateArrayOptions != null;

        /// <summary>
        /// Gets and sets the property DateOptions.
        /// </summary>
        public DateOptions DateOptions { get; set; }

        /// <summary>
        /// Checks to see if the DateOptions property is set.
        /// </summary>
        internal bool IsSetDateOptions() => this.DateOptions != null;

        /// <summary>
        /// Gets and sets the property DoubleArrayOptions.
        /// </summary>
        public DoubleArrayOptions DoubleArrayOptions { get; set; }

        /// <summary>
        /// Checks to see if the DoubleArrayOptions property is set.
        /// </summary>
        internal bool IsSetDoubleArrayOptions() => this.DoubleArrayOptions != null;

        /// <summary>
        /// Gets and sets the property DoubleOptions.
        /// </summary>
        public DoubleOptions DoubleOptions { get; set; }

        /// <summary>
        /// Checks to see if the DoubleOptions property is set.
        /// </summary>
        internal bool IsSetDoubleOptions() => this.DoubleOptions != null;

        /// <summary>
        /// Gets and sets the property IndexFieldName. 
        /// <para>
        /// A string that represents the name of an index field. CloudSearch supports regular
        /// index fields as well as dynamic fields. A dynamic field's name defines a pattern that
        /// begins or ends with a wildcard. Any document fields that don't map to a regular index
        /// field but do match a dynamic field's pattern are configured with the dynamic field's
        /// indexing options. 
        /// </para>
        ///  
        /// <para>
        /// Regular field names begin with a letter and can contain the following characters:
        /// a-z (lowercase), 0-9, and _ (underscore). Dynamic field names must begin or end with
        /// a wildcard (*). The wildcard can also be the only character in a dynamic field name.
        /// Multiple wildcards, and wildcards embedded within a string are not supported. 
        /// </para>
        ///  
        /// <para>
        /// The name <c>score</c> is reserved and cannot be used as a field name. To reference
        /// a document's ID, you can use the name <c>_id</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string IndexFieldName { get; set; }

        /// <summary>
        /// Checks to see if the IndexFieldName property is set.
        /// </summary>
        internal bool IsSetIndexFieldName() => this.IndexFieldName != null;

        /// <summary>
        /// Gets and sets the property IndexFieldType.
        /// </summary>
        [AWSProperty(Required = true)]
        public IndexFieldType IndexFieldType { get; set; }

        /// <summary>
        /// Checks to see if the IndexFieldType property is set.
        /// </summary>
        internal bool IsSetIndexFieldType() => this.IndexFieldType != null;

        /// <summary>
        /// Gets and sets the property IntArrayOptions.
        /// </summary>
        public IntArrayOptions IntArrayOptions { get; set; }

        /// <summary>
        /// Checks to see if the IntArrayOptions property is set.
        /// </summary>
        internal bool IsSetIntArrayOptions() => this.IntArrayOptions != null;

        /// <summary>
        /// Gets and sets the property IntOptions.
        /// </summary>
        public IntOptions IntOptions { get; set; }

        /// <summary>
        /// Checks to see if the IntOptions property is set.
        /// </summary>
        internal bool IsSetIntOptions() => this.IntOptions != null;

        /// <summary>
        /// Gets and sets the property LatLonOptions.
        /// </summary>
        public LatLonOptions LatLonOptions { get; set; }

        /// <summary>
        /// Checks to see if the LatLonOptions property is set.
        /// </summary>
        internal bool IsSetLatLonOptions() => this.LatLonOptions != null;

        /// <summary>
        /// Gets and sets the property LiteralArrayOptions.
        /// </summary>
        public LiteralArrayOptions LiteralArrayOptions { get; set; }

        /// <summary>
        /// Checks to see if the LiteralArrayOptions property is set.
        /// </summary>
        internal bool IsSetLiteralArrayOptions() => this.LiteralArrayOptions != null;

        /// <summary>
        /// Gets and sets the property LiteralOptions.
        /// </summary>
        public LiteralOptions LiteralOptions { get; set; }

        /// <summary>
        /// Checks to see if the LiteralOptions property is set.
        /// </summary>
        internal bool IsSetLiteralOptions() => this.LiteralOptions != null;

        /// <summary>
        /// Gets and sets the property TextArrayOptions.
        /// </summary>
        public TextArrayOptions TextArrayOptions { get; set; }

        /// <summary>
        /// Checks to see if the TextArrayOptions property is set.
        /// </summary>
        internal bool IsSetTextArrayOptions() => this.TextArrayOptions != null;

        /// <summary>
        /// Gets and sets the property TextOptions.
        /// </summary>
        public TextOptions TextOptions { get; set; }

        /// <summary>
        /// Checks to see if the TextOptions property is set.
        /// </summary>
        internal bool IsSetTextOptions() => this.TextOptions != null;
    }
}
