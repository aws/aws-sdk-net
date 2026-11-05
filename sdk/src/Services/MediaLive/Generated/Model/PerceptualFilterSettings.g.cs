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
    /// Perceptual Filter Settings
    /// </summary>
    public partial class PerceptualFilterSettings
    {
        /// <summary>
        /// Gets and sets the property Strength. Selects the perceptual noise filter strength.
        /// Strength 1 (perceptual lite) is the recommended default and adds approximately 30%
        /// of an AVC encode of compute on the highest rendition. Strength 2 adds approximately
        /// 60% of an AVC encode of compute and can introduce slight softening on noisy content.
        /// </summary>
        [AWSProperty(Required = true)]
        public PerceptualFilterStrength Strength { get; set; }

        /// <summary>
        /// Checks to see if the Strength property is set.
        /// </summary>
        internal bool IsSetStrength() => this.Strength != null;
    }
}
