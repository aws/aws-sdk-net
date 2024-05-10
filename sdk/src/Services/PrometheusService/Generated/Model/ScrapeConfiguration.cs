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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// A scrape configuration for a scraper, base 64 encoded. For more information, see <a
    /// href="prometheus/latest/userguide/AMP-collector-how-to.html#AMP-collector-configuration">Scraper
    /// configuration</a> in the <i>Amazon Managed Service for Prometheus User Guide</i>.
    /// </summary>
    public partial class ScrapeConfiguration
    {
        private MemoryStream _configurationBlob;

        /// <summary>
        /// Gets and sets the property ConfigurationBlob. 
        /// <para>
        /// The base 64 encoded scrape configuration file.
        /// </para>
        /// </summary>
        public MemoryStream ConfigurationBlob
        {
            get { return this._configurationBlob; }
            set { this._configurationBlob = value; }
        }

        // Check to see if ConfigurationBlob property is set
        internal bool IsSetConfigurationBlob()
        {
            return this._configurationBlob != null;
        }

    }
}