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
    /// Contains metadata information associated with Amazon Keyspaces cells and rows.
    /// </summary>
    public partial class KeyspacesMetadata
    {
        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The time at which the associated data will expire, based on the time-to-live (TTL)
        /// setting.
        /// </para>
        /// </summary>
        public string ExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationTime property is set.
        /// </summary>
        internal bool IsSetExpirationTime() => this.ExpirationTime != null;

        /// <summary>
        /// Gets and sets the property WriteTime. 
        /// <para>
        /// The timestamp at which the associated data was written to the database.
        /// </para>
        /// </summary>
        public string WriteTime { get; set; }

        /// <summary>
        /// Checks to see if the WriteTime property is set.
        /// </summary>
        internal bool IsSetWriteTime() => this.WriteTime != null;
    }
}
