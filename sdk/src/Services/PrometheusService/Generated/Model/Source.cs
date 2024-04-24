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
    /// The source of collected metrics for a scraper.
    /// </summary>
    public partial class Source
    {
        private EksConfiguration _eksConfiguration;

        /// <summary>
        /// Gets and sets the property EksConfiguration. 
        /// <para>
        /// The Amazon EKS cluster from which a scraper collects metrics.
        /// </para>
        /// </summary>
        public EksConfiguration EksConfiguration
        {
            get { return this._eksConfiguration; }
            set { this._eksConfiguration = value; }
        }

        // Check to see if EksConfiguration property is set
        internal bool IsSetEksConfiguration()
        {
            return this._eksConfiguration != null;
        }

    }
}