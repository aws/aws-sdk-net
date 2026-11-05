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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// This is the response object from the DescribeCAEnrollmentPolicy operation.
    /// </summary>
    public partial class DescribeCAEnrollmentPolicyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CaEnrollmentPolicyStatus. 
        /// <para>
        /// The current status of the CA enrollment policy. This indicates if automatic certificate
        /// enrollment is currently active, inactive, or in a transitional state.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> - The policy is being activated T
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESS</c> - The policy is active and automatic certificate enrollment is operational
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The policy activation or deactivation failed
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLING</c> - The policy is being deactivated
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> - The policy is inactive and automatic certificate enrollment is
        /// not available
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IMPAIRED</c> - Network connectivity is impaired.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CaEnrollmentPolicyStatus CaEnrollmentPolicyStatus { get; set; }

        /// <summary>
        /// Checks to see if the CaEnrollmentPolicyStatus property is set.
        /// </summary>
        internal bool IsSetCaEnrollmentPolicyStatus() => this.CaEnrollmentPolicyStatus != null;

        /// <summary>
        /// Gets and sets the property CaEnrollmentPolicyStatusReason. 
        /// <para>
        /// Additional information explaining the current status of the CA enrollment policy,
        /// particularly useful when the policy is in an error or transitional state.
        /// </para>
        /// </summary>
        public string CaEnrollmentPolicyStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the CaEnrollmentPolicyStatusReason property is set.
        /// </summary>
        internal bool IsSetCaEnrollmentPolicyStatusReason() => this.CaEnrollmentPolicyStatusReason != null;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory associated with this CA enrollment policy.
        /// </para>
        /// </summary>
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time when the CA enrollment policy was last modified or updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property PcaConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Private Certificate Authority
        /// (PCA) connector that is configured for automatic certificate enrollment in this directory.
        /// </para>
        /// </summary>
        public string PcaConnectorArn { get; set; }

        /// <summary>
        /// Checks to see if the PcaConnectorArn property is set.
        /// </summary>
        internal bool IsSetPcaConnectorArn() => this.PcaConnectorArn != null;
    }
}
