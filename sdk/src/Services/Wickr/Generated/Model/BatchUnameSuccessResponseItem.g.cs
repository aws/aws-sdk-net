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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Contains information about a username hash that was successfully resolved in a batch
    /// uname lookup operation.
    /// </summary>
    public partial class BatchUnameSuccessResponseItem
    {
        /// <summary>
        /// Gets and sets the property Uname. 
        /// <para>
        /// The username hash that was successfully resolved.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Uname { get; set; }

        /// <summary>
        /// Checks to see if the Uname property is set.
        /// </summary>
        internal bool IsSetUname() => this.Uname != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The email address or username corresponding to the username hash.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
