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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAppBlockBuilderAppBlockAssociations operation.
    /// Retrieves a list that describes one or more app block builder associations.
    /// </summary>
    public partial class DescribeAppBlockBuilderAppBlockAssociationsRequest : AmazonAppStreamRequest
    {
        /// <summary>
        /// Gets and sets the property AppBlockArn. 
        /// <para>
        /// The ARN of the app block.
        /// </para>
        /// </summary>
        public string AppBlockArn { get; set; }

        /// <summary>
        /// Checks to see if the AppBlockArn property is set.
        /// </summary>
        internal bool IsSetAppBlockArn() => this.AppBlockArn != null;

        /// <summary>
        /// Gets and sets the property AppBlockBuilderName. 
        /// <para>
        /// The name of the app block builder.
        /// </para>
        /// </summary>
        public string AppBlockBuilderName { get; set; }

        /// <summary>
        /// Checks to see if the AppBlockBuilderName property is set.
        /// </summary>
        internal bool IsSetAppBlockBuilderName() => this.AppBlockBuilderName != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum size of each page of results.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token used to retrieve the next page of results for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
