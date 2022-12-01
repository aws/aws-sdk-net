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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// Container for the parameters to the ListPipes operation.
    /// Get the pipes associated with this account. For more information about pipes, see
    /// <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes.html">Amazon
    /// EventBridge Pipes</a> in the Amazon EventBridge User Guide.
    /// </summary>
    public partial class ListPipesRequest : AmazonPipesRequest
    {
        private PipeState _currentState;
        private RequestedPipeState _desiredState;
        private int? _limit;
        private string _namePrefix;
        private string _nextToken;
        private string _sourcePrefix;
        private string _targetPrefix;

        /// <summary>
        /// Gets and sets the property CurrentState. 
        /// <para>
        /// The state the pipe is in.
        /// </para>
        /// </summary>
        public PipeState CurrentState
        {
            get { return this._currentState; }
            set { this._currentState = value; }
        }

        // Check to see if CurrentState property is set
        internal bool IsSetCurrentState()
        {
            return this._currentState != null;
        }

        /// <summary>
        /// Gets and sets the property DesiredState. 
        /// <para>
        /// The state the pipe should be in.
        /// </para>
        /// </summary>
        public RequestedPipeState DesiredState
        {
            get { return this._desiredState; }
            set { this._desiredState = value; }
        }

        // Check to see if DesiredState property is set
        internal bool IsSetDesiredState()
        {
            return this._desiredState != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of pipes to include in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NamePrefix. 
        /// <para>
        /// A value that will return a subset of the pipes associated with this account. For example,
        /// <code>"NamePrefix": "ABC"</code> will return all endpoints with "ABC" in the name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string NamePrefix
        {
            get { return this._namePrefix; }
            set { this._namePrefix = value; }
        }

        // Check to see if NamePrefix property is set
        internal bool IsSetNamePrefix()
        {
            return this._namePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If <code>nextToken</code> is returned, there are more results available. The value
        /// of <code>nextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged. Each pagination token expires after 24 hours. Using an expired pagination
        /// token will return an HTTP 400 InvalidToken error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePrefix. 
        /// <para>
        /// The prefix matching the pipe source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string SourcePrefix
        {
            get { return this._sourcePrefix; }
            set { this._sourcePrefix = value; }
        }

        // Check to see if SourcePrefix property is set
        internal bool IsSetSourcePrefix()
        {
            return this._sourcePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property TargetPrefix. 
        /// <para>
        /// The prefix matching the pipe target.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string TargetPrefix
        {
            get { return this._targetPrefix; }
            set { this._targetPrefix = value; }
        }

        // Check to see if TargetPrefix property is set
        internal bool IsSetTargetPrefix()
        {
            return this._targetPrefix != null;
        }

    }
}