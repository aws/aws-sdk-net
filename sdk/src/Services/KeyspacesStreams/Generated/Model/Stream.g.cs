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
    /// Represents a change data capture stream for an Amazon Keyspaces table, which enables
    /// tracking and processing of data changes.
    /// </summary>
    public partial class Stream
    {
        /// <summary>
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        /// The name of the keyspace containing the table associated with this stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string KeyspaceName { get; set; }

        /// <summary>
        /// Checks to see if the KeyspaceName property is set.
        /// </summary>
        internal bool IsSetKeyspaceName() => this.KeyspaceName != null;

        /// <summary>
        /// Gets and sets the property StreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies this stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 37, Max = 1024)]
        public string StreamArn { get; set; }

        /// <summary>
        /// Checks to see if the StreamArn property is set.
        /// </summary>
        internal bool IsSetStreamArn() => this.StreamArn != null;

        /// <summary>
        /// Gets and sets the property StreamLabel. 
        /// <para>
        /// A unique identifier for this stream that can be used in stream operations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StreamLabel { get; set; }

        /// <summary>
        /// Checks to see if the StreamLabel property is set.
        /// </summary>
        internal bool IsSetStreamLabel() => this.StreamLabel != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table associated with this stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;
    }
}
