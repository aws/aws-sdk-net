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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <code>DescribeUserProfiles</code> request.
    /// </summary>
    public partial class DescribeUserProfilesResult
    {
        private List<UserProfile> _userProfiles = new List<UserProfile>();


        /// <summary>
        /// Gets and sets the property UserProfiles. 
        /// <para>
        /// A <code>Users</code> object that describes the specified users.
        /// </para>
        /// </summary>
        public List<UserProfile> UserProfiles
        {
            get { return this._userProfiles; }
            set { this._userProfiles = value; }
        }

        /// <summary>
        /// Sets the UserProfiles property
        /// </summary>
        /// <param name="userProfiles">The values to add to the UserProfiles collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeUserProfilesResult WithUserProfiles(params UserProfile[] userProfiles)
        {
            foreach (var element in userProfiles)
            {
                this._userProfiles.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the UserProfiles property
        /// </summary>
        /// <param name="userProfiles">The values to add to the UserProfiles collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeUserProfilesResult WithUserProfiles(IEnumerable<UserProfile> userProfiles)
        {
            foreach (var element in userProfiles)
            {
                this._userProfiles.Add(element);
            }
            return this;
        }
        // Check to see if UserProfiles property is set
        internal bool IsSetUserProfiles()
        {
            return this._userProfiles != null && this._userProfiles.Count > 0; 
        }

    }
}