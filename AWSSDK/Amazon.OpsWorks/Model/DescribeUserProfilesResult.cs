/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Contains the response to a <c>DescribeUserProfiles</c> request.</para>
    /// </summary>
    public class DescribeUserProfilesResult
    {
        
        private List<UserProfile> userProfiles = new List<UserProfile>();

        /// <summary>
        /// A <c>Users</c> object that describes the specified users.
        ///  
        /// </summary>
        public List<UserProfile> UserProfiles
        {
            get { return this.userProfiles; }
            set { this.userProfiles = value; }
        }
        /// <summary>
        /// Adds elements to the UserProfiles collection
        /// </summary>
        /// <param name="userProfiles">The values to add to the UserProfiles collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeUserProfilesResult WithUserProfiles(params UserProfile[] userProfiles)
        {
            foreach (UserProfile element in userProfiles)
            {
                this.userProfiles.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the UserProfiles collection
        /// </summary>
        /// <param name="userProfiles">The values to add to the UserProfiles collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeUserProfilesResult WithUserProfiles(IEnumerable<UserProfile> userProfiles)
        {
            foreach (UserProfile element in userProfiles)
            {
                this.userProfiles.Add(element);
            }

            return this;
        }

        // Check to see if UserProfiles property is set
        internal bool IsSetUserProfiles()
        {
            return this.userProfiles.Count > 0;
        }
    }
}
