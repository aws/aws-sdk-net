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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The information required to deploy a Managed Service for Apache Flink Studio notebook
    /// as an application with durable state.
    /// </summary>
    public partial class DeployAsApplicationConfiguration
    {
        /// <summary>
        /// Gets and sets the property S3ContentLocation. 
        /// <para>
        /// The description of an Amazon S3 object that contains the Amazon Data Analytics application,
        /// including the Amazon Resource Name (ARN) of the S3 bucket, the name of the Amazon
        /// S3 object that contains the data, and the version number of the Amazon S3 object that
        /// contains the data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3ContentBaseLocation S3ContentLocation { get; set; }

        /// <summary>
        /// Checks to see if the S3ContentLocation property is set.
        /// </summary>
        internal bool IsSetS3ContentLocation() => this.S3ContentLocation != null;
    }
}
