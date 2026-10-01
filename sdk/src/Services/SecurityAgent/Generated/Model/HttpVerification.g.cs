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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Contains HTTP route verification details for a target domain, including the route
    /// path and token to serve for domain ownership verification.
    /// </summary>
    public partial class HttpVerification
    {
        /// <summary>
        /// Gets and sets the property RoutePath. 
        /// <para>
        /// The HTTP route path where the verification token must be served.
        /// </para>
        /// </summary>
        public string RoutePath { get; set; }

        /// <summary>
        /// Checks to see if the RoutePath property is set.
        /// </summary>
        internal bool IsSetRoutePath() => this.RoutePath != null;

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The verification token to serve at the specified route path.
        /// </para>
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Checks to see if the Token property is set.
        /// </summary>
        internal bool IsSetToken() => this.Token != null;
    }
}
