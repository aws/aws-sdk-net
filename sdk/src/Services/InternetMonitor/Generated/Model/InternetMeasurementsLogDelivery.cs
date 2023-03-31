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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// Configuration information for other locations that you choose to publish Amazon CloudWatch
    /// Internet Monitor internet measurements to, such as Amazon S3. The measurements are
    /// also published to Amazon CloudWatch Logs.
    /// </summary>
    public partial class InternetMeasurementsLogDelivery
    {
        private S3Config _s3Config;

        /// <summary>
        /// Gets and sets the property S3Config. 
        /// <para>
        /// The configuration information for publishing Internet Monitor internet measurements
        /// to Amazon S3. The configuration includes the bucket name and (optionally) prefix for
        /// the S3 bucket to store the measurements, and the delivery status. The delivery status
        /// is <code>ENABLED</code> or <code>DISABLED</code>, depending on whether you choose
        /// to deliver internet measurements to S3 logs.
        /// </para>
        /// </summary>
        public S3Config S3Config
        {
            get { return this._s3Config; }
            set { this._s3Config = value; }
        }

        // Check to see if S3Config property is set
        internal bool IsSetS3Config()
        {
            return this._s3Config != null;
        }

    }
}