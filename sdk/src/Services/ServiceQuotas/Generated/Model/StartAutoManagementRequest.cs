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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
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
    /// Container for the parameters to the StartAutoManagement operation.
    /// Starts <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/automatic-management.html">Service
    /// Quotas Automatic Management</a> for an Amazon Web Services account, including notification
    /// preferences and excluded quotas configurations. Automatic Management monitors your
    /// Service Quotas utilization and notifies you before you run out of your allocated quotas.
    /// </summary>
    public partial class StartAutoManagementRequest : AmazonServiceQuotasRequest
    {
        private Dictionary<string, List<string>> _exclusionList = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private string _notificationArn;
        private OptInLevel _optInLevel;
        private OptInType _optInType;

        /// <summary>
        /// Gets and sets the property ExclusionList. 
        /// <para>
        /// List of Amazon Web Services services excluded from Automatic Management. You won't
        /// be notified of Service Quotas utilization for Amazon Web Services services added to
        /// the Automatic Management exclusion list. 
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> ExclusionList
        {
            get { return this._exclusionList; }
            set { this._exclusionList = value; }
        }

        // Check to see if ExclusionList property is set
        internal bool IsSetExclusionList()
        {
            return this._exclusionList != null && (this._exclusionList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotificationArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/notifications/latest/userguide/resource-level-permissions.html#rlp-table">User
        /// Notifications</a> Amazon Resource Name (ARN) for Automatic Management notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string NotificationArn
        {
            get { return this._notificationArn; }
            set { this._notificationArn = value; }
        }

        // Check to see if NotificationArn property is set
        internal bool IsSetNotificationArn()
        {
            return this._notificationArn != null;
        }

        /// <summary>
        /// Gets and sets the property OptInLevel. 
        /// <para>
        /// Sets the opt-in level for Automatic Management. Only Amazon Web Services account level
        /// is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OptInLevel OptInLevel
        {
            get { return this._optInLevel; }
            set { this._optInLevel = value; }
        }

        // Check to see if OptInLevel property is set
        internal bool IsSetOptInLevel()
        {
            return this._optInLevel != null;
        }

        /// <summary>
        /// Gets and sets the property OptInType. 
        /// <para>
        /// Sets the opt-in type for Automatic Management. There are two modes: Notify only and
        /// Notify and Auto-Adjust. Currently, only NotifyOnly is available.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OptInType OptInType
        {
            get { return this._optInType; }
            set { this._optInType = value; }
        }

        // Check to see if OptInType property is set
        internal bool IsSetOptInType()
        {
            return this._optInType != null;
        }

    }
}