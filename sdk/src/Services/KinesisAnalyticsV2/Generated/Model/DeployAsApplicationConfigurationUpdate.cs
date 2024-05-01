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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Updates to the configuration information required to deploy an Amazon Data Analytics
    /// Studio notebook as an application with durable state.
    /// </summary>
    public partial class DeployAsApplicationConfigurationUpdate
    {
        private S3ContentBaseLocationUpdate _s3ContentLocationUpdate;

        /// <summary>
        /// Gets and sets the property S3ContentLocationUpdate. 
        /// <para>
        /// Updates to the location that holds the data required to specify an Amazon Data Analytics
        /// application.
        /// </para>
        /// </summary>
        public S3ContentBaseLocationUpdate S3ContentLocationUpdate
        {
            get { return this._s3ContentLocationUpdate; }
            set { this._s3ContentLocationUpdate = value; }
        }

        // Check to see if S3ContentLocationUpdate property is set
        internal bool IsSetS3ContentLocationUpdate()
        {
            return this._s3ContentLocationUpdate != null;
        }

    }
}