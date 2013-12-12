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
    /// Container for the parameters to the DescribeApps operation.
    /// <para>Requests a description of a specified set of apps.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para>
    /// <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions level for the stack, or
    /// an attached policy that explicitly grants permissions. For more information on user permissions, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
    /// </summary>
    public partial class DescribeAppsRequest : AmazonOpsWorksRequest
    {
        private string stackId;
        private List<string> appIds = new List<string>();


        /// <summary>
        /// The app stack ID. If you use this parameter, <c>DescribeApps</c> returns a description of the apps in the specified stack.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

        /// <summary>
        /// An array of app IDs for the apps to be described. If you use this parameter, <c>DescribeApps</c> returns a description of the specified
        /// apps. Otherwise, it returns a description of every app.
        ///  
        /// </summary>
        public List<string> AppIds
        {
            get { return this.appIds; }
            set { this.appIds = value; }
        }

        // Check to see if AppIds property is set
        internal bool IsSetAppIds()
        {
            return this.appIds.Count > 0;
        }

    }
}
    
