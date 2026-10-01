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

namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// The primary key for a KSDS data set.
    /// </summary>
    public partial class PrimaryKey
    {
        /// <summary>
        /// Gets and sets the property Length. 
        /// <para>
        /// A strictly positive integer value representing the length of the primary key. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Length { get; set; }

        /// <summary>
        /// Checks to see if the Length property is set.
        /// </summary>
        internal bool IsSetLength() => this.Length.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the Primary Key.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Offset. 
        /// <para>
        /// A positive integer value representing the offset to mark the start of the primary
        /// key in the record byte array.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Offset { get; set; }

        /// <summary>
        /// Checks to see if the Offset property is set.
        /// </summary>
        internal bool IsSetOffset() => this.Offset.HasValue;
    }
}
