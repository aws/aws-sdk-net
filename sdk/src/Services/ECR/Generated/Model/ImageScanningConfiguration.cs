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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// The image scanning configuration for a repository.
    /// </summary>
    public partial class ImageScanningConfiguration
    {
        private bool? _scanOnPush;

        /// <summary>
        /// Gets and sets the property ScanOnPush. 
        /// <para>
        /// The setting that determines whether images are scanned after being pushed to a repository.
        /// If set to <c>true</c>, images will be scanned after being pushed. If this parameter
        /// is not specified, it will default to <c>false</c> and images will not be scanned unless
        /// a scan is manually started with the <a href="https://docs.aws.amazon.com/AmazonECR/latest/APIReference/API_StartImageScan.html">API_StartImageScan</a>
        /// API.
        /// </para>
        /// </summary>
        public bool? ScanOnPush
        {
            get { return this._scanOnPush; }
            set { this._scanOnPush = value; }
        }

        // Check to see if ScanOnPush property is set
        internal bool IsSetScanOnPush()
        {
            return this._scanOnPush.HasValue; 
        }

    }
}