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

namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// This is the response object from the GetAutoManagementConfiguration operation.
    /// </summary>
    public partial class GetAutoManagementConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ExclusionList. 
        /// <para>
        /// List of Amazon Web Services services excluded from Automatic Management. You won't
        /// be notified of Service Quotas utilization for Amazon Web Services services added to
        /// the Automatic Management exclusion list. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<QuotaInfo>> ExclusionList { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<QuotaInfo>>() : null;

        /// <summary>
        /// Checks to see if the ExclusionList property is set.
        /// </summary>
        internal bool IsSetExclusionList() => this.ExclusionList != null && (this.ExclusionList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NotificationArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/notifications/latest/userguide/resource-level-permissions.html#rlp-table">User
        /// Notifications</a> Amazon Resource Name (ARN) for Automatic Management notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string NotificationArn { get; set; }

        /// <summary>
        /// Checks to see if the NotificationArn property is set.
        /// </summary>
        internal bool IsSetNotificationArn() => this.NotificationArn != null;

        /// <summary>
        /// Gets and sets the property OptInLevel. 
        /// <para>
        /// Information on the opt-in level for Automatic Management. Only Amazon Web Services
        /// account level is supported.
        /// </para>
        /// </summary>
        public OptInLevel OptInLevel { get; set; }

        /// <summary>
        /// Checks to see if the OptInLevel property is set.
        /// </summary>
        internal bool IsSetOptInLevel() => this.OptInLevel != null;

        /// <summary>
        /// Gets and sets the property OptInStatus. 
        /// <para>
        /// Status on whether Automatic Management is started or stopped.
        /// </para>
        /// </summary>
        public OptInStatus OptInStatus { get; set; }

        /// <summary>
        /// Checks to see if the OptInStatus property is set.
        /// </summary>
        internal bool IsSetOptInStatus() => this.OptInStatus != null;

        /// <summary>
        /// Gets and sets the property OptInType. 
        /// <para>
        /// Information on the opt-in type for Automatic Management. There are two modes: Notify
        /// only and Notify and Auto-Adjust. Currently, only NotifyOnly is available.
        /// </para>
        /// </summary>
        public OptInType OptInType { get; set; }

        /// <summary>
        /// Checks to see if the OptInType property is set.
        /// </summary>
        internal bool IsSetOptInType() => this.OptInType != null;
    }
}
