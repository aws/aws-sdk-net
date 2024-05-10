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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
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
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// An array of structures that define the traffic allocation percentages among the feature
    /// variations during each step of a launch. This also defines the start time of each
    /// step.
    /// </summary>
    public partial class ScheduledSplitsLaunchDefinition
    {
        private List<ScheduledSplit> _steps = AWSConfigs.InitializeCollections ? new List<ScheduledSplit>() : null;

        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// An array of structures that define the traffic allocation percentages among the feature
        /// variations during each step of the launch. This also defines the start time of each
        /// step.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
        public List<ScheduledSplit> Steps
        {
            get { return this._steps; }
            set { this._steps = value; }
        }

        // Check to see if Steps property is set
        internal bool IsSetSteps()
        {
            return this._steps != null && (this._steps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}