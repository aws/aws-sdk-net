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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// The source of your data, an Identity and Access Management (IAM) role that allows
    /// Amazon Forecast to access the data and, optionally, an Key Management Service (KMS)
    /// key.
    /// </summary>
    public partial class DataSource
    {
        private S3Config _s3Config;

        /// <summary>
        /// Gets and sets the property S3Config. 
        /// <para>
        /// The path to the data stored in an Amazon Simple Storage Service (Amazon S3) bucket
        /// along with the credentials to access the data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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