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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Object that holds the results for membership.
    /// </summary>
    public partial class ProfileQueryResult
    {
        private Profile _profile;
        private string _profileId;
        private QueryResult _queryResult;

        /// <summary>
        /// Gets and sets the property Profile.
        /// </summary>
        public Profile Profile
        {
            get { return this._profile; }
            set { this._profile = value; }
        }

        // Check to see if Profile property is set
        internal bool IsSetProfile()
        {
            return this._profile != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The profile id the result belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property QueryResult. 
        /// <para>
        /// Describes whether the profile was absent or present in the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueryResult QueryResult
        {
            get { return this._queryResult; }
            set { this._queryResult = value; }
        }

        // Check to see if QueryResult property is set
        internal bool IsSetQueryResult()
        {
            return this._queryResult != null;
        }

    }
}