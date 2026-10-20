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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Specifies the allowed input types.
    /// </summary>
    public partial class AllowedInputTypes
    {
        /// <summary>
        /// Gets and sets the property AllowAudioInput. 
        /// <para>
        /// Indicates whether audio input is allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? AllowAudioInput { get; set; }

        /// <summary>
        /// Checks to see if the AllowAudioInput property is set.
        /// </summary>
        internal bool IsSetAllowAudioInput() => this.AllowAudioInput.HasValue;

        /// <summary>
        /// Gets and sets the property AllowDTMFInput. 
        /// <para>
        /// Indicates whether DTMF input is allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? AllowDTMFInput { get; set; }

        /// <summary>
        /// Checks to see if the AllowDTMFInput property is set.
        /// </summary>
        internal bool IsSetAllowDTMFInput() => this.AllowDTMFInput.HasValue;
    }
}
