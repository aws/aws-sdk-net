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

namespace Amazon.KeyspacesStreams.Model
{
    /// <summary>
    /// Represents a cell in an Amazon Keyspaces table, containing both the value and metadata
    /// about the cell.
    /// </summary>
    public partial class KeyspacesCell
    {
        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata associated with this cell, such as time-to-live (TTL) expiration time and
        /// write timestamp.
        /// </para>
        /// </summary>
        public KeyspacesMetadata Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value stored in this cell, which can be of various data types supported by Amazon
        /// Keyspaces.
        /// </para>
        /// </summary>
        public KeyspacesCellValue Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
