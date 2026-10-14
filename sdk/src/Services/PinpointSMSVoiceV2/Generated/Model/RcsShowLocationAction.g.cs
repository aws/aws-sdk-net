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
    /// A suggested action that shows a location on a map when tapped by the recipient.
    /// </summary>
    public partial class RcsShowLocationAction
    {
        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// An optional label for the location pin. Maximum 100 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property Latitude. 
        /// <para>
        /// The latitude of the location. Valid values are -90 to 90.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = -90, Max = 90)]
        public double? Latitude { get; set; }

        /// <summary>
        /// Checks to see if the Latitude property is set.
        /// </summary>
        internal bool IsSetLatitude() => this.Latitude.HasValue;

        /// <summary>
        /// Gets and sets the property Longitude. 
        /// <para>
        /// The longitude of the location. Valid values are -180 to 180.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = -180, Max = 180)]
        public double? Longitude { get; set; }

        /// <summary>
        /// Checks to see if the Longitude property is set.
        /// </summary>
        internal bool IsSetLongitude() => this.Longitude.HasValue;

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
    }
}
