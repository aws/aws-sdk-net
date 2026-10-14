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

namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEnrollmentConfiguration operation. Updates
    /// your account’s Compute Optimizer Automation enrollment configuration.
    /// </summary>
    public partial class UpdateEnrollmentConfigurationRequest : AmazonComputeOptimizerAutomationRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. Must be 1-64 characters long and contain only alphanumeric characters,
        /// underscores, and hyphens.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The desired enrollment status. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Active - Enables the Automation feature for your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Inactive - Disables the Automation feature for your account and stops all of your
        /// automation rules. If you opt in again later, all rules will be inactive, and you must
        /// enable the rules you want to run. You must wait at least 24 hours after opting out
        /// to opt in again.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <c>Pending</c> and <c>Failed</c> options cannot be used to update the enrollment
        /// status of an account. They are returned in the response of a request to update the
        /// enrollment status of an account.
        /// </para>
        ///  
        /// <para>
        /// If you are a member account, your account must be disassociated from your organization’s
        /// management account before you can disable Automation. Contact your administrator to
        /// make this change.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public EnrollmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
