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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Contains <code>ToxicityCategories</code>, which is a required parameter if you want
    /// to enable toxicity detection (<code>ToxicityDetection</code>) in your transcription
    /// request.
    /// </summary>
    public partial class ToxicityDetectionSettings
    {
        private List<string> _toxicityCategories = new List<string>();

        /// <summary>
        /// Gets and sets the property ToxicityCategories. 
        /// <para>
        ///  If you include <code>ToxicityDetection</code> in your transcription request, you
        /// must also include <code>ToxicityCategories</code>. The only accepted value for this
        /// parameter is <code>ALL</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> ToxicityCategories
        {
            get { return this._toxicityCategories; }
            set { this._toxicityCategories = value; }
        }

        // Check to see if ToxicityCategories property is set
        internal bool IsSetToxicityCategories()
        {
            return this._toxicityCategories != null && this._toxicityCategories.Count > 0; 
        }

    }
}