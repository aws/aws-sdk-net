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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProgram operation.
    /// Updates a program within a channel.
    /// </summary>
    public partial class UpdateProgramRequest : AmazonMediaTailorRequest
    {
        private List<AdBreak> _adBreaks = new List<AdBreak>();
        private string _channelName;
        private string _programName;
        private UpdateProgramScheduleConfiguration _scheduleConfiguration;

        /// <summary>
        /// Gets and sets the property AdBreaks. 
        /// <para>
        /// The ad break configuration settings.
        /// </para>
        /// </summary>
        public List<AdBreak> AdBreaks
        {
            get { return this._adBreaks; }
            set { this._adBreaks = value; }
        }

        // Check to see if AdBreaks property is set
        internal bool IsSetAdBreaks()
        {
            return this._adBreaks != null && this._adBreaks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel for this Program.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ChannelName
        {
            get { return this._channelName; }
            set { this._channelName = value; }
        }

        // Check to see if ChannelName property is set
        internal bool IsSetChannelName()
        {
            return this._channelName != null;
        }

        /// <summary>
        /// Gets and sets the property ProgramName. 
        /// <para>
        /// The name of the Program.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProgramName
        {
            get { return this._programName; }
            set { this._programName = value; }
        }

        // Check to see if ProgramName property is set
        internal bool IsSetProgramName()
        {
            return this._programName != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleConfiguration. 
        /// <para>
        /// The schedule configuration settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateProgramScheduleConfiguration ScheduleConfiguration
        {
            get { return this._scheduleConfiguration; }
            set { this._scheduleConfiguration = value; }
        }

        // Check to see if ScheduleConfiguration property is set
        internal bool IsSetScheduleConfiguration()
        {
            return this._scheduleConfiguration != null;
        }

    }
}