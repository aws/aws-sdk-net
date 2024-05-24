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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies a duration or a date and time that indicates when Amazon Pinpoint determines
    /// whether an activity's conditions have been met or an activity moves participants to
    /// the next activity in a journey.
    /// </summary>
    public partial class WaitTime
    {
        private string _waitFor;
        private string _waitUntil;

        /// <summary>
        /// Gets and sets the property WaitFor. 
        /// <para>
        /// The amount of time to wait, as a duration in ISO 8601 format, before determining whether
        /// the activity's conditions have been met or moving participants to the next activity
        /// in the journey.
        /// </para>
        /// </summary>
        public string WaitFor
        {
            get { return this._waitFor; }
            set { this._waitFor = value; }
        }

        // Check to see if WaitFor property is set
        internal bool IsSetWaitFor()
        {
            return this._waitFor != null;
        }

        /// <summary>
        /// Gets and sets the property WaitUntil. 
        /// <para>
        /// The date and time, in ISO 8601 format, when Amazon Pinpoint determines whether the
        /// activity's conditions have been met or the activity moves participants to the next
        /// activity in the journey.
        /// </para>
        /// </summary>
        public string WaitUntil
        {
            get { return this._waitUntil; }
            set { this._waitUntil = value; }
        }

        // Check to see if WaitUntil property is set
        internal bool IsSetWaitUntil()
        {
            return this._waitUntil != null;
        }

    }
}