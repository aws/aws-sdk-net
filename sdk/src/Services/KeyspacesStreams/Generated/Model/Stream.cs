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
    /// Represents a change data capture stream for an Amazon Keyspaces table, which enables
    /// tracking and processing of data changes.
    /// </summary>
    public partial class Stream
    {
        private string _keyspaceName;
        private string _streamArn;
        private string _streamLabel;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        /// The name of the keyspace containing the table associated with this stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string KeyspaceName
        {
            get { return this._keyspaceName; }
            set { this._keyspaceName = value; }
        }

        // Check to see if KeyspaceName property is set
        internal bool IsSetKeyspaceName()
        {
            return this._keyspaceName != null;
        }

        /// <summary>
        /// Gets and sets the property StreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies this stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=37, Max=1024)]
        public string StreamArn
        {
            get { return this._streamArn; }
            set { this._streamArn = value; }
        }

        // Check to see if StreamArn property is set
        internal bool IsSetStreamArn()
        {
            return this._streamArn != null;
        }

        /// <summary>
        /// Gets and sets the property StreamLabel. 
        /// <para>
        /// A unique identifier for this stream that can be used in stream operations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StreamLabel
        {
            get { return this._streamLabel; }
            set { this._streamLabel = value; }
        }

        // Check to see if StreamLabel property is set
        internal bool IsSetStreamLabel()
        {
            return this._streamLabel != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table associated with this stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}