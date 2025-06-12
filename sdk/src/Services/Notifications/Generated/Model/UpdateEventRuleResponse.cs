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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
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
namespace Amazon.Notifications.Model
{
    /// <summary>
    /// This is the response object from the UpdateEventRule operation.
    /// </summary>
    public partial class UpdateEventRuleResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _notificationConfigurationArn;
        private Dictionary<string, EventRuleStatusSummary> _statusSummaryByRegion = AWSConfigs.InitializeCollections ? new Dictionary<string, EventRuleStatusSummary>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) to use to update the <c>EventRule</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationConfigurationArn. 
        /// <para>
        /// The ARN of the <c>NotificationConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NotificationConfigurationArn
        {
            get { return this._notificationConfigurationArn; }
            set { this._notificationConfigurationArn = value; }
        }

        // Check to see if NotificationConfigurationArn property is set
        internal bool IsSetNotificationConfigurationArn()
        {
            return this._notificationConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property StatusSummaryByRegion. 
        /// <para>
        /// The status of the action by Region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, EventRuleStatusSummary> StatusSummaryByRegion
        {
            get { return this._statusSummaryByRegion; }
            set { this._statusSummaryByRegion = value; }
        }

        // Check to see if StatusSummaryByRegion property is set
        internal bool IsSetStatusSummaryByRegion()
        {
            return this._statusSummaryByRegion != null && (this._statusSummaryByRegion.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}