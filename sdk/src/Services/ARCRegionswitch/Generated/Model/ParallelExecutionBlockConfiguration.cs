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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Configuration for steps that should be executed in parallel during a Region switch.
    /// </summary>
    public partial class ParallelExecutionBlockConfiguration
    {
        private List<Step> _steps = AWSConfigs.InitializeCollections ? new List<Step>() : null;

        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// The steps for a parallel execution block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Step> Steps
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