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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
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
namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// The <c>CreatePresetResponse</c> structure.
    /// </summary>
    public partial class CreatePresetResponse : AmazonWebServiceResponse
    {
        private Preset _preset;
        private string _warning;

        /// <summary>
        /// Gets and sets the property Preset. 
        /// <para>
        /// A section of the response body that provides information about the preset that is
        /// created.
        /// </para>
        /// </summary>
        public Preset Preset
        {
            get { return this._preset; }
            set { this._preset = value; }
        }

        // Check to see if Preset property is set
        internal bool IsSetPreset()
        {
            return this._preset != null;
        }

        /// <summary>
        /// Gets and sets the property Warning. 
        /// <para>
        /// If the preset settings don't comply with the standards for the video codec but Elastic
        /// Transcoder created the preset, this message explains the reason the preset settings
        /// don't meet the standard. Elastic Transcoder created the preset because the settings
        /// might produce acceptable output.
        /// </para>
        /// </summary>
        public string Warning
        {
            get { return this._warning; }
            set { this._warning = value; }
        }

        // Check to see if Warning property is set
        internal bool IsSetWarning()
        {
            return this._warning != null;
        }

    }
}