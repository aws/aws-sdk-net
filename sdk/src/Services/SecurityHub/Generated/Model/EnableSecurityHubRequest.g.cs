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
    /// Container for the parameters to the EnableSecurityHub operation. Enables Security
    /// Hub CSPM for your account in the current Region or the Region you specify in the request.
    /// <para> When you enable Security Hub CSPM, you grant to Security Hub CSPM the permissions
    /// necessary to gather findings from other services that are integrated with Security
    /// Hub CSPM. </para> <para> When you use the <c>EnableSecurityHub</c> operation to enable
    /// Security Hub CSPM, you also automatically enable the following standards: </para>
    /// <ul> <li> <para> Center for Internet Security (CIS) Amazon Web Services Foundations
    /// Benchmark v1.2.0 </para> </li> <li> <para> Amazon Web Services Foundational Security
    /// Best Practices </para> </li> </ul> <para> Other standards are not automatically enabled.
    /// </para> <para> To opt out of automatically enabled standards, set <c>EnableDefaultStandards</c>
    /// to <c>false</c>. </para> <para> After you enable Security Hub CSPM, to enable a standard,
    /// use the <c>BatchEnableStandards</c> operation. To disable a standard, use the <c>BatchDisableStandards</c>
    /// operation. </para> <para> To learn more, see the <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-settingup.html">setup
    /// information</a> in the <i>Security Hub CSPM User Guide</i>. </para>
    /// </summary>
    public partial class EnableSecurityHubRequest : AmazonSecurityHubRequest
    {
        /// <summary>
        /// Gets and sets the property ControlFindingGenerator. 
        /// <para>
        /// This field, used when enabling Security Hub CSPM, specifies whether the calling account
        /// has consolidated control findings turned on. If the value for this field is set to
        /// <c>SECURITY_CONTROL</c>, Security Hub CSPM generates a single finding for a control
        /// check even when the check applies to multiple enabled standards.
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
        /// Gets and sets the property EnableDefaultStandards. 
        /// <para>
        /// Whether to enable the security standards that Security Hub CSPM has designated as
        /// automatically enabled. If you don't provide a value for <c>EnableDefaultStandards</c>,
        /// it is set to <c>true</c>. To not enable the automatically enabled standards, set <c>EnableDefaultStandards</c>
        /// to <c>false</c>.
        /// </para>
        /// </summary>
        public bool? EnableDefaultStandards { get; set; }

        /// <summary>
        /// Checks to see if the EnableDefaultStandards property is set.
        /// </summary>
        internal bool IsSetEnableDefaultStandards() => this.EnableDefaultStandards.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to add to the hub resource when you enable Security Hub CSPM.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
