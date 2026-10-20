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

namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// Contains a value.
    /// </summary>
    public partial class Field
    {
        /// <summary>
        /// Gets and sets the property ArrayValue. 
        /// <para>
        /// An array of values.
        /// </para>
        /// </summary>
        public ArrayValue ArrayValue { get; set; }

        /// <summary>
        /// Checks to see if the ArrayValue property is set.
        /// </summary>
        internal bool IsSetArrayValue() => this.ArrayValue != null;

        /// <summary>
        /// Gets and sets the property BlobValue. 
        /// <para>
        /// A value of BLOB data type.
        /// </para>
        /// </summary>
        public MemoryStream BlobValue { get; set; }

        /// <summary>
        /// Checks to see if the BlobValue property is set.
        /// </summary>
        internal bool IsSetBlobValue() => this.BlobValue != null;

        /// <summary>
        /// Gets and sets the property BooleanValue. 
        /// <para>
        /// A value of Boolean data type.
        /// </para>
        /// </summary>
        public bool? BooleanValue { get; set; }

        /// <summary>
        /// Checks to see if the BooleanValue property is set.
        /// </summary>
        internal bool IsSetBooleanValue() => this.BooleanValue.HasValue;

        /// <summary>
        /// Gets and sets the property DoubleValue. 
        /// <para>
        /// A value of double data type.
        /// </para>
        /// </summary>
        public double? DoubleValue { get; set; }

        /// <summary>
        /// Checks to see if the DoubleValue property is set.
        /// </summary>
        internal bool IsSetDoubleValue() => this.DoubleValue.HasValue;

        /// <summary>
        /// Gets and sets the property IsNull. 
        /// <para>
        /// A NULL value.
        /// </para>
        /// </summary>
        public bool? IsNull { get; set; }

        /// <summary>
        /// Checks to see if the IsNull property is set.
        /// </summary>
        internal bool IsSetIsNull() => this.IsNull.HasValue;

        /// <summary>
        /// Gets and sets the property LongValue. 
        /// <para>
        /// A value of long data type.
        /// </para>
        /// </summary>
        public long? LongValue { get; set; }

        /// <summary>
        /// Checks to see if the LongValue property is set.
        /// </summary>
        internal bool IsSetLongValue() => this.LongValue.HasValue;

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// A value of string data type.
        /// </para>
        /// </summary>
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;
    }
}
