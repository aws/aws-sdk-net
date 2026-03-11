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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Contains the count of guest users for a specific billing period, used for tracking
    /// historical guest user activity.
    /// </summary>
    public partial class GuestUserHistoryCount
    {
        private string _count;
        private string _month;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of guest users who have communicated with your Wickr network during this
        /// billing period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count != null;
        }

        /// <summary>
        /// Gets and sets the property Month. 
        /// <para>
        /// The month and billing period in YYYY_MM format (e.g., '2024_01').
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Month
        {
            get { return this._month; }
            set { this._month = value; }
        }

        // Check to see if Month property is set
        internal bool IsSetMonth()
        {
            return this._month != null;
        }

    }
}