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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// For endpoints that use the DVB-DASH profile only. The font download and error reporting
    /// information that you want MediaPackage to pass through to the manifest.
    /// </summary>
    public partial class DashDvbSettings
    {
        private List<DashDvbMetricsReporting> _errorMetrics = AWSConfigs.InitializeCollections ? new List<DashDvbMetricsReporting>() : null;
        private DashDvbFontDownload _fontDownload;

        /// <summary>
        /// Gets and sets the property ErrorMetrics. 
        /// <para>
        /// Playback device error reporting settings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<DashDvbMetricsReporting> ErrorMetrics
        {
            get { return this._errorMetrics; }
            set { this._errorMetrics = value; }
        }

        // Check to see if ErrorMetrics property is set
        internal bool IsSetErrorMetrics()
        {
            return this._errorMetrics != null && (this._errorMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FontDownload. 
        /// <para>
        /// Subtitle font settings.
        /// </para>
        /// </summary>
        public DashDvbFontDownload FontDownload
        {
            get { return this._fontDownload; }
            set { this._fontDownload = value; }
        }

        // Check to see if FontDownload property is set
        internal bool IsSetFontDownload()
        {
            return this._fontDownload != null;
        }

    }
}