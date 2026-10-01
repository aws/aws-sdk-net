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
    /// Container for the parameters to the ListObjectPolicies operation. Returns policies
    /// attached to an object in pagination fashion.
    /// </summary>
    public partial class ListObjectPoliciesRequest : AmazonCloudDirectoryRequest
    {
        /// <summary>
        /// Gets and sets the property ConsistencyLevel. 
        /// <para>
        /// Represents the manner and timing in which the successful write or update of an object
        /// is reflected in a subsequent read operation of that same object.
        /// </para>
        /// </summary>
        public ConsistencyLevel ConsistencyLevel { get; set; }

        /// <summary>
        /// Checks to see if the ConsistencyLevel property is set.
        /// </summary>
        internal bool IsSetConsistencyLevel() => this.ConsistencyLevel != null;

        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the <a>Directory</a> where
        /// objects reside. For more information, see <a>arns</a>.
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
        /// The pagination token.
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
        /// Reference that identifies the object for which policies will be listed.
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
