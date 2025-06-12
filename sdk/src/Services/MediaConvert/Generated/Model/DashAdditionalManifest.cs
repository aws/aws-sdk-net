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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Specify the details for each additional DASH manifest that you want the service to
    /// generate for this output group. Each manifest can reference a different subset of
    /// outputs in the group.
    /// </summary>
    public partial class DashAdditionalManifest
    {
        private string _manifestNameModifier;
        private List<string> _selectedOutputs = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ManifestNameModifier. Specify a name modifier that the
        /// service adds to the name of this manifest to make it different from the file names
        /// of the other main manifests in the output group. For example, say that the default
        /// main manifest for your DASH group is film-name.mpd. If you enter "-no-premium" for
        /// this setting, then the file name the service generates for this top-level manifest
        /// is film-name-no-premium.mpd.
        /// </summary>
        [AWSProperty(Min=1)]
        public string ManifestNameModifier
        {
            get { return this._manifestNameModifier; }
            set { this._manifestNameModifier = value; }
        }

        // Check to see if ManifestNameModifier property is set
        internal bool IsSetManifestNameModifier()
        {
            return this._manifestNameModifier != null;
        }

        /// <summary>
        /// Gets and sets the property SelectedOutputs. Specify the outputs that you want this
        /// additional top-level manifest to reference.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SelectedOutputs
        {
            get { return this._selectedOutputs; }
            set { this._selectedOutputs = value; }
        }

        // Check to see if SelectedOutputs property is set
        internal bool IsSetSelectedOutputs()
        {
            return this._selectedOutputs != null && (this._selectedOutputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}