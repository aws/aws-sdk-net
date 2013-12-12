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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Contains the response to a <c>DescribePermissions</c> request.</para>
    /// </summary>
    public partial class DescribePermissionsResult : AmazonWebServiceResponse
    {
        
        private List<Permission> permissions = new List<Permission>();


        /// <summary>
        /// An array of <c>Permission</c> objects that describe the stack permissions. <ul> <li>If the request object contains only a stack ID, the
        /// array contains a <c>Permission</c> object with permissions for each of the stack IAM ARNs.</li> <li>If the request object contains only an
        /// IAM ARN, the array contains a <c>Permission</c> object with permissions for each of the user's stack IDs.</li> <li>If the request contains a
        /// stack ID and an IAM ARN, the array contains a single <c>Permission</c> object with permissions for the specified stack and IAM ARN.</li>
        /// </ul>
        ///  
        /// </summary>
        public List<Permission> Permissions
        {
            get { return this.permissions; }
            set { this.permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this.permissions.Count > 0;
        }
    }
}
