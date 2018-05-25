/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies configuration properties of a notification.
    /// </summary>
    public partial class NotificationProperty
    {
        private int? _notifyDelayAfter;

        /// <summary>
        /// Gets and sets the property NotifyDelayAfter. 
        /// <para>
        /// After a job run starts, the number of minutes to wait before sending a job run delay
        /// notification.
        /// </para>
        /// </summary>
        public int NotifyDelayAfter
        {
            get { return this._notifyDelayAfter.GetValueOrDefault(); }
            set { this._notifyDelayAfter = value; }
        }

        // Check to see if NotifyDelayAfter property is set
        internal bool IsSetNotifyDelayAfter()
        {
            return this._notifyDelayAfter.HasValue; 
        }

    }
}