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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Adds Q&amp;A capabilities to a dashboard. If no topic is linked, Dashboard Q&amp;A
    /// uses the data values that are rendered on the dashboard. End users can use Dashboard
    /// Q&amp;A to ask for different slices of the data that they see on the dashboard. If
    /// a topic is linked, Topic Q&amp;A is enabled.
    /// </summary>
    public partial class DataQAEnabledOption
    {
        private DashboardBehavior _availabilityStatus;

        /// <summary>
        /// Gets and sets the property AvailabilityStatus. 
        /// <para>
        /// The status of the Data Q&amp;A option on the dashboard.
        /// </para>
        /// </summary>
        public DashboardBehavior AvailabilityStatus
        {
            get { return this._availabilityStatus; }
            set { this._availabilityStatus = value; }
        }

        // Check to see if AvailabilityStatus property is set
        internal bool IsSetAvailabilityStatus()
        {
            return this._availabilityStatus != null;
        }

    }
}