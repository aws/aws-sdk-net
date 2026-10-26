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
    /// Input Loss Behavior
    /// </summary>
    public partial class InputLossBehavior
    {
        /// <summary>
        /// Gets and sets the property BlackFrameMsec. Documentation update needed
        /// </summary>
        public int? BlackFrameMsec { get; set; }

        /// <summary>
        /// Checks to see if the BlackFrameMsec property is set.
        /// </summary>
        internal bool IsSetBlackFrameMsec() => this.BlackFrameMsec.HasValue;

        /// <summary>
        /// Gets and sets the property InputLossImageColor. When input loss image type is "color"
        /// this field specifies the color to use. Value: 6 hex characters representing the values
        /// of RGB.
        /// </summary>
        public string InputLossImageColor { get; set; }

        /// <summary>
        /// Checks to see if the InputLossImageColor property is set.
        /// </summary>
        internal bool IsSetInputLossImageColor() => this.InputLossImageColor != null;

        /// <summary>
        /// Gets and sets the property InputLossImageSlate. When input loss image type is "slate"
        /// these fields specify the parameters for accessing the slate.
        /// </summary>
        public InputLocation InputLossImageSlate { get; set; }

        /// <summary>
        /// Checks to see if the InputLossImageSlate property is set.
        /// </summary>
        internal bool IsSetInputLossImageSlate() => this.InputLossImageSlate != null;

        /// <summary>
        /// Gets and sets the property InputLossImageType. Indicates whether to substitute a solid
        /// color or a slate into the output after input loss exceeds blackFrameMsec.
        /// </summary>
        public InputLossImageType InputLossImageType { get; set; }

        /// <summary>
        /// Checks to see if the InputLossImageType property is set.
        /// </summary>
        internal bool IsSetInputLossImageType() => this.InputLossImageType != null;

        /// <summary>
        /// Gets and sets the property RepeatFrameMsec. Documentation update needed
        /// </summary>
        public int? RepeatFrameMsec { get; set; }

        /// <summary>
        /// Checks to see if the RepeatFrameMsec property is set.
        /// </summary>
        internal bool IsSetRepeatFrameMsec() => this.RepeatFrameMsec.HasValue;
    }
}
