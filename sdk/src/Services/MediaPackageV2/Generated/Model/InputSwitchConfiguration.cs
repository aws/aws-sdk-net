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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// The configuration for input switching based on the media quality confidence score
    /// (MQCS) as provided from AWS Elemental MediaLive.
    /// </summary>
    public partial class InputSwitchConfiguration
    {
        private bool? _mqcsInputSwitching;
        private int? _preferredInput;

        /// <summary>
        /// Gets and sets the property MQCSInputSwitching. 
        /// <para>
        /// When true, AWS Elemental MediaPackage performs input switching based on the MQCS.
        /// Default is true. This setting is valid only when <c>InputType</c> is <c>CMAF</c>.
        /// </para>
        /// </summary>
        public bool? MQCSInputSwitching
        {
            get { return this._mqcsInputSwitching; }
            set { this._mqcsInputSwitching = value; }
        }

        // Check to see if MQCSInputSwitching property is set
        internal bool IsSetMQCSInputSwitching()
        {
            return this._mqcsInputSwitching.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreferredInput. 
        /// <para>
        /// For CMAF inputs, indicates which input MediaPackage should prefer when both inputs
        /// have equal MQCS scores. Select <c>1</c> to prefer the first ingest endpoint, or <c>2</c>
        /// to prefer the second ingest endpoint. If you don't specify a preferred input, MediaPackage
        /// uses its default switching behavior when MQCS scores are equal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public int? PreferredInput
        {
            get { return this._preferredInput; }
            set { this._preferredInput = value; }
        }

        // Check to see if PreferredInput property is set
        internal bool IsSetPreferredInput()
        {
            return this._preferredInput.HasValue; 
        }

    }
}