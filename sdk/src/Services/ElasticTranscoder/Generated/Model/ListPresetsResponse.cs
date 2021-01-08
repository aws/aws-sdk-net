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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// The <code>ListPresetsResponse</code> structure.
    /// </summary>
    public partial class ListPresetsResponse : AmazonWebServiceResponse
    {
        private string _nextPageToken;
        private List<Preset> _presets = new List<Preset>();

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// A value that you use to access the second and subsequent pages of results, if any.
        /// When the presets fit on one page or when you've reached the last page of results,
        /// the value of <code>NextPageToken</code> is <code>null</code>.
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property Presets. 
        /// <para>
        /// An array of <code>Preset</code> objects.
        /// </para>
        /// </summary>
        public List<Preset> Presets
        {
            get { return this._presets; }
            set { this._presets = value; }
        }

        // Check to see if Presets property is set
        internal bool IsSetPresets()
        {
            return this._presets != null && this._presets.Count > 0; 
        }

    }
}