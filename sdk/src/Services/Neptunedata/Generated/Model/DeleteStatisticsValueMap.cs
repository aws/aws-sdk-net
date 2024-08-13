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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
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
namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// The payload for DeleteStatistics.
    /// </summary>
    public partial class DeleteStatisticsValueMap
    {
        private bool? _active;
        private string _statisticsId;

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// The current status of the statistics.
        /// </para>
        /// </summary>
        public bool? Active
        {
            get { return this._active; }
            set { this._active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this._active.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatisticsId. 
        /// <para>
        /// The ID of the statistics generation run that is currently occurring.
        /// </para>
        /// </summary>
        public string StatisticsId
        {
            get { return this._statisticsId; }
            set { this._statisticsId = value; }
        }

        // Check to see if StatisticsId property is set
        internal bool IsSetStatisticsId()
        {
            return this._statisticsId != null;
        }

    }
}