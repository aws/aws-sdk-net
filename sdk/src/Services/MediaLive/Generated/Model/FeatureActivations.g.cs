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
    /// Feature Activations
    /// </summary>
    public partial class FeatureActivations
    {
        /// <summary>
        /// Gets and sets the property InputPrepareScheduleActions. Enables the Input Prepare
        /// feature. You can create Input Prepare actions in the schedule only if this feature
        /// is enabled. If you disable the feature on an existing schedule, make sure that you
        /// first delete all input prepare actions from the schedule.
        /// </summary>
        public FeatureActivationsInputPrepareScheduleActions InputPrepareScheduleActions { get; set; }

        /// <summary>
        /// Checks to see if the InputPrepareScheduleActions property is set.
        /// </summary>
        internal bool IsSetInputPrepareScheduleActions() => this.InputPrepareScheduleActions != null;

        /// <summary>
        /// Gets and sets the property OutputStaticImageOverlayScheduleActions. Enables the output
        /// static image overlay feature. Enabling this feature allows you to send channel schedule
        /// updates to display/clear/modify image overlays on an output-by-output bases.
        /// </summary>
        public FeatureActivationsOutputStaticImageOverlayScheduleActions OutputStaticImageOverlayScheduleActions { get; set; }

        /// <summary>
        /// Checks to see if the OutputStaticImageOverlayScheduleActions property is set.
        /// </summary>
        internal bool IsSetOutputStaticImageOverlayScheduleActions() => this.OutputStaticImageOverlayScheduleActions != null;
    }
}
