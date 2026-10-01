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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the DescribeHub operation.
    /// </summary>
    public partial class DescribeHubResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AutoEnableControls. 
        /// <para>
        /// Whether to automatically enable new controls when they are added to standards that
        /// are enabled.
        /// </para>
        ///  
        /// <para>
        /// If set to <c>true</c>, then new controls for enabled standards are enabled automatically.
        /// If set to <c>false</c>, then new controls are not enabled.
        /// </para>
        ///  
        /// <para>
        /// When you automatically enable new controls, you can interact with the controls in
        /// the console and programmatically immediately after release. However, automatically
        /// enabled controls have a temporary default status of <c>DISABLED</c>. It can take up
        /// to several days for Security Hub CSPM to process the control release and designate
        /// the control as <c>ENABLED</c> in your account. During the processing period, you can
        /// manually enable or disable a control, and Security Hub CSPM will maintain that designation
        /// regardless of whether you have <c>AutoEnableControls</c> set to <c>true</c>.
        /// </para>
        /// </summary>
        public bool? AutoEnableControls { get; set; }

        /// <summary>
        /// Checks to see if the AutoEnableControls property is set.
        /// </summary>
        internal bool IsSetAutoEnableControls() => this.AutoEnableControls.HasValue;

        /// <summary>
        /// Gets and sets the property ControlFindingGenerator. 
        /// <para>
        /// Specifies whether the calling account has consolidated control findings turned on.
        /// If the value for this field is set to <c>SECURITY_CONTROL</c>, Security Hub CSPM generates
        /// a single finding for a control check even when the check applies to multiple enabled
        /// standards.
        /// </para>
        ///  
        /// <para>
        /// If the value for this field is set to <c>STANDARD_CONTROL</c>, Security Hub CSPM generates
        /// separate findings for a control check when the check applies to multiple enabled standards.
        /// </para>
        ///  
        /// <para>
        /// The value for this field in a member account matches the value in the administrator
        /// account. For accounts that aren't part of an organization, the default value of this
        /// field is <c>SECURITY_CONTROL</c> if you enabled Security Hub CSPM on or after February
        /// 23, 2023.
        /// </para>
        /// </summary>
        public ControlFindingGenerator ControlFindingGenerator { get; set; }

        /// <summary>
        /// Checks to see if the ControlFindingGenerator property is set.
        /// </summary>
        internal bool IsSetControlFindingGenerator() => this.ControlFindingGenerator != null;

        /// <summary>
        /// Gets and sets the property HubArn. 
        /// <para>
        /// The ARN of the Hub resource that was retrieved.
        /// </para>
        /// </summary>
        public string HubArn { get; set; }

        /// <summary>
        /// Checks to see if the HubArn property is set.
        /// </summary>
        internal bool IsSetHubArn() => this.HubArn != null;

        /// <summary>
        /// Gets and sets the property SubscribedAt. 
        /// <para>
        /// The date and time when Security Hub CSPM was enabled in the account.
        /// </para>
        /// </summary>
        public string SubscribedAt { get; set; }

        /// <summary>
        /// Checks to see if the SubscribedAt property is set.
        /// </summary>
        internal bool IsSetSubscribedAt() => this.SubscribedAt != null;
    }
}
