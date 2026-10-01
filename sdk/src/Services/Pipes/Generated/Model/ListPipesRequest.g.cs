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

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// Container for the parameters to the ListPipes operation. Get the pipes associated
    /// with this account. For more information about pipes, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes.html">Amazon
    /// EventBridge Pipes</a> in the Amazon EventBridge User Guide.
    /// </summary>
    public partial class ListPipesRequest : AmazonPipesRequest
    {
        /// <summary>
        /// Gets and sets the property CurrentState. 
        /// <para>
        /// The state the pipe is in.
        /// </para>
        /// </summary>
        public PipeState CurrentState { get; set; }

        /// <summary>
        /// Checks to see if the CurrentState property is set.
        /// </summary>
        internal bool IsSetCurrentState() => this.CurrentState != null;

        /// <summary>
        /// Gets and sets the property DesiredState. 
        /// <para>
        /// The state the pipe should be in.
        /// </para>
        /// </summary>
        public RequestedPipeState DesiredState { get; set; }

        /// <summary>
        /// Checks to see if the DesiredState property is set.
        /// </summary>
        internal bool IsSetDesiredState() => this.DesiredState != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of pipes to include in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NamePrefix. 
        /// <para>
        /// A value that will return a subset of the pipes associated with this account. For example,
        /// <c>"NamePrefix": "ABC"</c> will return all endpoints with "ABC" in the name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string NamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the NamePrefix property is set.
        /// </summary>
        internal bool IsSetNamePrefix() => this.NamePrefix != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If <c>nextToken</c> is returned, there are more results available. The value of <c>nextToken</c>
        /// is a unique pagination token for each page. Make the call again using the returned
        /// token to retrieve the next page. Keep all other arguments unchanged. Each pagination
        /// token expires after 24 hours. Using an expired pagination token will return an HTTP
        /// 400 InvalidToken error.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SourcePrefix. 
        /// <para>
        /// The prefix matching the pipe source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string SourcePrefix { get; set; }

        /// <summary>
        /// Checks to see if the SourcePrefix property is set.
        /// </summary>
        internal bool IsSetSourcePrefix() => this.SourcePrefix != null;

        /// <summary>
        /// Gets and sets the property TargetPrefix. 
        /// <para>
        /// The prefix matching the pipe target.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string TargetPrefix { get; set; }

        /// <summary>
        /// Checks to see if the TargetPrefix property is set.
        /// </summary>
        internal bool IsSetTargetPrefix() => this.TargetPrefix != null;
    }
}
