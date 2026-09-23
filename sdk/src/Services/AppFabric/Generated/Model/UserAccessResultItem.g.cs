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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property App. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string App { get; set; }

        /// <summary>
        /// Checks to see if the App property is set.
        /// </summary>
        internal bool IsSetApp() => this.App != null;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address of the target user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 320)]
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

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
        public ResultStatus ResultStatus { get; set; }

        /// <summary>
        /// Checks to see if the ResultStatus property is set.
        /// </summary>
        internal bool IsSetResultStatus() => this.ResultStatus != null;

        /// <summary>
        /// Gets and sets the property TaskError. 
        /// <para>
        /// Contains information about an error returned from a user access task.
        /// </para>
        /// </summary>
        public TaskError TaskError { get; set; }

        /// <summary>
        /// Checks to see if the TaskError property is set.
        /// </summary>
        internal bool IsSetTaskError() => this.TaskError != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The unique ID of the task.
        /// </para>
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property TenantDisplayName. 
        /// <para>
        /// The display name of the tenant.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string TenantDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the TenantDisplayName property is set.
        /// </summary>
        internal bool IsSetTenantDisplayName() => this.TenantDisplayName != null;

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// The ID of the application tenant.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string TenantId { get; set; }

        /// <summary>
        /// Checks to see if the TenantId property is set.
        /// </summary>
        internal bool IsSetTenantId() => this.TenantId != null;

        /// <summary>
        /// Gets and sets the property UserFirstName. 
        /// <para>
        /// The first name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string UserFirstName { get; set; }

        /// <summary>
        /// Checks to see if the UserFirstName property is set.
        /// </summary>
        internal bool IsSetUserFirstName() => this.UserFirstName != null;

        /// <summary>
        /// Gets and sets the property UserFullName. 
        /// <para>
        /// The full name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string UserFullName { get; set; }

        /// <summary>
        /// Checks to see if the UserFullName property is set.
        /// </summary>
        internal bool IsSetUserFullName() => this.UserFullName != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The unique ID of user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;

        /// <summary>
        /// Gets and sets the property UserLastName. 
        /// <para>
        /// The last name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string UserLastName { get; set; }

        /// <summary>
        /// Checks to see if the UserLastName property is set.
        /// </summary>
        internal bool IsSetUserLastName() => this.UserLastName != null;

        /// <summary>
        /// Gets and sets the property UserStatus. 
        /// <para>
        /// The status of the user returned by the application.
        /// </para>
        /// </summary>
        public string UserStatus { get; set; }

        /// <summary>
        /// Checks to see if the UserStatus property is set.
        /// </summary>
        internal bool IsSetUserStatus() => this.UserStatus != null;
    }
}
