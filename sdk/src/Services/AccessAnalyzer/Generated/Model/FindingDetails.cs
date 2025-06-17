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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about an external access or unused access finding. Only one parameter
    /// can be used in a <c>FindingDetails</c> object.
    /// </summary>
    public partial class FindingDetails
    {
        private ExternalAccessDetails _externalAccessDetails;
        private InternalAccessDetails _internalAccessDetails;
        private UnusedIamRoleDetails _unusedIamRoleDetails;
        private UnusedIamUserAccessKeyDetails _unusedIamUserAccessKeyDetails;
        private UnusedIamUserPasswordDetails _unusedIamUserPasswordDetails;
        private UnusedPermissionDetails _unusedPermissionDetails;

        /// <summary>
        /// Gets and sets the property ExternalAccessDetails. 
        /// <para>
        /// The details for an external access analyzer finding.
        /// </para>
        /// </summary>
        public ExternalAccessDetails ExternalAccessDetails
        {
            get { return this._externalAccessDetails; }
            set { this._externalAccessDetails = value; }
        }

        // Check to see if ExternalAccessDetails property is set
        internal bool IsSetExternalAccessDetails()
        {
            return this._externalAccessDetails != null;
        }

        /// <summary>
        /// Gets and sets the property InternalAccessDetails. 
        /// <para>
        /// The details for an internal access analyzer finding. This contains information about
        /// access patterns identified within your Amazon Web Services organization or account.
        /// </para>
        /// </summary>
        public InternalAccessDetails InternalAccessDetails
        {
            get { return this._internalAccessDetails; }
            set { this._internalAccessDetails = value; }
        }

        // Check to see if InternalAccessDetails property is set
        internal bool IsSetInternalAccessDetails()
        {
            return this._internalAccessDetails != null;
        }

        /// <summary>
        /// Gets and sets the property UnusedIamRoleDetails. 
        /// <para>
        /// The details for an unused access analyzer finding with an unused IAM role finding
        /// type.
        /// </para>
        /// </summary>
        public UnusedIamRoleDetails UnusedIamRoleDetails
        {
            get { return this._unusedIamRoleDetails; }
            set { this._unusedIamRoleDetails = value; }
        }

        // Check to see if UnusedIamRoleDetails property is set
        internal bool IsSetUnusedIamRoleDetails()
        {
            return this._unusedIamRoleDetails != null;
        }

        /// <summary>
        /// Gets and sets the property UnusedIamUserAccessKeyDetails. 
        /// <para>
        /// The details for an unused access analyzer finding with an unused IAM user access key
        /// finding type.
        /// </para>
        /// </summary>
        public UnusedIamUserAccessKeyDetails UnusedIamUserAccessKeyDetails
        {
            get { return this._unusedIamUserAccessKeyDetails; }
            set { this._unusedIamUserAccessKeyDetails = value; }
        }

        // Check to see if UnusedIamUserAccessKeyDetails property is set
        internal bool IsSetUnusedIamUserAccessKeyDetails()
        {
            return this._unusedIamUserAccessKeyDetails != null;
        }

        /// <summary>
        /// Gets and sets the property UnusedIamUserPasswordDetails. 
        /// <para>
        /// The details for an unused access analyzer finding with an unused IAM user password
        /// finding type.
        /// </para>
        /// </summary>
        public UnusedIamUserPasswordDetails UnusedIamUserPasswordDetails
        {
            get { return this._unusedIamUserPasswordDetails; }
            set { this._unusedIamUserPasswordDetails = value; }
        }

        // Check to see if UnusedIamUserPasswordDetails property is set
        internal bool IsSetUnusedIamUserPasswordDetails()
        {
            return this._unusedIamUserPasswordDetails != null;
        }

        /// <summary>
        /// Gets and sets the property UnusedPermissionDetails. 
        /// <para>
        /// The details for an unused access analyzer finding with an unused permission finding
        /// type.
        /// </para>
        /// </summary>
        public UnusedPermissionDetails UnusedPermissionDetails
        {
            get { return this._unusedPermissionDetails; }
            set { this._unusedPermissionDetails = value; }
        }

        // Check to see if UnusedPermissionDetails property is set
        internal bool IsSetUnusedPermissionDetails()
        {
            return this._unusedPermissionDetails != null;
        }

    }
}