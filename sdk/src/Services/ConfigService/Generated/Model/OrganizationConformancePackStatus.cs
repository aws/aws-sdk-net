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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Returns the status for an organization conformance pack in an organization.
    /// </summary>
    public partial class OrganizationConformancePackStatus
    {
        private string _errorCode;
        private string _errorMessage;
        private DateTime? _lastUpdateTime;
        private string _organizationConformancePackName;
        private OrganizationResourceStatus _status;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// An error code that is returned when organization conformance pack creation or deletion
        /// has failed in a member account. 
        /// </para>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// An error message indicating that organization conformance pack creation or deletion
        /// failed due to an error. 
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The timestamp of the last update.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationConformancePackName. 
        /// <para>
        /// The name that you assign to organization conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string OrganizationConformancePackName
        {
            get { return this._organizationConformancePackName; }
            set { this._organizationConformancePackName = value; }
        }

        // Check to see if OrganizationConformancePackName property is set
        internal bool IsSetOrganizationConformancePackName()
        {
            return this._organizationConformancePackName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates deployment status of an organization conformance pack. When management account
        /// calls PutOrganizationConformancePack for the first time, conformance pack status is
        /// created in all the member accounts. When management account calls PutOrganizationConformancePack
        /// for the second time, conformance pack status is updated in all the member accounts.
        /// Additionally, conformance pack status is updated when one or more member accounts
        /// join or leave an organization. Conformance pack status is deleted when the management
        /// account deletes OrganizationConformancePack in all the member accounts and disables
        /// service access for <c>config-multiaccountsetup.amazonaws.com</c>.
        /// </para>
        ///  
        /// <para>
        /// Config sets the state of the conformance pack to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE_SUCCESSFUL</c> when an organization conformance pack has been successfully
        /// created in all the member accounts. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_IN_PROGRESS</c> when an organization conformance pack creation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_FAILED</c> when an organization conformance pack creation failed in one
        /// or more member accounts within that organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_FAILED</c> when an organization conformance pack deletion failed in one
        /// or more member accounts within that organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_IN_PROGRESS</c> when an organization conformance pack deletion is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_SUCCESSFUL</c> when an organization conformance pack has been successfully
        /// deleted from all the member accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_SUCCESSFUL</c> when an organization conformance pack has been successfully
        /// updated in all the member accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_IN_PROGRESS</c> when an organization conformance pack update is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_FAILED</c> when an organization conformance pack update failed in one or
        /// more member accounts within that organization.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public OrganizationResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}