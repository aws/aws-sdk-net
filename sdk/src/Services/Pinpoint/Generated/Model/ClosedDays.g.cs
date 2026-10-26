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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// The time when a journey will not send messages. QuietTime should be configured first
    /// and SendingSchedule should be set to true.
    /// </summary>
    public partial class ClosedDays
    {
        /// <summary>
        /// Gets and sets the property CUSTOM. 
        /// <para>
        /// Rules for the Custom channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClosedDaysRule> CUSTOM { get; set; } = AWSConfigs.InitializeCollections ? new List<ClosedDaysRule>() : null;

        /// <summary>
        /// Checks to see if the CUSTOM property is set.
        /// </summary>
        internal bool IsSetCUSTOM() => this.CUSTOM != null && (this.CUSTOM.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EMAIL. 
        /// <para>
        /// Rules for the Email channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClosedDaysRule> EMAIL { get; set; } = AWSConfigs.InitializeCollections ? new List<ClosedDaysRule>() : null;

        /// <summary>
        /// Checks to see if the EMAIL property is set.
        /// </summary>
        internal bool IsSetEMAIL() => this.EMAIL != null && (this.EMAIL.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PUSH. 
        /// <para>
        /// Rules for the Push channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClosedDaysRule> PUSH { get; set; } = AWSConfigs.InitializeCollections ? new List<ClosedDaysRule>() : null;

        /// <summary>
        /// Checks to see if the PUSH property is set.
        /// </summary>
        internal bool IsSetPUSH() => this.PUSH != null && (this.PUSH.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SMS. 
        /// <para>
        /// Rules for the SMS channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClosedDaysRule> SMS { get; set; } = AWSConfigs.InitializeCollections ? new List<ClosedDaysRule>() : null;

        /// <summary>
        /// Checks to see if the SMS property is set.
        /// </summary>
        internal bool IsSetSMS() => this.SMS != null && (this.SMS.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VOICE. 
        /// <para>
        /// Rules for the Voice channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClosedDaysRule> VOICE { get; set; } = AWSConfigs.InitializeCollections ? new List<ClosedDaysRule>() : null;

        /// <summary>
        /// Checks to see if the VOICE property is set.
        /// </summary>
        internal bool IsSetVOICE() => this.VOICE != null && (this.VOICE.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
