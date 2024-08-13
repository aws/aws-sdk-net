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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
        private int? _blackFrameMsec;
        private string _inputLossImageColor;
        private InputLocation _inputLossImageSlate;
        private InputLossImageType _inputLossImageType;
        private int? _repeatFrameMsec;

        /// <summary>
        /// Gets and sets the property BlackFrameMsec. Documentation update needed
        /// </summary>
        [AWSProperty(Min=0, Max=1000000)]
        public int? BlackFrameMsec
        {
            get { return this._blackFrameMsec; }
            set { this._blackFrameMsec = value; }
        }

        // Check to see if BlackFrameMsec property is set
        internal bool IsSetBlackFrameMsec()
        {
            return this._blackFrameMsec.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputLossImageColor. When input loss image type is "color"
        /// this field specifies the color to use. Value: 6 hex characters representing the values
        /// of RGB.
        /// </summary>
        [AWSProperty(Min=6, Max=6)]
        public string InputLossImageColor
        {
            get { return this._inputLossImageColor; }
            set { this._inputLossImageColor = value; }
        }

        // Check to see if InputLossImageColor property is set
        internal bool IsSetInputLossImageColor()
        {
            return this._inputLossImageColor != null;
        }

        /// <summary>
        /// Gets and sets the property InputLossImageSlate. When input loss image type is "slate"
        /// these fields specify the parameters for accessing the slate.
        /// </summary>
        public InputLocation InputLossImageSlate
        {
            get { return this._inputLossImageSlate; }
            set { this._inputLossImageSlate = value; }
        }

        // Check to see if InputLossImageSlate property is set
        internal bool IsSetInputLossImageSlate()
        {
            return this._inputLossImageSlate != null;
        }

        /// <summary>
        /// Gets and sets the property InputLossImageType. Indicates whether to substitute a solid
        /// color or a slate into the output after input loss exceeds blackFrameMsec.
        /// </summary>
        public InputLossImageType InputLossImageType
        {
            get { return this._inputLossImageType; }
            set { this._inputLossImageType = value; }
        }

        // Check to see if InputLossImageType property is set
        internal bool IsSetInputLossImageType()
        {
            return this._inputLossImageType != null;
        }

        /// <summary>
        /// Gets and sets the property RepeatFrameMsec. Documentation update needed
        /// </summary>
        [AWSProperty(Min=0, Max=1000000)]
        public int? RepeatFrameMsec
        {
            get { return this._repeatFrameMsec; }
            set { this._repeatFrameMsec = value; }
        }

        // Check to see if RepeatFrameMsec property is set
        internal bool IsSetRepeatFrameMsec()
        {
            return this._repeatFrameMsec.HasValue; 
        }

    }
}