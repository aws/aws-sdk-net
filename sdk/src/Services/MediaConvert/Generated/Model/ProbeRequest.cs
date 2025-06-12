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
    /// Container for the parameters to the Probe operation.
    /// Use Probe to obtain detailed information about your input media files. Probe returns
    /// a JSON that includes container, codec, frame rate, resolution, track count, audio
    /// layout, captions, and more. You can use this information to learn more about your
    /// media files, or to help make decisions while automating your transcoding workflow.
    /// </summary>
    public partial class ProbeRequest : AmazonMediaConvertRequest
    {
        private List<ProbeInputFile> _inputFiles = AWSConfigs.InitializeCollections ? new List<ProbeInputFile>() : null;

        /// <summary>
        /// Gets and sets the property InputFiles. Specify a media file to probe.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProbeInputFile> InputFiles
        {
            get { return this._inputFiles; }
            set { this._inputFiles = value; }
        }

        // Check to see if InputFiles property is set
        internal bool IsSetInputFiles()
        {
            return this._inputFiles != null && (this._inputFiles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}