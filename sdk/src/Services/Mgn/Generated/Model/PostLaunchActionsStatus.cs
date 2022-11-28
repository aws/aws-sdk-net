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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Status of the Post Launch Actions running on the Test or Cutover instance.
    /// </summary>
    public partial class PostLaunchActionsStatus
    {
        private List<JobPostLaunchActionsLaunchStatus> _postLaunchActionsLaunchStatusList = new List<JobPostLaunchActionsLaunchStatus>();
        private string _ssmAgentDiscoveryDatetime;

        /// <summary>
        /// Gets and sets the property PostLaunchActionsLaunchStatusList. 
        /// <para>
        /// List of Post Launch Action status.
        /// </para>
        /// </summary>
        public List<JobPostLaunchActionsLaunchStatus> PostLaunchActionsLaunchStatusList
        {
            get { return this._postLaunchActionsLaunchStatusList; }
            set { this._postLaunchActionsLaunchStatusList = value; }
        }

        // Check to see if PostLaunchActionsLaunchStatusList property is set
        internal bool IsSetPostLaunchActionsLaunchStatusList()
        {
            return this._postLaunchActionsLaunchStatusList != null && this._postLaunchActionsLaunchStatusList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SsmAgentDiscoveryDatetime. 
        /// <para>
        /// Time where the AWS Systems Manager was detected as running on the Test or Cutover
        /// instance.
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