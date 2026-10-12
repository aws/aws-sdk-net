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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// A suggested action that creates a calendar event on the recipient's device.
    /// </summary>
    public partial class RcsCreateCalendarEventAction
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the calendar event. Maximum 500 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the calendar event in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property PostbackData. 
        /// <para>
        /// The postback data sent to your webhook when the user taps this action. Maximum 2048
        /// characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PostbackData { get; set; }

        /// <summary>
        /// Checks to see if the PostbackData property is set.
        /// </summary>
        internal bool IsSetPostbackData() => this.PostbackData != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the calendar event in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The display text of the action. Maximum 25 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 25)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the calendar event. Maximum 100 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
