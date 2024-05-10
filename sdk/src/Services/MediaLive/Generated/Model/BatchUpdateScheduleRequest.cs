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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the BatchUpdateSchedule operation.
    /// Update a channel schedule
    /// </summary>
    public partial class BatchUpdateScheduleRequest : AmazonMediaLiveRequest
    {
        private string _channelId;
        private BatchScheduleActionCreateRequest _creates;
        private BatchScheduleActionDeleteRequest _deletes;

        /// <summary>
        /// Gets and sets the property ChannelId. Id of the channel whose schedule is being updated.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ChannelId
        {
            get { return this._channelId; }
            set { this._channelId = value; }
        }

        // Check to see if ChannelId property is set
        internal bool IsSetChannelId()
        {
            return this._channelId != null;
        }

        /// <summary>
        /// Gets and sets the property Creates. Schedule actions to create in the schedule.
        /// </summary>
        public BatchScheduleActionCreateRequest Creates
        {
            get { return this._creates; }
            set { this._creates = value; }
        }

        // Check to see if Creates property is set
        internal bool IsSetCreates()
        {
            return this._creates != null;
        }

        /// <summary>
        /// Gets and sets the property Deletes. Schedule actions to delete from the schedule.
        /// </summary>
        public BatchScheduleActionDeleteRequest Deletes
        {
            get { return this._deletes; }
            set { this._deletes = value; }
        }

        // Check to see if Deletes property is set
        internal bool IsSetDeletes()
        {
            return this._deletes != null;
        }

    }
}