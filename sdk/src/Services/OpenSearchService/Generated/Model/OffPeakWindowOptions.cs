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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Options for a domain's <a href="https://docs.aws.amazon.com/opensearch-service/latest/APIReference/API_OffPeakWindow.html">off-peak
    /// window</a>, during which OpenSearch Service can perform mandatory configuration changes
    /// on the domain.
    /// </summary>
    public partial class OffPeakWindowOptions
    {
        private bool? _enabled;
        private OffPeakWindow _offPeakWindow;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether to enable an off-peak window.
        /// </para>
        ///  
        /// <para>
        /// This option is only available when modifying a domain created prior to February 13,
        /// 2023, not when creating a new domain. All domains created after this date have the
        /// off-peak window enabled by default. You can't disable the off-peak window after it's
        /// enabled for a domain.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OffPeakWindow. 
        /// <para>
        /// Off-peak window settings for the domain.
        /// </para>
        /// </summary>
        public OffPeakWindow OffPeakWindow
        {
            get { return this._offPeakWindow; }
            set { this._offPeakWindow = value; }
        }

        // Check to see if OffPeakWindow property is set
        internal bool IsSetOffPeakWindow()
        {
            return this._offPeakWindow != null;
        }

    }
}