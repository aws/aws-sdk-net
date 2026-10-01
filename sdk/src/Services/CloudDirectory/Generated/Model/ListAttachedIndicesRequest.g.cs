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
    /// Container for the parameters to the ListAttachedIndices operation. Lists indices attached
    /// to the specified object.
    /// </summary>
    public partial class ListAttachedIndicesRequest : AmazonCloudDirectoryRequest
    {
        /// <summary>
        /// Gets and sets the property ConsistencyLevel. 
        /// <para>
        /// The consistency level to use for this operation.
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
        /// The ARN of the directory.
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
        /// The maximum number of results to retrieve.
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
        /// Gets and sets the property TargetReference. 
        /// <para>
        /// A reference to the object that has indices attached.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ObjectReference TargetReference { get; set; }

        /// <summary>
        /// Checks to see if the TargetReference property is set.
        /// </summary>
        internal bool IsSetTargetReference() => this.TargetReference != null;
    }
}
