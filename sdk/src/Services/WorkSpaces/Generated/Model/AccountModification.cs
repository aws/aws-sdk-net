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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes a modification to the configuration of Bring Your Own License (BYOL) for
    /// the specified account.
    /// </summary>
    public partial class AccountModification
    {
        private string _dedicatedTenancyManagementCidrRange;
        private DedicatedTenancySupportResultEnum _dedicatedTenancySupport;
        private string _errorCode;
        private string _errorMessage;
        private DedicatedTenancyModificationStateEnum _modificationState;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property DedicatedTenancyManagementCidrRange. 
        /// <para>
        /// The IP address range, specified as an IPv4 CIDR block, for the management network
        /// interface used for the account.
        /// </para>
        /// </summary>
        public string DedicatedTenancyManagementCidrRange
        {
            get { return this._dedicatedTenancyManagementCidrRange; }
            set { this._dedicatedTenancyManagementCidrRange = value; }
        }

        // Check to see if DedicatedTenancyManagementCidrRange property is set
        internal bool IsSetDedicatedTenancyManagementCidrRange()
        {
            return this._dedicatedTenancyManagementCidrRange != null;
        }

        /// <summary>
        /// Gets and sets the property DedicatedTenancySupport. 
        /// <para>
        /// The status of BYOL (whether BYOL is being enabled or disabled).
        /// </para>
        /// </summary>
        public DedicatedTenancySupportResultEnum DedicatedTenancySupport
        {
            get { return this._dedicatedTenancySupport; }
            set { this._dedicatedTenancySupport = value; }
        }

        // Check to see if DedicatedTenancySupport property is set
        internal bool IsSetDedicatedTenancySupport()
        {
            return this._dedicatedTenancySupport != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code that is returned if the configuration of BYOL cannot be modified.
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
        /// The text of the error message that is returned if the configuration of BYOL cannot
        /// be modified.
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
        /// Gets and sets the property ModificationState. 
        /// <para>
        /// The state of the modification to the configuration of BYOL.
        /// </para>
        /// </summary>
        public DedicatedTenancyModificationStateEnum ModificationState
        {
            get { return this._modificationState; }
            set { this._modificationState = value; }
        }

        // Check to see if ModificationState property is set
        internal bool IsSetModificationState()
        {
            return this._modificationState != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when the modification of the BYOL configuration was started.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}