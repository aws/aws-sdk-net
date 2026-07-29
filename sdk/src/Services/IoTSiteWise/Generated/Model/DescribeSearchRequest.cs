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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSearch operation.
    /// Returns the current status and metadata of a single search, including the query that
    /// was submitted, the search type, and — when the search has failed — the reason. Use
    /// this to poll a search started with <c>StartSearch</c> until it reaches a terminal
    /// status (<c>SUCCEEDED</c> or <c>FAILED</c>).
    /// </summary>
    public partial class DescribeSearchRequest : AmazonIoTSiteWiseRequest
    {
        private string _searchId;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property SearchId. 
        /// <para>
        /// The identifier of the search to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=23, Max=36)]
        public string SearchId
        {
            get { return this._searchId; }
            set { this._searchId = value; }
        }

        // Check to see if SearchId property is set
        internal bool IsSetSearchId()
        {
            return this._searchId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace the search belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

    }
}