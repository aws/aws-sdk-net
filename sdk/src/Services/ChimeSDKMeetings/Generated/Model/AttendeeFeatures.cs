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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
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
namespace Amazon.ChimeSDKMeetings.Model
{
    /// <summary>
    /// Lists the maximum number of attendees allowed into the meeting.
    /// 
    ///  <note> 
    /// <para>
    /// If you specify <c>FHD</c> for <c>MeetingFeatures:Video:MaxResolution</c>, or if you
    /// specify <c>UHD</c> for <c>MeetingFeatures:Content:MaxResolution</c>, the maximum number
    /// of attendees changes from the default of <c>250</c> to <c>25</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AttendeeFeatures
    {
        private int? _maxCount;

        /// <summary>
        /// Gets and sets the property MaxCount. 
        /// <para>
        /// The maximum number of attendees allowed into the meeting.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public int? MaxCount
        {
            get { return this._maxCount; }
            set { this._maxCount = value; }
        }

        // Check to see if MaxCount property is set
        internal bool IsSetMaxCount()
        {
            return this._maxCount.HasValue; 
        }

    }
}