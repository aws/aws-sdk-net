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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// This is the response object from the ListTrails operation.
    /// </summary>
    public partial class ListTrailsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TrailInfo> _trails = AWSConfigs.InitializeCollections ? new List<TrailInfo>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to get the next page of results after a previous API call. If the
        /// token does not appear, there are no more results to return. The token must be passed
        /// in with the same parameters as the previous call. For example, if the original call
        /// specified an AttributeKey of 'Username' with a value of 'root', the call with NextToken
        /// should include those same parameters.
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
        /// Gets and sets the property Trails. 
        /// <para>
        /// Returns the name, ARN, and home Region of trails in the current account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TrailInfo> Trails
        {
            get { return this._trails; }
            set { this._trails = value; }
        }

        // Check to see if Trails property is set
        internal bool IsSetTrails()
        {
            return this._trails != null && (this._trails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}