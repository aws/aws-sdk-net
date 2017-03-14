/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// This parameter contains the criteria (either InstanceIds or a tag) used to specify
    /// which EC2 instances are to be sent the command.
    /// </summary>
    public partial class RunCommandParameters
    {
        private List<RunCommandTarget> _runCommandTargets = new List<RunCommandTarget>();

        /// <summary>
        /// Gets and sets the property RunCommandTargets. 
        /// <para>
        /// Currently, we support including only one RunCommandTarget block, which specifies either
        /// an array of InstanceIds or a tag.
        /// </para>
        /// </summary>
        public List<RunCommandTarget> RunCommandTargets
        {
            get { return this._runCommandTargets; }
            set { this._runCommandTargets = value; }
        }

        // Check to see if RunCommandTargets property is set
        internal bool IsSetRunCommandTargets()
        {
            return this._runCommandTargets != null && this._runCommandTargets.Count > 0; 
        }

    }
}