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
 * Do not modify this file. This file is generated from the route53profiles-2018-05-10.normal.json service model.
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
namespace Amazon.Route53Profiles.Model
{
    /// <summary>
    /// Container for the parameters to the ListProfileResourceAssociations operation.
    /// Lists all the resource associations for the specified Route 53 Profile.
    /// </summary>
    public partial class ListProfileResourceAssociationsRequest : AmazonRoute53ProfilesRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _profileId;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of objects that you want to return for this request. If more objects
        /// are available, in the response, a <c>NextToken</c> value, which you can use in a subsequent
        /// call to get the next batch of objects, is provided.
        /// </para>
        ///  
        /// <para>
        ///  If you don't specify a value for <c>MaxResults</c>, up to 100 objects are returned.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        ///  For the first call to this list request, omit this value. 
        /// </para>
        ///  
        /// <para>
        /// When you request a list of objects, at most the number of objects specified by <c>MaxResults</c>
        /// is returned. If more objects are available for retrieval, a <c>NextToken</c> value
        /// is returned in the response. To retrieve the next batch of objects, use the token
        /// that was returned for the prior request in your next request.
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
        /// Gets and sets the property ProfileId. 
        /// <para>
        ///  The ID of the Profile. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        ///  ID of a resource if you want information on only one type. 
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}