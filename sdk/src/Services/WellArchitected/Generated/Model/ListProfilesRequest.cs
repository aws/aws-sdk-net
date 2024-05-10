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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the ListProfiles operation.
    /// List profiles.
    /// </summary>
    public partial class ListProfilesRequest : AmazonWellArchitectedRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _profileNamePrefix;
        private ProfileOwnerType _profileOwnerType;

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property ProfileNamePrefix. 
        /// <para>
        /// An optional string added to the beginning of each profile name returned in the results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public string ProfileNamePrefix
        {
            get { return this._profileNamePrefix; }
            set { this._profileNamePrefix = value; }
        }

        // Check to see if ProfileNamePrefix property is set
        internal bool IsSetProfileNamePrefix()
        {
            return this._profileNamePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileOwnerType. 
        /// <para>
        /// Profile owner type.
        /// </para>
        /// </summary>
        public ProfileOwnerType ProfileOwnerType
        {
            get { return this._profileOwnerType; }
            set { this._profileOwnerType = value; }
        }

        // Check to see if ProfileOwnerType property is set
        internal bool IsSetProfileOwnerType()
        {
            return this._profileOwnerType != null;
        }

    }
}