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

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Container for the parameters to the LookupPolicy operation. Lists all policies from
    /// the root of the <a>Directory</a> to the object specified. If there are no policies
    /// present, an empty list is returned. If policies are present, and if some objects don't
    /// have the policies attached, it returns the <c>ObjectIdentifier</c> for such objects.
    /// If policies are present, it returns <c>ObjectIdentifier</c>, <c>policyId</c>, and
    /// <c>policyType</c>. Paths that don't lead to the root from the target object are ignored.
    /// For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/key_concepts_directory.html#key_concepts_policies">Policies</a>.
    /// </summary>
    public partial class LookupPolicyRequest : AmazonCloudDirectoryRequest
    {
        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the <a>Directory</a>. For more
        /// information, see <a>arns</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectoryArn { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryArn property is set.
        /// </summary>
        internal bool IsSetDirectoryArn() => this.DirectoryArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to be retrieved in a single call. This is an approximate
        /// number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to request the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ObjectReference. 
        /// <para>
        /// Reference that identifies the object whose policies will be looked up.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ObjectReference ObjectReference { get; set; }

        /// <summary>
        /// Checks to see if the ObjectReference property is set.
        /// </summary>
        internal bool IsSetObjectReference() => this.ObjectReference != null;
    }
}
