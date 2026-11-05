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

namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// The Resource Groups settings for this Amazon Web Services account.
    /// </summary>
    public partial class AccountSettings
    {
        /// <summary>
        /// Gets and sets the property GroupLifecycleEventsDesiredStatus. 
        /// <para>
        /// The desired target status of the group lifecycle events feature. If
        /// </para>
        /// </summary>
        public GroupLifecycleEventsDesiredStatus GroupLifecycleEventsDesiredStatus { get; set; }

        /// <summary>
        /// Checks to see if the GroupLifecycleEventsDesiredStatus property is set.
        /// </summary>
        internal bool IsSetGroupLifecycleEventsDesiredStatus() => this.GroupLifecycleEventsDesiredStatus != null;

        /// <summary>
        /// Gets and sets the property GroupLifecycleEventsStatus. 
        /// <para>
        /// The current status of the group lifecycle events feature.
        /// </para>
        /// </summary>
        public GroupLifecycleEventsStatus GroupLifecycleEventsStatus { get; set; }

        /// <summary>
        /// Checks to see if the GroupLifecycleEventsStatus property is set.
        /// </summary>
        internal bool IsSetGroupLifecycleEventsStatus() => this.GroupLifecycleEventsStatus != null;

        /// <summary>
        /// Gets and sets the property GroupLifecycleEventsStatusMessage. 
        /// <para>
        /// The text of any error message occurs during an attempt to turn group lifecycle events
        /// on or off.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string GroupLifecycleEventsStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the GroupLifecycleEventsStatusMessage property is set.
        /// </summary>
        internal bool IsSetGroupLifecycleEventsStatusMessage() => this.GroupLifecycleEventsStatusMessage != null;
    }
}
