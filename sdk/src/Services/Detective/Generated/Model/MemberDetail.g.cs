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

namespace Amazon.Detective.Model
{
    /// <summary>
    /// Details about a member account in a behavior graph.
    /// </summary>
    public partial class MemberDetail
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account identifier for the member account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AdministratorId. 
        /// <para>
        /// The Amazon Web Services account identifier of the administrator account for the behavior
        /// graph.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AdministratorId { get; set; }

        /// <summary>
        /// Checks to see if the AdministratorId property is set.
        /// </summary>
        internal bool IsSetAdministratorId() => this.AdministratorId != null;

        /// <summary>
        /// Gets and sets the property DatasourcePackageIngestStates. 
        /// <para>
        /// The state of a data source package for the behavior graph.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> DatasourcePackageIngestStates { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the DatasourcePackageIngestStates property is set.
        /// </summary>
        internal bool IsSetDatasourcePackageIngestStates() => this.DatasourcePackageIngestStates != null && (this.DatasourcePackageIngestStates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DisabledReason. 
        /// <para>
        /// For member accounts with a status of <c>ACCEPTED_BUT_DISABLED</c>, the reason that
        /// the member account is not enabled.
        /// </para>
        ///  
        /// <para>
        /// The reason can have one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>VOLUME_TOO_HIGH</c> - Indicates that adding the member account would cause the
        /// data volume for the behavior graph to be too high.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VOLUME_UNKNOWN</c> - Indicates that Detective is unable to verify the data volume
        /// for the member account. This is usually because the member account is not enrolled
        /// in Amazon GuardDuty. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MemberDisabledReason DisabledReason { get; set; }

        /// <summary>
        /// Checks to see if the DisabledReason property is set.
        /// </summary>
        internal bool IsSetDisabledReason() => this.DisabledReason != null;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The Amazon Web Services account root user email address for the member account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null;

        /// <summary>
        /// Gets and sets the property GraphArn. 
        /// <para>
        /// The ARN of the behavior graph.
        /// </para>
        /// </summary>
        public string GraphArn { get; set; }

        /// <summary>
        /// Checks to see if the GraphArn property is set.
        /// </summary>
        internal bool IsSetGraphArn() => this.GraphArn != null;

        /// <summary>
        /// Gets and sets the property InvitationType. 
        /// <para>
        /// The type of behavior graph membership.
        /// </para>
        ///  
        /// <para>
        /// For an organization account in the organization behavior graph, the type is <c>ORGANIZATION</c>.
        /// </para>
        ///  
        /// <para>
        /// For an account that was invited to a behavior graph, the type is <c>INVITATION</c>.
        /// 
        /// </para>
        /// </summary>
        public InvitationType InvitationType { get; set; }

        /// <summary>
        /// Checks to see if the InvitationType property is set.
        /// </summary>
        internal bool IsSetInvitationType() => this.InvitationType != null;

        /// <summary>
        /// Gets and sets the property InvitedTime. 
        /// <para>
        /// For invited accounts, the date and time that Detective sent the invitation to the
        /// account. The value is an ISO8601 formatted string. For example, <c>2021-08-18T16:35:56.284Z</c>.
        /// </para>
        /// </summary>
        public DateTime? InvitedTime { get; set; }

        /// <summary>
        /// Checks to see if the InvitedTime property is set.
        /// </summary>
        internal bool IsSetInvitedTime() => this.InvitedTime.HasValue;

        /// <summary>
        /// Gets and sets the property MasterId. 
        /// <para>
        /// The Amazon Web Services account identifier of the administrator account for the behavior
        /// graph.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated. Use AdministratorId instead.")]
        [AWSProperty(Min = 12, Max = 12)]
        public string MasterId { get; set; }

        /// <summary>
        /// Checks to see if the MasterId property is set.
        /// </summary>
        internal bool IsSetMasterId() => this.MasterId != null;

        /// <summary>
        /// Gets and sets the property PercentOfGraphUtilization. 
        /// <para>
        /// The member account data volume as a percentage of the maximum allowed data volume.
        /// 0 indicates 0 percent, and 100 indicates 100 percent.
        /// </para>
        ///  
        /// <para>
        /// Note that this is not the percentage of the behavior graph data volume.
        /// </para>
        ///  
        /// <para>
        /// For example, the data volume for the behavior graph is 80 GB per day. The maximum
        /// data volume is 160 GB per day. If the data volume for the member account is 40 GB
        /// per day, then <c>PercentOfGraphUtilization</c> is 25. It represents 25% of the maximum
        /// allowed data volume. 
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated. Use VolumeUsageByDatasourcePackage instead.")]
        public double? PercentOfGraphUtilization { get; set; }

        /// <summary>
        /// Checks to see if the PercentOfGraphUtilization property is set.
        /// </summary>
        internal bool IsSetPercentOfGraphUtilization() => this.PercentOfGraphUtilization.HasValue;

        /// <summary>
        /// Gets and sets the property PercentOfGraphUtilizationUpdatedTime. 
        /// <para>
        /// The date and time when the graph utilization percentage was last updated. The value
        /// is an ISO8601 formatted string. For example, <c>2021-08-18T16:35:56.284Z</c>.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated. Use VolumeUsageByDatasourcePackage instead.")]
        public DateTime? PercentOfGraphUtilizationUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the PercentOfGraphUtilizationUpdatedTime property is set.
        /// </summary>
        internal bool IsSetPercentOfGraphUtilizationUpdatedTime() => this.PercentOfGraphUtilizationUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current membership status of the member account. The status can have one of the
        /// following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INVITED</c> - For invited accounts only. Indicates that the member was sent an
        /// invitation but has not yet responded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VERIFICATION_IN_PROGRESS</c> - For invited accounts only, indicates that Detective
        /// is verifying that the account identifier and email address provided for the member
        /// account match. If they do match, then Detective sends the invitation. If the email
        /// address and account identifier don't match, then the member cannot be added to the
        /// behavior graph.
        /// </para>
        ///  
        /// <para>
        /// For organization accounts in the organization behavior graph, indicates that Detective
        /// is verifying that the account belongs to the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VERIFICATION_FAILED</c> - For invited accounts only. Indicates that the account
        /// and email address provided for the member account do not match, and Detective did
        /// not send an invitation to the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENABLED</c> - Indicates that the member account currently contributes data to
        /// the behavior graph. For invited accounts, the member account accepted the invitation.
        /// For organization accounts in the organization behavior graph, the Detective administrator
        /// account enabled the organization account as a member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACCEPTED_BUT_DISABLED</c> - The account accepted the invitation, or was enabled
        /// by the Detective administrator account, but is prevented from contributing data to
        /// the behavior graph. <c>DisabledReason</c> provides the reason why the member account
        /// is not enabled.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Invited accounts that declined an invitation or that were removed from the behavior
        /// graph are not included. In the organization behavior graph, organization accounts
        /// that the Detective administrator account did not enable are not included.
        /// </para>
        /// </summary>
        public MemberStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedTime. 
        /// <para>
        /// The date and time that the member account was last updated. The value is an ISO8601
        /// formatted string. For example, <c>2021-08-18T16:35:56.284Z</c>.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTime property is set.
        /// </summary>
        internal bool IsSetUpdatedTime() => this.UpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property VolumeUsageByDatasourcePackage. 
        /// <para>
        /// Details on the volume of usage for each data source package in a behavior graph.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, DatasourcePackageUsageInfo> VolumeUsageByDatasourcePackage { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, DatasourcePackageUsageInfo>() : null;

        /// <summary>
        /// Checks to see if the VolumeUsageByDatasourcePackage property is set.
        /// </summary>
        internal bool IsSetVolumeUsageByDatasourcePackage() => this.VolumeUsageByDatasourcePackage != null && (this.VolumeUsageByDatasourcePackage.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VolumeUsageInBytes. 
        /// <para>
        /// The data volume in bytes per day for the member account.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated. Use VolumeUsageByDatasourcePackage instead.")]
        public long? VolumeUsageInBytes { get; set; }

        /// <summary>
        /// Checks to see if the VolumeUsageInBytes property is set.
        /// </summary>
        internal bool IsSetVolumeUsageInBytes() => this.VolumeUsageInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property VolumeUsageUpdatedTime. 
        /// <para>
        /// The data and time when the member account data volume was last updated. The value
        /// is an ISO8601 formatted string. For example, <c>2021-08-18T16:35:56.284Z</c>.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated. Use VolumeUsageByDatasourcePackage instead.")]
        public DateTime? VolumeUsageUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the VolumeUsageUpdatedTime property is set.
        /// </summary>
        internal bool IsSetVolumeUsageUpdatedTime() => this.VolumeUsageUpdatedTime.HasValue;
    }
}
