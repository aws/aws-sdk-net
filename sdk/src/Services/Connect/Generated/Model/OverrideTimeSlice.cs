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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// The start time or end time for an hours of operation override.
    /// </summary>
    public partial class OverrideTimeSlice
    {
        private int? _hours;
        private int? _minutes;

        /// <summary>
        /// Gets and sets the property Hours. 
        /// <para>
        /// The hours.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=23)]
        public int? Hours
        {
            get { return this._hours; }
            set { this._hours = value; }
        }

        // Check to see if Hours property is set
        internal bool IsSetHours()
        {
            return this._hours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Minutes. 
        /// <para>
        /// The minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=59)]
        public int? Minutes
        {
            get { return this._minutes; }
            set { this._minutes = value; }
        }

        // Check to see if Minutes property is set
        internal bool IsSetMinutes()
        {
            return this._minutes.HasValue; 
        }

    }
}