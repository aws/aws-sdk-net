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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// This is the response object from the DescribeHybridADUpdate operation.
    /// </summary>
    public partial class DescribeHybridADUpdateResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private HybridUpdateActivities _updateActivities;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If not null, more results are available. Pass this value for the <c>NextToken</c>
        /// parameter in a subsequent request to retrieve the next set of items.
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
        /// Gets and sets the property UpdateActivities. 
        /// <para>
        /// Information about update activities for the hybrid directory, organized by update
        /// type.
        /// </para>
        /// </summary>
        public HybridUpdateActivities UpdateActivities
        {
            get { return this._updateActivities; }
            set { this._updateActivities = value; }
        }

        // Check to see if UpdateActivities property is set
        internal bool IsSetUpdateActivities()
        {
            return this._updateActivities != null;
        }

    }
}