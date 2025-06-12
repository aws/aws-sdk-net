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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about notification triggers for the deployment group.
    /// </summary>
    public partial class TriggerConfig
    {
        private List<string> _triggerEvents = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _triggerName;
        private string _triggerTargetArn;

        /// <summary>
        /// Gets and sets the property TriggerEvents. 
        /// <para>
        /// The event type or types for which notifications are triggered.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TriggerEvents
        {
            get { return this._triggerEvents; }
            set { this._triggerEvents = value; }
        }

        // Check to see if TriggerEvents property is set
        internal bool IsSetTriggerEvents()
        {
            return this._triggerEvents != null && (this._triggerEvents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TriggerName. 
        /// <para>
        /// The name of the notification trigger.
        /// </para>
        /// </summary>
        public string TriggerName
        {
            get { return this._triggerName; }
            set { this._triggerName = value; }
        }

        // Check to see if TriggerName property is set
        internal bool IsSetTriggerName()
        {
            return this._triggerName != null;
        }

        /// <summary>
        /// Gets and sets the property TriggerTargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service topic through
        /// which notifications about deployment or instance events are sent.
        /// </para>
        /// </summary>
        public string TriggerTargetArn
        {
            get { return this._triggerTargetArn; }
            set { this._triggerTargetArn = value; }
        }

        // Check to see if TriggerTargetArn property is set
        internal bool IsSetTriggerTargetArn()
        {
            return this._triggerTargetArn != null;
        }

    }
}