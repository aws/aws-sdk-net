/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// This is the response object from the ListPlatformVersions operation.
    /// </summary>
    public partial class ListPlatformVersionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PlatformSummary> _platformSummaryList = new List<PlatformSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The starting index into the remaining list of platforms. if this value is not <code>null</code>,
        /// you can use it in a subsequent <code>ListPlatformVersion</code> call. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PlatformSummaryList. 
        /// <para>
        /// Detailed information about the platforms.
        /// </para>
        /// </summary>
        public List<PlatformSummary> PlatformSummaryList
        {
            get { return this._platformSummaryList; }
            set { this._platformSummaryList = value; }
        }

        // Check to see if PlatformSummaryList property is set
        internal bool IsSetPlatformSummaryList()
        {
            return this._platformSummaryList != null && this._platformSummaryList.Count > 0; 
        }

    }
}