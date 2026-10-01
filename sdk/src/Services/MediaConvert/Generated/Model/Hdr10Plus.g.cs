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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Setting for HDR10+ metadata insertion
    /// </summary>
    public partial class Hdr10Plus
    {
        /// <summary>
        /// Gets and sets the property MasteringMonitorNits. Specify the HDR10+ mastering display
        /// normalized peak luminance, in nits. This is the normalized actual peak luminance of
        /// the mastering display, as defined by ST 2094-40.
        /// </summary>
        [AWSProperty(Min = 0, Max = 4000)]
        public int? MasteringMonitorNits { get; set; }

        /// <summary>
        /// Checks to see if the MasteringMonitorNits property is set.
        /// </summary>
        internal bool IsSetMasteringMonitorNits() => this.MasteringMonitorNits.HasValue;

        /// <summary>
        /// Gets and sets the property TargetMonitorNits. Specify the HDR10+ target display nominal
        /// peak luminance, in nits. This is the nominal maximum luminance of the target display
        /// as defined by ST 2094-40.
        /// </summary>
        [AWSProperty(Min = 0, Max = 4000)]
        public int? TargetMonitorNits { get; set; }

        /// <summary>
        /// Checks to see if the TargetMonitorNits property is set.
        /// </summary>
        internal bool IsSetTargetMonitorNits() => this.TargetMonitorNits.HasValue;
    }
}
