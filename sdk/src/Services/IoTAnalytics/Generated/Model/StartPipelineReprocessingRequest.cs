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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the StartPipelineReprocessing operation.
    /// Starts the reprocessing of raw message data through the pipeline.
    /// </summary>
    public partial class StartPipelineReprocessingRequest : AmazonIoTAnalyticsRequest
    {
        private ChannelMessages _channelMessages;
        private DateTime? _endTime;
        private string _pipelineName;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property ChannelMessages. 
        /// <para>
        /// Specifies one or more sets of channel messages that you want to reprocess.
        /// </para>
        ///  
        /// <para>
        /// If you use the <c>channelMessages</c> object, you must not specify a value for <c>startTime</c>
        /// and <c>endTime</c>.
        /// </para>
        /// </summary>
        public ChannelMessages ChannelMessages
        {
            get { return this._channelMessages; }
            set { this._channelMessages = value; }
        }

        // Check to see if ChannelMessages property is set
        internal bool IsSetChannelMessages()
        {
            return this._channelMessages != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time (exclusive) of raw message data that is reprocessed.
        /// </para>
        ///  
        /// <para>
        /// If you specify a value for the <c>endTime</c> parameter, you must not use the <c>channelMessages</c>
        /// object.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline on which to start reprocessing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string PipelineName
        {
            get { return this._pipelineName; }
            set { this._pipelineName = value; }
        }

        // Check to see if PipelineName property is set
        internal bool IsSetPipelineName()
        {
            return this._pipelineName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time (inclusive) of raw message data that is reprocessed.
        /// </para>
        ///  
        /// <para>
        /// If you specify a value for the <c>startTime</c> parameter, you must not use the <c>channelMessages</c>
        /// object.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}