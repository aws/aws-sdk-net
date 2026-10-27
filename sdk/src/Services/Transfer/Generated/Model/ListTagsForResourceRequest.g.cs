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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForResource operation. Lists all of the
    /// tags associated with the Amazon Resource Name (ARN) that you specify. The resource
    /// can be a user, server, or role.
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonTransferRequest
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Requests the tags associated with a particular Amazon Resource Name (ARN). An ARN
        /// is an identifier for a specific Amazon Web Services resource, such as a server, user,
        /// or role.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1600)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the number of tags to return as a response to the <c>ListTagsForResource</c>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When you request additional results from the <c>ListTagsForResource</c> operation,
        /// a <c>NextToken</c> parameter is returned in the input. You can then pass in a subsequent
        /// command to the <c>NextToken</c> parameter to continue listing additional tags.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 6144)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
