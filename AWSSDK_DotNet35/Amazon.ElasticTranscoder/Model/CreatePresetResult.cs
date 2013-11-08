/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// <para>The <c>CreatePresetResponse</c> structure.</para>
    /// </summary>
    public partial class CreatePresetResult : AmazonWebServiceResponse
    {
        
        private Preset preset;
        private string warning;


        /// <summary>
        /// A section of the response body that provides information about the preset that is created.
        ///  
        /// </summary>
        public Preset Preset
        {
            get { return this.preset; }
            set { this.preset = value; }
        }

        // Check to see if Preset property is set
        internal bool IsSetPreset()
        {
            return this.preset != null;
        }

        /// <summary>
        /// If the preset settings don't comply with the standards for the video codec but Elastic Transcoder created the preset, this message explains
        /// the reason the preset settings don't meet the standard. Elastic Transcoder created the preset because the settings might produce acceptable
        /// output.
        ///  
        /// </summary>
        public string Warning
        {
            get { return this.warning; }
            set { this.warning = value; }
        }

        // Check to see if Warning property is set
        internal bool IsSetWarning()
        {
            return this.warning != null;
        }
    }
}
