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

namespace Amazon.Chatbot.Model
{
    /// <summary>
    /// Defines when a custom action button should be attached to a notification.
    /// </summary>
    public partial class CustomActionAttachment
    {
        /// <summary>
        /// Gets and sets the property ButtonText. 
        /// <para>
        /// The text of the button that appears on the notification.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string ButtonText { get; set; }

        /// <summary>
        /// Checks to see if the ButtonText property is set.
        /// </summary>
        internal bool IsSetButtonText() => this.ButtonText != null;

        /// <summary>
        /// Gets and sets the property Criteria. 
        /// <para>
        /// The criteria for when a button should be shown based on values in the notification.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<CustomActionAttachmentCriteria> Criteria { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomActionAttachmentCriteria>() : null;

        /// <summary>
        /// Checks to see if the Criteria property is set.
        /// </summary>
        internal bool IsSetCriteria() => this.Criteria != null && (this.Criteria.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NotificationType. 
        /// <para>
        /// The type of notification that the custom action should be attached to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string NotificationType { get; set; }

        /// <summary>
        /// Checks to see if the NotificationType property is set.
        /// </summary>
        internal bool IsSetNotificationType() => this.NotificationType != null;

        /// <summary>
        /// Gets and sets the property Variables. 
        /// <para>
        /// The variables to extract from the notification.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public Dictionary<string, string> Variables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Variables property is set.
        /// </summary>
        internal bool IsSetVariables() => this.Variables != null && (this.Variables.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
