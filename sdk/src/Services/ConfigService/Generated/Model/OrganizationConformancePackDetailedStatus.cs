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
    /// Organization conformance pack creation or deletion status in each member account.
    /// This includes the name of the conformance pack, the status, error code and error message
    /// when the conformance pack creation or deletion failed.
    /// </summary>
    public partial class OrganizationConformancePackDetailedStatus
    {
        private string _accountId;
        private string _conformancePackName;
        private string _errorCode;
        private string _errorMessage;
        private DateTime? _lastUpdateTime;
        private OrganizationResourceDetailedStatus _status;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The 12-digit account ID of a member account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property ConformancePackName. 
        /// <para>
        /// The name of conformance pack deployed in the member account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ConformancePackName
        {
            get { return this._conformancePackName; }
            set { this._conformancePackName = value; }
        }

        // Check to see if ConformancePackName property is set
        internal bool IsSetConformancePackName()
        {
            return this._conformancePackName != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// An error code that is returned when conformance pack creation or deletion failed in
        /// the member account. 
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
        /// An error message indicating that conformance pack account creation or deletion has
        /// failed due to an error in the member account. 
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
        /// The timestamp of the last status update.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates deployment status for conformance pack in a member account. When management
        /// account calls <c>PutOrganizationConformancePack</c> action for the first time, conformance
        /// pack status is created in the member account. When management account calls <c>PutOrganizationConformancePack</c>
        /// action for the second time, conformance pack status is updated in the member account.
        /// Conformance pack status is deleted when the management account deletes <c>OrganizationConformancePack</c>
        /// and disables service access for <c>config-multiaccountsetup.amazonaws.com</c>. 
        /// </para>
        ///  
        /// <para>
        ///  Config sets the state of the conformance pack to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE_SUCCESSFUL</c> when conformance pack has been created in the member account.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_IN_PROGRESS</c> when conformance pack is being created in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_FAILED</c> when conformance pack creation has failed in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_FAILED</c> when conformance pack deletion has failed in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_IN_PROGRESS</c> when conformance pack is being deleted in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_SUCCESSFUL</c> when conformance pack has been deleted in the member account.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_SUCCESSFUL</c> when conformance pack has been updated in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_IN_PROGRESS</c> when conformance pack is being updated in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_FAILED</c> when conformance pack deletion has failed in the member account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public OrganizationResourceDetailedStatus Status
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