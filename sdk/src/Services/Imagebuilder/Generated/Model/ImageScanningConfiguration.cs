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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Contains settings for Image Builder image resource and container image scans.
    /// </summary>
    public partial class ImageScanningConfiguration
    {
        private EcrConfiguration _ecrConfiguration;
        private bool? _imageScanningEnabled;

        /// <summary>
        /// Gets and sets the property EcrConfiguration. 
        /// <para>
        /// Contains Amazon ECR settings for vulnerability scans.
        /// </para>
        /// </summary>
        public EcrConfiguration EcrConfiguration
        {
            get { return this._ecrConfiguration; }
            set { this._ecrConfiguration = value; }
        }

        // Check to see if EcrConfiguration property is set
        internal bool IsSetEcrConfiguration()
        {
            return this._ecrConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ImageScanningEnabled. 
        /// <para>
        /// A setting that indicates whether Image Builder keeps a snapshot of the vulnerability
        /// scans that Amazon Inspector runs against the build instance when you create a new
        /// image.
        /// </para>
        /// </summary>
        public bool ImageScanningEnabled
        {
            get { return this._imageScanningEnabled.GetValueOrDefault(); }
            set { this._imageScanningEnabled = value; }
        }

        // Check to see if ImageScanningEnabled property is set
        internal bool IsSetImageScanningEnabled()
        {
            return this._imageScanningEnabled.HasValue; 
        }

    }
}