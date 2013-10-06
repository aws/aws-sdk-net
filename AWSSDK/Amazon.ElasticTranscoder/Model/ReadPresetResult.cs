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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ReadPresetResult
    {
        
        private Preset preset;

        /// <summary>
        /// A section of the response body that provides information about the preset.
        ///  
        /// </summary>
        public Preset Preset
        {
            get { return this.preset; }
            set { this.preset = value; }
        }

        /// <summary>
        /// Sets the Preset property
        /// </summary>
        /// <param name="preset">The value to set for the Preset property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReadPresetResult WithPreset(Preset preset)
        {
            this.preset = preset;
            return this;
        }
            

        // Check to see if Preset property is set
        internal bool IsSetPreset()
        {
            return this.preset != null;
        }
    }
}
