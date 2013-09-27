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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeUserProfiles operation.
    /// <para>Describe specified users.</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeUserProfiles"/>
    public class DescribeUserProfilesRequest : AmazonWebServiceRequest
    {
        private List<string> iamUserArns = new List<string>();

        /// <summary>
        /// An array of IAM user ARNs that identify the users to be described.
        ///  
        /// </summary>
        public List<string> IamUserArns
        {
            get { return this.iamUserArns; }
            set { this.iamUserArns = value; }
        }
        /// <summary>
        /// Adds elements to the IamUserArns collection
        /// </summary>
        /// <param name="iamUserArns">The values to add to the IamUserArns collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeUserProfilesRequest WithIamUserArns(params string[] iamUserArns)
        {
            foreach (string element in iamUserArns)
            {
                this.iamUserArns.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the IamUserArns collection
        /// </summary>
        /// <param name="iamUserArns">The values to add to the IamUserArns collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeUserProfilesRequest WithIamUserArns(IEnumerable<string> iamUserArns)
        {
            foreach (string element in iamUserArns)
            {
                this.iamUserArns.Add(element);
            }

            return this;
        }

        // Check to see if IamUserArns property is set
        internal bool IsSetIamUserArns()
        {
            return this.iamUserArns.Count > 0;
        }
    }
}
    
