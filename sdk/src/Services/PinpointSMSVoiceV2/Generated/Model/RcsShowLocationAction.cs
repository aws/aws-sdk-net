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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
        private string _label;
        private double? _latitude;
        private double? _longitude;
        private string _postbackData;
        private string _text;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// An optional label for the location pin. Maximum 100 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property Latitude. 
        /// <para>
        /// The latitude of the location. Valid values are -90 to 90.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=-90, Max=90)]
        public double? Latitude
        {
            get { return this._latitude; }
            set { this._latitude = value; }
        }

        // Check to see if Latitude property is set
        internal bool IsSetLatitude()
        {
            return this._latitude.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Longitude. 
        /// <para>
        /// The longitude of the location. Valid values are -180 to 180.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=-180, Max=180)]
        public double? Longitude
        {
            get { return this._longitude; }
            set { this._longitude = value; }
        }

        // Check to see if Longitude property is set
        internal bool IsSetLongitude()
        {
            return this._longitude.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PostbackData. 
        /// <para>
        /// The postback data sent to your webhook when the user taps this action. Maximum 2048
        /// characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string PostbackData
        {
            get { return this._postbackData; }
            set { this._postbackData = value; }
        }

        // Check to see if PostbackData property is set
        internal bool IsSetPostbackData()
        {
            return this._postbackData != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The display text of the action. Maximum 25 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}