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
    public class ListPresetsResult
    {
        
        private List<Preset> presets = new List<Preset>();

        /// <summary>
        /// An array of <c>Preset</c> objects.
        ///  
        /// </summary>
        public List<Preset> Presets
        {
            get { return this.presets; }
            set { this.presets = value; }
        }
        /// <summary>
        /// Adds elements to the Presets collection
        /// </summary>
        /// <param name="presets">The values to add to the Presets collection </param>
        /// <returns>this instance</returns>
        public ListPresetsResult WithPresets(params Preset[] presets)
        {
            foreach (Preset element in presets)
            {
                this.presets.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Presets collection
        /// </summary>
        /// <param name="presets">The values to add to the Presets collection </param>
        /// <returns>this instance</returns>
        public ListPresetsResult WithPresets(IEnumerable<Preset> presets)
        {
            foreach (Preset element in presets)
            {
                this.presets.Add(element);
            }

            return this;
        }

        // Check to see if Presets property is set
        internal bool IsSetPresets()
        {
            return this.presets.Count > 0;
        }
    }
}
