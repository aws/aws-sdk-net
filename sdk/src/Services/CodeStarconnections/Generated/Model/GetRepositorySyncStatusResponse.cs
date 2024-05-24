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
 * Do not modify this file. This file is generated from the codestar-connections-2019-12-01.normal.json service model.
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
namespace Amazon.CodeStarconnections.Model
{
    /// <summary>
    /// This is the response object from the GetRepositorySyncStatus operation.
    /// </summary>
    public partial class GetRepositorySyncStatusResponse : AmazonWebServiceResponse
    {
        private RepositorySyncAttempt _latestSync;

        /// <summary>
        /// Gets and sets the property LatestSync. 
        /// <para>
        /// The status of the latest sync returned for a specified repository and branch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RepositorySyncAttempt LatestSync
        {
            get { return this._latestSync; }
            set { this._latestSync = value; }
        }

        // Check to see if LatestSync property is set
        internal bool IsSetLatestSync()
        {
            return this._latestSync != null;
        }

    }
}