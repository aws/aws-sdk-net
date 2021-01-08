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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Information about worlds that finished.
    /// </summary>
    public partial class FinishedWorldsSummary
    {
        private FailureSummary _failureSummary;
        private int? _finishedCount;
        private List<string> _succeededWorlds = new List<string>();

        /// <summary>
        /// Gets and sets the property FailureSummary. 
        /// <para>
        /// Information about worlds that failed.
        /// </para>
        /// </summary>
        public FailureSummary FailureSummary
        {
            get { return this._failureSummary; }
            set { this._failureSummary = value; }
        }

        // Check to see if FailureSummary property is set
        internal bool IsSetFailureSummary()
        {
            return this._failureSummary != null;
        }

        /// <summary>
        /// Gets and sets the property FinishedCount. 
        /// <para>
        /// The total number of finished worlds.
        /// </para>
        /// </summary>
        public int FinishedCount
        {
            get { return this._finishedCount.GetValueOrDefault(); }
            set { this._finishedCount = value; }
        }

        // Check to see if FinishedCount property is set
        internal bool IsSetFinishedCount()
        {
            return this._finishedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SucceededWorlds. 
        /// <para>
        /// A list of worlds that succeeded.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> SucceededWorlds
        {
            get { return this._succeededWorlds; }
            set { this._succeededWorlds = value; }
        }

        // Check to see if SucceededWorlds property is set
        internal bool IsSetSucceededWorlds()
        {
            return this._succeededWorlds != null && this._succeededWorlds.Count > 0; 
        }

    }
}