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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetMaintenanceWindowTask operation.
    /// Retrieves the details of a maintenance window task.
    /// 
    ///  <note> 
    /// <para>
    /// For maintenance window tasks without a specified target, you can't supply values for
    /// <c>--max-errors</c> and <c>--max-concurrency</c>. Instead, the system inserts a placeholder
    /// value of <c>1</c>, which may be reported in the response to this command. These values
    /// don't affect the running of your task and can be ignored.
    /// </para>
    ///  </note> 
    /// <para>
    /// To retrieve a list of tasks in a maintenance window, instead use the <a>DescribeMaintenanceWindowTasks</a>
    /// command.
    /// </para>
    /// </summary>
    public partial class GetMaintenanceWindowTaskRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _windowId;
        private string _windowTaskId;

        /// <summary>
        /// Gets and sets the property WindowId. 
        /// <para>
        /// The maintenance window ID that includes the task to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=20)]
        public string WindowId
        {
            get { return this._windowId; }
            set { this._windowId = value; }
        }

        // Check to see if WindowId property is set
        internal bool IsSetWindowId()
        {
            return this._windowId != null;
        }

        /// <summary>
        /// Gets and sets the property WindowTaskId. 
        /// <para>
        /// The maintenance window task ID to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string WindowTaskId
        {
            get { return this._windowTaskId; }
            set { this._windowTaskId = value; }
        }

        // Check to see if WindowTaskId property is set
        internal bool IsSetWindowTaskId()
        {
            return this._windowTaskId != null;
        }

    }
}