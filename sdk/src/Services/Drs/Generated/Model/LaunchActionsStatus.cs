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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Launch actions status.
    /// </summary>
    public partial class LaunchActionsStatus
    {
        private List<LaunchActionRun> _runs = new List<LaunchActionRun>();
        private string _ssmAgentDiscoveryDatetime;

        /// <summary>
        /// Gets and sets the property Runs. 
        /// <para>
        /// List of post launch action status.
        /// </para>
        /// </summary>
        public List<LaunchActionRun> Runs
        {
            get { return this._runs; }
            set { this._runs = value; }
        }

        // Check to see if Runs property is set
        internal bool IsSetRuns()
        {
            return this._runs != null && this._runs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SsmAgentDiscoveryDatetime. 
        /// <para>
        /// Time where the AWS Systems Manager was detected as running on the launched instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string SsmAgentDiscoveryDatetime
        {
            get { return this._ssmAgentDiscoveryDatetime; }
            set { this._ssmAgentDiscoveryDatetime = value; }
        }

        // Check to see if SsmAgentDiscoveryDatetime property is set
        internal bool IsSetSsmAgentDiscoveryDatetime()
        {
            return this._ssmAgentDiscoveryDatetime != null;
        }

    }
}