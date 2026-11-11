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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The pool-wide token session settings for a user pool.
    /// </summary>
    public partial class UserPoolTokenSessionConfigType
    {
        /// <summary>
        /// Gets and sets the property MaxPerUser. 
        /// <para>
        /// The maximum number of active token sessions that a user can have across the user pool.
        /// The minimum value is <c>1</c> and the maximum value is <c>100</c>. The default is
        /// <c>20</c>. When a user reaches this limit, the next successful authentication automatically
        /// evicts that user's least recently used token session before it creates the new session.
        /// Lowering this value doesn't evict existing sessions on its own; the user is brought
        /// back within the limit on their next sign-in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public int? MaxPerUser { get; set; }

        /// <summary>
        /// Checks to see if the MaxPerUser property is set.
        /// </summary>
        internal bool IsSetMaxPerUser() => this.MaxPerUser.HasValue;
    }
}
