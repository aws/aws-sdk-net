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
    /// Container for the parameters to the DescribePermissions operation.
    /// <para>Describes the permissions for a specified stack.</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribePermissions"/>
    public class DescribePermissionsRequest : AmazonWebServiceRequest
    {
        private string iamUserArn;
        private string stackId;

        /// <summary>
        /// The user's IAM ARN. For more information about IAM ARNs, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Using Identifiers</a>.
        ///  
        /// </summary>
        public string IamUserArn
        {
            get { return this.iamUserArn; }
            set { this.iamUserArn = value; }
        }

        /// <summary>
        /// Sets the IamUserArn property
        /// </summary>
        /// <param name="iamUserArn">The value to set for the IamUserArn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribePermissionsRequest WithIamUserArn(string iamUserArn)
        {
            this.iamUserArn = iamUserArn;
            return this;
        }
            

        // Check to see if IamUserArn property is set
        internal bool IsSetIamUserArn()
        {
            return this.iamUserArn != null;
        }

        /// <summary>
        /// The stack ID.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribePermissionsRequest WithStackId(string stackId)
        {
            this.stackId = stackId;
            return this;
        }
            

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }
    }
}
    
