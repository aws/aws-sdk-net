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
    /// Specifies the times when message are allowed to be sent to endpoints.
    /// </summary>
    public partial class OpenHours
    {
        /// <summary>
        /// Gets and sets the property CUSTOM. 
        /// <para>
        /// Specifies the schedule settings for the custom channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<OpenHoursRule>> CUSTOM { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<OpenHoursRule>>() : null;

        /// <summary>
        /// Checks to see if the CUSTOM property is set.
        /// </summary>
        internal bool IsSetCUSTOM() => this.CUSTOM != null && (this.CUSTOM.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EMAIL. 
        /// <para>
        /// Specifies the schedule settings for the email channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<OpenHoursRule>> EMAIL { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<OpenHoursRule>>() : null;

        /// <summary>
        /// Checks to see if the EMAIL property is set.
        /// </summary>
        internal bool IsSetEMAIL() => this.EMAIL != null && (this.EMAIL.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PUSH. 
        /// <para>
        /// Specifies the schedule settings for the push channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<OpenHoursRule>> PUSH { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<OpenHoursRule>>() : null;

        /// <summary>
        /// Checks to see if the PUSH property is set.
        /// </summary>
        internal bool IsSetPUSH() => this.PUSH != null && (this.PUSH.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SMS. 
        /// <para>
        /// Specifies the schedule settings for the SMS channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<OpenHoursRule>> SMS { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<OpenHoursRule>>() : null;

        /// <summary>
        /// Checks to see if the SMS property is set.
        /// </summary>
        internal bool IsSetSMS() => this.SMS != null && (this.SMS.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VOICE. 
        /// <para>
        /// Specifies the schedule settings for the voice channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<OpenHoursRule>> VOICE { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<OpenHoursRule>>() : null;

        /// <summary>
        /// Checks to see if the VOICE property is set.
        /// </summary>
        internal bool IsSetVOICE() => this.VOICE != null && (this.VOICE.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
