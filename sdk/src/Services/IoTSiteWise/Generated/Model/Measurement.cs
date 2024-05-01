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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains an asset measurement property. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/asset-properties.html#measurements">Measurements</a>
    /// in the <i>IoT SiteWise User Guide</i>.
    /// </summary>
    public partial class Measurement
    {
        private MeasurementProcessingConfig _processingConfig;

        /// <summary>
        /// Gets and sets the property ProcessingConfig. 
        /// <para>
        /// The processing configuration for the given measurement property. You can configure
        /// measurements to be kept at the edge or forwarded to the Amazon Web Services Cloud.
        /// By default, measurements are forwarded to the cloud.
        /// </para>
        /// </summary>
        public MeasurementProcessingConfig ProcessingConfig
        {
            get { return this._processingConfig; }
            set { this._processingConfig = value; }
        }

        // Check to see if ProcessingConfig property is set
        internal bool IsSetProcessingConfig()
        {
            return this._processingConfig != null;
        }

    }
}