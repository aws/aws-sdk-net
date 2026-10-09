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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Summary representation of an alert used in list responses.
    /// </summary>
    public partial class AlertSummary
    {
        /// <summary>
        /// Gets and sets the property AlertArn. The Amazon Resource Name (ARN) of the alert.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string AlertArn { get; set; }

        /// <summary>
        /// Checks to see if the AlertArn property is set.
        /// </summary>
        internal bool IsSetAlertArn() => this.AlertArn != null;

        /// <summary>
        /// Gets and sets the property AlertId. The stable alert identifier (see {@link Alert#alertId}).
        /// Use it to address the alert; it is also the ARN's resource id.
        /// </summary>
        [AWSProperty(Min = 32, Max = 32)]
        public string AlertId { get; set; }

        /// <summary>
        /// Checks to see if the AlertId property is set.
        /// </summary>
        internal bool IsSetAlertId() => this.AlertId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. The timestamp when the alert was created.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. The name of the alert.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NotificationStatus. Whether notifications are enabled.
        /// </summary>
        public NotificationStatus NotificationStatus { get; set; }

        /// <summary>
        /// Checks to see if the NotificationStatus property is set.
        /// </summary>
        internal bool IsSetNotificationStatus() => this.NotificationStatus != null;

        /// <summary>
        /// Gets and sets the property ProfileId. The ID of the access profile associated with
        /// the alert.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;

        /// <summary>
        /// Gets and sets the property SpaceId. The ID of the space the alert belongs to.
        /// </summary>
        public string SpaceId { get; set; }

        /// <summary>
        /// Checks to see if the SpaceId property is set.
        /// </summary>
        internal bool IsSetSpaceId() => this.SpaceId != null;

        /// <summary>
        /// Gets and sets the property State. Live evaluation state (read-only, system-managed).
        /// </summary>
        [AWSProperty(Required = true)]
        public AlertStateInfo State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. The timestamp when the alert was last updated.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
