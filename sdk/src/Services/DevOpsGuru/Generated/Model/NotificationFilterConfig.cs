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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// The filter configurations for the Amazon SNS notification topic you use with DevOps
    /// Guru. You can choose to specify which events or message types to receive notifications
    /// for. You can also choose to specify which severity levels to receive notifications
    /// for.
    /// </summary>
    public partial class NotificationFilterConfig
    {
        private List<string> _messageTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _severities = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property MessageTypes. 
        /// <para>
        ///  The events that you want to receive notifications for. For example, you can choose
        /// to receive notifications only when the severity level is upgraded or a new insight
        /// is created. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> MessageTypes
        {
            get { return this._messageTypes; }
            set { this._messageTypes = value; }
        }

        // Check to see if MessageTypes property is set
        internal bool IsSetMessageTypes()
        {
            return this._messageTypes != null && (this._messageTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Severities. 
        /// <para>
        ///  The severity levels that you want to receive notifications for. For example, you
        /// can choose to receive notifications only for insights with <c>HIGH</c> and <c>MEDIUM</c>
        /// severity levels. For more information, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/working-with-insights.html#understanding-insights-severities">Understanding
        /// insight severities</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> Severities
        {
            get { return this._severities; }
            set { this._severities = value; }
        }

        // Check to see if Severities property is set
        internal bool IsSetSeverities()
        {
            return this._severities != null && (this._severities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}