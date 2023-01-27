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
    /// Container for the parameters to the UpdateAccountSettings operation.
    /// Turns on or turns off optional features in Resource Groups.
    /// 
    ///  
    /// <para>
    /// The preceding example shows that the request to turn on group lifecycle events is
    /// <code>IN_PROGRESS</code>. You can call the <a>GetAccountSettings</a> operation to
    /// check for completion by looking for <code>GroupLifecycleEventsStatus</code> to change
    /// to <code>ACTIVE</code>.
    /// </para>
    /// </summary>
    public partial class UpdateAccountSettingsRequest : AmazonResourceGroupsRequest
    {
        private GroupLifecycleEventsDesiredStatus _groupLifecycleEventsDesiredStatus;

        /// <summary>
        /// Gets and sets the property GroupLifecycleEventsDesiredStatus. 
        /// <para>
        /// Specifies whether you want to turn <a href="https://docs.aws.amazon.com/ARG/latest/userguide/monitor-groups.html">group
        /// lifecycle events</a> on or off.
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

    }
}