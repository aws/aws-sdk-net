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
    /// The Probe operation analyzes the provided media file and returns comprehensive metadata
    /// about its container format, tracks, and any encountered errors.
    /// </summary>
    public partial class ProbeRequest : AmazonMediaConvertRequest
    {
        private List<ProbeInputFile> _inputFiles = AWSConfigs.InitializeCollections ? new List<ProbeInputFile>() : null;

        /// <summary>
        /// Gets and sets the property InputFiles. The list of input media files to be probed.
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