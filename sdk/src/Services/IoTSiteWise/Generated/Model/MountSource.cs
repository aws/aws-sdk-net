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
    /// The data source configuration for a mount. Specify exactly one of the following.
    /// </summary>
    public partial class MountSource
    {
        private S3AccessPointSource _s3AccessPoint;

        /// <summary>
        /// Gets and sets the property S3AccessPoint. 
        /// <para>
        /// Configuration for a mount that reads from an Amazon S3 access point.
        /// </para>
        /// </summary>
        public S3AccessPointSource S3AccessPoint
        {
            get { return this._s3AccessPoint; }
            set { this._s3AccessPoint = value; }
        }

        // Check to see if S3AccessPoint property is set
        internal bool IsSetS3AccessPoint()
        {
            return this._s3AccessPoint != null;
        }

    }
}