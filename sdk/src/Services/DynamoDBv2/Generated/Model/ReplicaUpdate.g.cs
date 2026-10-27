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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents one of the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// A new replica to be added to an existing global table.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// New parameters for an existing replica.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An existing replica to be removed from an existing global table.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ReplicaUpdate
    {
        /// <summary>
        /// Gets and sets the property Create. 
        /// <para>
        /// The parameters required for creating a replica on an existing global table.
        /// </para>
        /// </summary>
        public CreateReplicaAction Create { get; set; }

        /// <summary>
        /// Checks to see if the Create property is set.
        /// </summary>
        internal bool IsSetCreate() => this.Create != null;

        /// <summary>
        /// Gets and sets the property Delete. 
        /// <para>
        /// The name of the existing replica to be removed.
        /// </para>
        /// </summary>
        public DeleteReplicaAction Delete { get; set; }

        /// <summary>
        /// Checks to see if the Delete property is set.
        /// </summary>
        internal bool IsSetDelete() => this.Delete != null;
    }
}
