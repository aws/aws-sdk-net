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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies configuration properties of a notification.
    /// </summary>
    public partial class NotificationProperty
    {
        /// <summary>
        /// Gets and sets the property NotifyDelayAfter. 
        /// <para>
        /// After a job run starts, the number of minutes to wait before sending a job run delay
        /// notification.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? NotifyDelayAfter { get; set; }

        /// <summary>
        /// Checks to see if the NotifyDelayAfter property is set.
        /// </summary>
        internal bool IsSetNotifyDelayAfter() => this.NotifyDelayAfter.HasValue;
    }
}
