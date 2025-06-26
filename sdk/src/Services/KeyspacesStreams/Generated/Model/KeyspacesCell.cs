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
 * Do not modify this file. This file is generated from the keyspacesstreams-2024-09-09.normal.json service model.
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
        private KeyspacesMetadata _metadata;
        private KeyspacesCellValue _value;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata associated with this cell, such as time-to-live (TTL) expiration time and
        /// write timestamp.
        /// </para>
        /// </summary>
        public KeyspacesMetadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value stored in this cell, which can be of various data types supported by Amazon
        /// Keyspaces.
        /// </para>
        /// </summary>
        public KeyspacesCellValue Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}