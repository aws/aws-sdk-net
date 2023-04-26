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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the ListWorkflowExecutions operation.
    /// Returns a list of workflow runtime instance metadata objects for a specific image
    /// build version.
    /// </summary>
    public partial class ListWorkflowExecutionsRequest : AmazonImagebuilderRequest
    {
        private string _imageBuildVersionArn;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ImageBuildVersionArn. 
        /// <para>
        /// List all workflow runtime instances for the specified image build version resource
        /// ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImageBuildVersionArn
        {
            get { return this._imageBuildVersionArn; }
            set { this._imageBuildVersionArn = value; }
        }

        // Check to see if ImageBuildVersionArn property is set
        internal bool IsSetImageBuildVersionArn()
        {
            return this._imageBuildVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum items to return in a request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to specify where to start paginating. This is the NextToken from a previously
        /// truncated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
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

    }
}