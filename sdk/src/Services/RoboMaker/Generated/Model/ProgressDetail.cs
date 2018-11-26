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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Information about the progress of a deployment job.
    /// </summary>
    public partial class ProgressDetail
    {
        private string _currentProgress;
        private string _targetResource;

        /// <summary>
        /// Gets and sets the property CurrentProgress. 
        /// <para>
        /// The current progress status.
        /// </para>
        /// </summary>
        public string CurrentProgress
        {
            get { return this._currentProgress; }
            set { this._currentProgress = value; }
        }

        // Check to see if CurrentProgress property is set
        internal bool IsSetCurrentProgress()
        {
            return this._currentProgress != null;
        }

        /// <summary>
        /// Gets and sets the property TargetResource. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the deployment job.
        /// </para>
        /// </summary>
        public string TargetResource
        {
            get { return this._targetResource; }
            set { this._targetResource = value; }
        }

        // Check to see if TargetResource property is set
        internal bool IsSetTargetResource()
        {
            return this._targetResource != null;
        }

    }
}