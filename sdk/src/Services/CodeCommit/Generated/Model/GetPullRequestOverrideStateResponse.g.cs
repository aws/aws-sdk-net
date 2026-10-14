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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// This is the response object from the GetPullRequestOverrideState operation.
    /// </summary>
    public partial class GetPullRequestOverrideStateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Overridden. 
        /// <para>
        /// A Boolean value that indicates whether a pull request has had its rules set aside
        /// (TRUE) or whether all approval rules still apply (FALSE).
        /// </para>
        /// </summary>
        public bool? Overridden { get; set; }

        /// <summary>
        /// Checks to see if the Overridden property is set.
        /// </summary>
        internal bool IsSetOverridden() => this.Overridden.HasValue;

        /// <summary>
        /// Gets and sets the property Overrider. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user or identity that overrode the rules and
        /// their requirements for the pull request.
        /// </para>
        /// </summary>
        public string Overrider { get; set; }

        /// <summary>
        /// Checks to see if the Overrider property is set.
        /// </summary>
        internal bool IsSetOverrider() => this.Overrider != null;
    }
}
