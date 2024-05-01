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
 * Do not modify this file. This file is generated from the appfabric-2023-05-19.normal.json service model.
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
namespace Amazon.AppFabric.Model
{
    /// <summary>
    /// Contains information about a user's access to an application.
    /// </summary>
    public partial class UserAccessResultItem
    {
        private string _app;
        private string _email;
        private ResultStatus _resultStatus;
        private TaskError _taskError;
        private string _taskId;
        private string _tenantDisplayName;
        private string _tenantId;
        private string _userFirstName;
        private string _userFullName;
        private string _userId;
        private string _userLastName;
        private string _userStatus;

        /// <summary>
        /// Gets and sets the property App. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string App
        {
            get { return this._app; }
            set { this._app = value; }
        }

        // Check to see if App property is set
        internal bool IsSetApp()
        {
            return this._app != null;
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address of the target user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=320)]
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property ResultStatus. 
        /// <para>
        /// The status of the user access result item.
        /// </para>
        ///  
        /// <para>
        /// The following states are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c>: The user access task is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c>: The user access task completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>: The user access task failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPIRED</c>: The user access task expired.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResultStatus ResultStatus
        {
            get { return this._resultStatus; }
            set { this._resultStatus = value; }
        }

        // Check to see if ResultStatus property is set
        internal bool IsSetResultStatus()
        {
            return this._resultStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TaskError. 
        /// <para>
        /// Contains information about an error returned from a user access task.
        /// </para>
        /// </summary>
        public TaskError TaskError
        {
            get { return this._taskError; }
            set { this._taskError = value; }
        }

        // Check to see if TaskError property is set
        internal bool IsSetTaskError()
        {
            return this._taskError != null;
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The unique ID of the task.
        /// </para>
        /// </summary>
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property TenantDisplayName. 
        /// <para>
        /// The display name of the tenant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string TenantDisplayName
        {
            get { return this._tenantDisplayName; }
            set { this._tenantDisplayName = value; }
        }

        // Check to see if TenantDisplayName property is set
        internal bool IsSetTenantDisplayName()
        {
            return this._tenantDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// The ID of the application tenant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string TenantId
        {
            get { return this._tenantId; }
            set { this._tenantId = value; }
        }

        // Check to see if TenantId property is set
        internal bool IsSetTenantId()
        {
            return this._tenantId != null;
        }

        /// <summary>
        /// Gets and sets the property UserFirstName. 
        /// <para>
        /// The first name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2048)]
        public string UserFirstName
        {
            get { return this._userFirstName; }
            set { this._userFirstName = value; }
        }

        // Check to see if UserFirstName property is set
        internal bool IsSetUserFirstName()
        {
            return this._userFirstName != null;
        }

        /// <summary>
        /// Gets and sets the property UserFullName. 
        /// <para>
        /// The full name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2048)]
        public string UserFullName
        {
            get { return this._userFullName; }
            set { this._userFullName = value; }
        }

        // Check to see if UserFullName property is set
        internal bool IsSetUserFullName()
        {
            return this._userFullName != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The unique ID of user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2048)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

        /// <summary>
        /// Gets and sets the property UserLastName. 
        /// <para>
        /// The last name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2048)]
        public string UserLastName
        {
            get { return this._userLastName; }
            set { this._userLastName = value; }
        }

        // Check to see if UserLastName property is set
        internal bool IsSetUserLastName()
        {
            return this._userLastName != null;
        }

        /// <summary>
        /// Gets and sets the property UserStatus. 
        /// <para>
        /// The status of the user returned by the application.
        /// </para>
        /// </summary>
        public string UserStatus
        {
            get { return this._userStatus; }
            set { this._userStatus = value; }
        }

        // Check to see if UserStatus property is set
        internal bool IsSetUserStatus()
        {
            return this._userStatus != null;
        }

    }
}