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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ErrorMetrics. 
        /// <para>
        /// Playback device error reporting settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<DashDvbMetricsReporting> ErrorMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<DashDvbMetricsReporting>() : null;

        /// <summary>
        /// Checks to see if the ErrorMetrics property is set.
        /// </summary>
        internal bool IsSetErrorMetrics() => this.ErrorMetrics != null && (this.ErrorMetrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FontDownload. 
        /// <para>
        /// Subtitle font settings.
        /// </para>
        /// </summary>
        public DashDvbFontDownload FontDownload { get; set; }

        /// <summary>
        /// Checks to see if the FontDownload property is set.
        /// </summary>
        internal bool IsSetFontDownload() => this.FontDownload != null;
    }
}
