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
    /// A type of OutputConfig, used when the output in a feed is for the clip feature.
    /// </summary>
    public partial class ClippingConfig
    {
        private string _callbackMetadata;

        /// <summary>
        /// Gets and sets the property CallbackMetadata. 
        /// <para>
        /// The metadata that is the result of the clip request to Elemental Inference. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string CallbackMetadata
        {
            get { return this._callbackMetadata; }
            set { this._callbackMetadata = value; }
        }

        // Check to see if CallbackMetadata property is set
        internal bool IsSetCallbackMetadata()
        {
            return this._callbackMetadata != null;
        }

    }
}