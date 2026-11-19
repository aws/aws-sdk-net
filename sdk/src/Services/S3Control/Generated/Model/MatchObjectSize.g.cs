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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A filter condition that specifies the object size range of included objects in bytes.
    /// Only integers are supported.
    /// </summary>
    public partial class MatchObjectSize
    {
        /// <summary>
        /// Gets and sets the property BytesGreaterThan. 
        /// <para>
        ///  Specifies the minimum object size in Bytes. The value must be a positive number,
        /// greater than 0 and less than 50 TB. 
        /// </para>
        /// </summary>
        public long? BytesGreaterThan { get; set; }

        /// <summary>
        /// Checks to see if the BytesGreaterThan property is set.
        /// </summary>
        internal bool IsSetBytesGreaterThan() => this.BytesGreaterThan.HasValue;

        /// <summary>
        /// Gets and sets the property BytesLessThan. 
        /// <para>
        ///  Specifies the maximum object size in Bytes. The value must be a positive number,
        /// greater than the minimum object size and less than 50 TB. 
        /// </para>
        /// </summary>
        public long? BytesLessThan { get; set; }

        /// <summary>
        /// Checks to see if the BytesLessThan property is set.
        /// </summary>
        internal bool IsSetBytesLessThan() => this.BytesLessThan.HasValue;
    }
}
