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
 * Do not modify this file. This file is generated from the elementalinference-2018-11-14.normal.json service model.
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
namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// Contains one typed output. It is used in the CreateOutput, GetOutput, and Update Output
    /// structures.
    /// </summary>
    public partial class OutputConfig
    {
        private ClippingConfig _clipping;
        private CroppingConfig _cropping;

        /// <summary>
        /// Gets and sets the property Clipping. 
        /// <para>
        /// The output config type that applies to the clipping feature.
        /// </para>
        /// </summary>
        public ClippingConfig Clipping
        {
            get { return this._clipping; }
            set { this._clipping = value; }
        }

        // Check to see if Clipping property is set
        internal bool IsSetClipping()
        {
            return this._clipping != null;
        }

        /// <summary>
        /// Gets and sets the property Cropping. 
        /// <para>
        /// The output config type that applies to the cropping feature.
        /// </para>
        /// </summary>
        public CroppingConfig Cropping
        {
            get { return this._cropping; }
            set { this._cropping = value; }
        }

        // Check to see if Cropping property is set
        internal bool IsSetCropping()
        {
            return this._cropping != null;
        }

    }
}