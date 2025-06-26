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
    /// Represents a key-value pair within a map data type in Amazon Keyspaces, including
    /// the associated metadata.
    /// </summary>
    public partial class KeyspacesCellMapDefinition
    {
        private KeyspacesCellValue _key;
        private KeyspacesMetadata _metadata;
        private KeyspacesCellValue _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key of this map entry in the Amazon Keyspaces cell.
        /// </para>
        /// </summary>
        public KeyspacesCellValue Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata for this specific key-value pair within the map, such as timestamps and TTL
        /// information.
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
        /// The value associated with the key in this map entry.
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