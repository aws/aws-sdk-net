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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a context entry that was added to or removed from a context store.
    /// </summary>
    public partial class ContextChange
    {
        /// <summary>
        /// Gets and sets the property ChangeType. 
        /// <para>
        /// The type of change. The possible values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ADDED</c>: The context entry was added to the context store.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REMOVED</c>: The context entry was removed from the context store.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ContextChangeType ChangeType { get; set; }

        /// <summary>
        /// Checks to see if the ChangeType property is set.
        /// </summary>
        internal bool IsSetChangeType() => this.ChangeType != null;

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// The context entry that was added or removed.
        /// </para>
        /// </summary>
        public ContextEntry Context { get; set; }

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null;
    }
}
