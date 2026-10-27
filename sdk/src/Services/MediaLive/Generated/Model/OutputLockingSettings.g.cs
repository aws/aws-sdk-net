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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Output Locking Settings
    /// </summary>
    public partial class OutputLockingSettings
    {
        /// <summary>
        /// Gets and sets the property DisabledLockingSettings.
        /// </summary>
        public DisabledLockingSettings DisabledLockingSettings { get; set; }

        /// <summary>
        /// Checks to see if the DisabledLockingSettings property is set.
        /// </summary>
        internal bool IsSetDisabledLockingSettings() => this.DisabledLockingSettings != null;

        /// <summary>
        /// Gets and sets the property EpochLockingSettings.
        /// </summary>
        public EpochLockingSettings EpochLockingSettings { get; set; }

        /// <summary>
        /// Checks to see if the EpochLockingSettings property is set.
        /// </summary>
        internal bool IsSetEpochLockingSettings() => this.EpochLockingSettings != null;

        /// <summary>
        /// Gets and sets the property PipelineLockingSettings.
        /// </summary>
        public PipelineLockingSettings PipelineLockingSettings { get; set; }

        /// <summary>
        /// Checks to see if the PipelineLockingSettings property is set.
        /// </summary>
        internal bool IsSetPipelineLockingSettings() => this.PipelineLockingSettings != null;
    }
}
