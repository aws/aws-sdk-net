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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// The Resource Groups settings for this Amazon Web Services account.
    /// </summary>
    public partial class AccountSettings
    {
        private GroupLifecycleEventsDesiredStatus _groupLifecycleEventsDesiredStatus;
        private GroupLifecycleEventsStatus _groupLifecycleEventsStatus;
        private string _groupLifecycleEventsStatusMessage;

        /// <summary>
        /// Gets and sets the property GroupLifecycleEventsDesiredStatus. 
        /// <para>
        /// The desired target status of the group lifecycle events feature. If
        /// </para>
        /// </summary>
        public GroupLifecycleEventsDesiredStatus GroupLifecycleEventsDesiredStatus
        {
            get { return this._groupLifecycleEventsDesiredStatus; }
            set { this._groupLifecycleEventsDesiredStatus = value; }
        }

        // Check to see if GroupLifecycleEventsDesiredStatus property is set
        internal bool IsSetGroupLifecycleEventsDesiredStatus()
        {
            return this._groupLifecycleEventsDesiredStatus != null;
        }

        /// <summary>
        /// Gets and sets the property GroupLifecycleEventsStatus. 
        /// <para>
        /// The current status of the group lifecycle events feature.
        /// </para>
        /// </summary>
        public GroupLifecycleEventsStatus GroupLifecycleEventsStatus
        {
            get { return this._groupLifecycleEventsStatus; }
            set { this._groupLifecycleEventsStatus = value; }
        }

        // Check to see if GroupLifecycleEventsStatus property is set
        internal bool IsSetGroupLifecycleEventsStatus()
        {
            return this._groupLifecycleEventsStatus != null;
        }

        /// <summary>
        /// Gets and sets the property GroupLifecycleEventsStatusMessage. 
        /// <para>
        /// The text of any error message occurs during an attempt to turn group lifecycle events
        /// on or off.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string GroupLifecycleEventsStatusMessage
        {
            get { return this._groupLifecycleEventsStatusMessage; }
            set { this._groupLifecycleEventsStatusMessage = value; }
        }

        // Check to see if GroupLifecycleEventsStatusMessage property is set
        internal bool IsSetGroupLifecycleEventsStatusMessage()
        {
            return this._groupLifecycleEventsStatusMessage != null;
        }

    }
}