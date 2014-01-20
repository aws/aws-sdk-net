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
    /// <para>The <c>ListPresetsResponse</c> structure.</para>
    /// </summary>
    public partial class ListPresetsResult
    {
        
        private List<Preset> presets = new List<Preset>();
        private string nextPageToken;

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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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

        /// <summary>
        /// A value that you use to access the second and subsequent pages of results, if any. When the presets fit on one page or when you've reached
        /// the last page of results, the value of <c>NextPageToken</c> is <c>null</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d{13}-\w{6}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this.nextPageToken; }
            set { this.nextPageToken = value; }
        }

        /// <summary>
        /// Sets the NextPageToken property
        /// </summary>
        /// <param name="nextPageToken">The value to set for the NextPageToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListPresetsResult WithNextPageToken(string nextPageToken)
        {
            this.nextPageToken = nextPageToken;
            return this;
        }
            

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this.nextPageToken != null;
        }
    }
}
