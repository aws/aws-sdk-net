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

/*
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
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
    /// Requests a description of a specified set of apps.
    /// 
    ///  <note> 
    /// <para>
    /// This call accepts only one resource-identifying parameter.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
    /// or Manage permissions level for the stack, or an attached policy that explicitly grants
    /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class DescribeAppsRequest : AmazonOpsWorksRequest
    {
        private List<string> _appIds = new List<string>();
        private string _stackId;

        /// <summary>
        /// Gets and sets the property AppIds. 
        /// <para>
        /// An array of app IDs for the apps to be described. If you use this parameter, <code>DescribeApps</code>
        /// returns a description of the specified apps. Otherwise, it returns a description of
        /// every app.
        /// </para>
        /// </summary>
        public List<string> AppIds
        {
            get { return this._appIds; }
            set { this._appIds = value; }
        }

        // Check to see if AppIds property is set
        internal bool IsSetAppIds()
        {
            return this._appIds != null && this._appIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The app stack ID. If you use this parameter, <code>DescribeApps</code> returns a description
        /// of the apps in the specified stack.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

    }
}