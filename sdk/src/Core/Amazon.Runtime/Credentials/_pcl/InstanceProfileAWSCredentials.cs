/*
 * Copyright 2011-2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Amazon.Runtime
{
    /// <summary>
    /// Credentials that are retrieved from the Instance Profile service on an EC2 instance
    /// </summary>
    [Obsolete("InstanceProfileAWSCredentials is no longer available on PCL platform", true)]
    public class InstanceProfileAWSCredentials : URIBasedRefreshingCredentialHelper
    {
        [Obsolete("InstanceProfileAWSCredentials is no longer available on PCL platform")]
        public string Role {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        [Obsolete("InstanceProfileAWSCredentials no longer available on PCL platform", true)]
        protected override CredentialsRefreshState GenerateNewCredentials()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Constructs a InstanceProfileAWSCredentials object for specific role
        /// </summary>
        /// <param name="role">Role to use</param>
        [Obsolete("InstanceProfileAWSCredentials no longer available on PCL platform", true)]
        public InstanceProfileAWSCredentials(string role)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Constructs a InstanceProfileAWSCredentials object for the first found role
        /// </summary>
        [Obsolete("InstanceProfileAWSCredentials no longer available on PCL platform", true)]
        public InstanceProfileAWSCredentials()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves a list of all roles available through current InstanceProfile service
        /// 
        /// InstanceProfileAWSCredentials is no longer supported in PCL.
        /// </summary>
        /// <returns></returns>
        [Obsolete("InstanceProfileAWSCredentials no longer available on PCL platform", true)]
        public static IEnumerable<string> GetAvailableRoles()
        {
            throw new NotImplementedException();
        }
    }
}
