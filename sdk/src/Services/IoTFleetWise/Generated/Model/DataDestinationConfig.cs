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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// The destination where the Amazon Web Services IoT FleetWise campaign sends data. You
    /// can send data to be stored in Amazon S3 or Amazon Timestream.
    /// </summary>
    public partial class DataDestinationConfig
    {
        private S3Config _s3Config;
        private TimestreamConfig _timestreamConfig;

        /// <summary>
        /// Gets and sets the property S3Config. 
        /// <para>
        /// The Amazon S3 bucket where the Amazon Web Services IoT FleetWise campaign sends data.
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

        /// <summary>
        /// Gets and sets the property TimestreamConfig. 
        /// <para>
        /// The Amazon Timestream table where the campaign sends data.
        /// </para>
        /// </summary>
        public TimestreamConfig TimestreamConfig
        {
            get { return this._timestreamConfig; }
            set { this._timestreamConfig = value; }
        }

        // Check to see if TimestreamConfig property is set
        internal bool IsSetTimestreamConfig()
        {
            return this._timestreamConfig != null;
        }

    }
}