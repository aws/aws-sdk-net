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
    /// Contains information on a single schedule action.
    /// </summary>
    public partial class ScheduleAction
    {
        private string _actionName;
        private ScheduleActionSettings _scheduleActionSettings;
        private ScheduleActionStartSettings _scheduleActionStartSettings;

        /// <summary>
        /// Gets and sets the property ActionName. The name of the action, must be unique within
        /// the schedule. This name provides the main reference to an action once it is added
        /// to the schedule. A name is unique if it is no longer in the schedule. The schedule
        /// is automatically cleaned up to remove actions with a start time of more than 1 hour
        /// ago (approximately) so at that point a name can be reused.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ActionName
        {
            get { return this._actionName; }
            set { this._actionName = value; }
        }

        // Check to see if ActionName property is set
        internal bool IsSetActionName()
        {
            return this._actionName != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleActionSettings. Settings for this schedule action.
        /// </summary>
        [AWSProperty(Required=true)]
        public ScheduleActionSettings ScheduleActionSettings
        {
            get { return this._scheduleActionSettings; }
            set { this._scheduleActionSettings = value; }
        }

        // Check to see if ScheduleActionSettings property is set
        internal bool IsSetScheduleActionSettings()
        {
            return this._scheduleActionSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleActionStartSettings. The time for the action to
        /// start in the channel.
        /// </summary>
        [AWSProperty(Required=true)]
        public ScheduleActionStartSettings ScheduleActionStartSettings
        {
            get { return this._scheduleActionStartSettings; }
            set { this._scheduleActionStartSettings = value; }
        }

        // Check to see if ScheduleActionStartSettings property is set
        internal bool IsSetScheduleActionStartSettings()
        {
            return this._scheduleActionStartSettings != null;
        }

    }
}