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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about an external access or unused access finding. Only one parameter
    /// can be used in a <c>FindingDetails</c> object.
    /// </summary>
    public partial class FindingDetails
    {
        /// <summary>
        /// Gets and sets the property ExternalAccessDetails. 
        /// <para>
        /// The details for an external access analyzer finding.
        /// </para>
        /// </summary>
        public ExternalAccessDetails ExternalAccessDetails { get; set; }

        /// <summary>
        /// Checks to see if the ExternalAccessDetails property is set.
        /// </summary>
        internal bool IsSetExternalAccessDetails() => this.ExternalAccessDetails != null;

        /// <summary>
        /// Gets and sets the property InternalAccessDetails. 
        /// <para>
        /// The details for an internal access analyzer finding. This contains information about
        /// access patterns identified within your Amazon Web Services organization or account.
        /// </para>
        /// </summary>
        public InternalAccessDetails InternalAccessDetails { get; set; }

        /// <summary>
        /// Checks to see if the InternalAccessDetails property is set.
        /// </summary>
        internal bool IsSetInternalAccessDetails() => this.InternalAccessDetails != null;

        /// <summary>
        /// Gets and sets the property UnusedIamRoleDetails. 
        /// <para>
        /// The details for an unused access analyzer finding with an unused IAM role finding
        /// type.
        /// </para>
        /// </summary>
        public UnusedIamRoleDetails UnusedIamRoleDetails { get; set; }

        /// <summary>
        /// Checks to see if the UnusedIamRoleDetails property is set.
        /// </summary>
        internal bool IsSetUnusedIamRoleDetails() => this.UnusedIamRoleDetails != null;

        /// <summary>
        /// Gets and sets the property UnusedIamUserAccessKeyDetails. 
        /// <para>
        /// The details for an unused access analyzer finding with an unused IAM user access key
        /// finding type.
        /// </para>
        /// </summary>
        public UnusedIamUserAccessKeyDetails UnusedIamUserAccessKeyDetails { get; set; }

        /// <summary>
        /// Checks to see if the UnusedIamUserAccessKeyDetails property is set.
        /// </summary>
        internal bool IsSetUnusedIamUserAccessKeyDetails() => this.UnusedIamUserAccessKeyDetails != null;

        /// <summary>
        /// Gets and sets the property UnusedIamUserPasswordDetails. 
        /// <para>
        /// The details for an unused access analyzer finding with an unused IAM user password
        /// finding type.
        /// </para>
        /// </summary>
        public UnusedIamUserPasswordDetails UnusedIamUserPasswordDetails { get; set; }

        /// <summary>
        /// Checks to see if the UnusedIamUserPasswordDetails property is set.
        /// </summary>
        internal bool IsSetUnusedIamUserPasswordDetails() => this.UnusedIamUserPasswordDetails != null;

        /// <summary>
        /// Gets and sets the property UnusedPermissionDetails. 
        /// <para>
        /// The details for an unused access analyzer finding with an unused permission finding
        /// type.
        /// </para>
        /// </summary>
        public UnusedPermissionDetails UnusedPermissionDetails { get; set; }

        /// <summary>
        /// Checks to see if the UnusedPermissionDetails property is set.
        /// </summary>
        internal bool IsSetUnusedPermissionDetails() => this.UnusedPermissionDetails != null;
    }
}
