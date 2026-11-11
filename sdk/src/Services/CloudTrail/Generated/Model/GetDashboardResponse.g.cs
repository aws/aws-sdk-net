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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// This is the response object from the GetDashboard operation.
    /// </summary>
    public partial class GetDashboardResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        ///  The timestamp that shows when the dashboard was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DashboardArn. 
        /// <para>
        ///  The ARN for the dashboard. 
        /// </para>
        /// </summary>
        public string DashboardArn { get; set; }

        /// <summary>
        /// Checks to see if the DashboardArn property is set.
        /// </summary>
        internal bool IsSetDashboardArn() => this.DashboardArn != null;

        /// <summary>
        /// Gets and sets the property LastRefreshFailureReason. 
        /// <para>
        ///  Provides information about failures for the last scheduled refresh. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 1000)]
        public string LastRefreshFailureReason { get; set; }

        /// <summary>
        /// Checks to see if the LastRefreshFailureReason property is set.
        /// </summary>
        internal bool IsSetLastRefreshFailureReason() => this.LastRefreshFailureReason != null;

        /// <summary>
        /// Gets and sets the property LastRefreshId. 
        /// <para>
        ///  The ID of the last dashboard refresh. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 20)]
        public string LastRefreshId { get; set; }

        /// <summary>
        /// Checks to see if the LastRefreshId property is set.
        /// </summary>
        internal bool IsSetLastRefreshId() => this.LastRefreshId != null;

        /// <summary>
        /// Gets and sets the property RefreshSchedule. 
        /// <para>
        ///  The refresh schedule for the dashboard, if configured. 
        /// </para>
        /// </summary>
        public RefreshSchedule RefreshSchedule { get; set; }

        /// <summary>
        /// Checks to see if the RefreshSchedule property is set.
        /// </summary>
        internal bool IsSetRefreshSchedule() => this.RefreshSchedule != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the dashboard. 
        /// </para>
        /// </summary>
        public DashboardStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TerminationProtectionEnabled. 
        /// <para>
        ///  Indicates whether termination protection is enabled for the dashboard. 
        /// </para>
        /// </summary>
        public bool? TerminationProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TerminationProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetTerminationProtectionEnabled() => this.TerminationProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of dashboard. 
        /// </para>
        /// </summary>
        public DashboardType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        ///  The timestamp that shows when the dashboard was last updated. 
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetUpdatedTimestamp() => this.UpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Widgets. 
        /// <para>
        ///  An array of widgets for the dashboard. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Widget> Widgets { get; set; } = AWSConfigs.InitializeCollections ? new List<Widget>() : null;

        /// <summary>
        /// Checks to see if the Widgets property is set.
        /// </summary>
        internal bool IsSetWidgets() => this.Widgets != null && (this.Widgets.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
