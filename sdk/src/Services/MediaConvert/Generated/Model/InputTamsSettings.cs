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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Specify a Time Addressable Media Store (TAMS) server as an input source. TAMS is an
    /// open-source API specification that provides access to time-segmented media content.
    /// Use TAMS to retrieve specific time ranges from live or archived media streams. When
    /// you specify TAMS settings, MediaConvert connects to your TAMS server, retrieves the
    /// media segments for your specified time range, and processes them as a single input.
    /// This enables workflows like extracting clips from live streams or processing specific
    /// portions of archived content. To use TAMS, you must: 1. Have access to a TAMS-compliant
    /// server 2. Specify the server URL in the Input file URL field 3. Provide the required
    /// SourceId and Timerange parameters 4. Configure authentication, if your TAMS server
    /// requires it
    /// </summary>
    public partial class InputTamsSettings
    {
        private string _authConnectionArn;
        private TamsGapHandling _gapHandling;
        private string _sourceId;
        private string _timerange;

        /// <summary>
        /// Gets and sets the property AuthConnectionArn. Specify the ARN (Amazon Resource Name)
        /// of an EventBridge Connection to authenticate with your TAMS server. The EventBridge
        /// Connection stores your authentication credentials securely. MediaConvert assumes your
        /// job's IAM role to access this connection, so ensure the role has the events:RetrieveConnectionCredentials,
        /// secretsmanager:DescribeSecret, and secretsmanager:GetSecretValue permissions. Format:
        /// arn:aws:events:region:account-id:connection/connection-name/unique-id This setting
        /// is required when you include TAMS settings in your job.
        /// </summary>
        public string AuthConnectionArn
        {
            get { return this._authConnectionArn; }
            set { this._authConnectionArn = value; }
        }

        // Check to see if AuthConnectionArn property is set
        internal bool IsSetAuthConnectionArn()
        {
            return this._authConnectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property GapHandling. Specify how MediaConvert handles gaps between
        /// media segments in your TAMS source. Gaps can occur in live streams due to network
        /// issues or other interruptions. Choose from the following options: * Skip gaps - Default.
        /// Skip over gaps and join segments together. This creates a continuous output with no
        /// blank frames, but may cause timeline discontinuities. * Fill with black - Insert black
        /// frames to fill gaps between segments. This maintains timeline continuity but adds
        /// black frames where content is missing. * Hold last frame - Repeat the last frame before
        /// a gap until the next segment begins. This maintains visual continuity during gaps.
        /// </summary>
        public TamsGapHandling GapHandling
        {
            get { return this._gapHandling; }
            set { this._gapHandling = value; }
        }

        // Check to see if GapHandling property is set
        internal bool IsSetGapHandling()
        {
            return this._gapHandling != null;
        }

        /// <summary>
        /// Gets and sets the property SourceId. Specify the unique identifier for the media source
        /// in your TAMS server. MediaConvert uses this source ID to locate the appropriate flows
        /// containing the media segments you want to process. The source ID corresponds to a
        /// specific media source registered in your TAMS server. This source must be of type
        /// urn:x-nmos:format:multi, and can can reference multiple flows for audio, video, or
        /// combined audio/video content. MediaConvert automatically selects the highest quality
        /// flows available for your job. This setting is required when you include TAMS settings
        /// in your job.
        /// </summary>
        public string SourceId
        {
            get { return this._sourceId; }
            set { this._sourceId = value; }
        }

        // Check to see if SourceId property is set
        internal bool IsSetSourceId()
        {
            return this._sourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Timerange. Specify the time range of media segments to
        /// retrieve from your TAMS server. MediaConvert fetches only the segments that fall within
        /// this range. Use the format specified by your TAMS server implementation. This must
        /// be two timestamp values with the format {sign?}{seconds}:{nanoseconds}, separated
        /// by an underscore, surrounded by either parentheses or square brackets.  Example: [15:0_35:0)
        /// This setting is required when you include TAMS settings in your job.
        /// </summary>
        public string Timerange
        {
            get { return this._timerange; }
            set { this._timerange = value; }
        }

        // Check to see if Timerange property is set
        internal bool IsSetTimerange()
        {
            return this._timerange != null;
        }

    }
}