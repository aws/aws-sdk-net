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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// A method for collecting container logs for the fleet. Amazon GameLift Servers saves
    /// all standard output for each container in logs, including game session logs. You can
    /// select from the following methods:
    /// </summary>
    public partial class LogConfiguration
    {
        /// <summary>
        /// Gets and sets the property LogDestination. 
        /// <para>
        /// The type of log collection to use for a fleet.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CLOUDWATCH</c> -- (default value) Send logs to an Amazon CloudWatch log group
        /// that you define. Each container emits a log stream, which is organized in the log
        /// group. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3</c> -- Store logs in an Amazon S3 bucket that you define. This bucket must
        /// reside in the fleet's home Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> -- Don't collect container logs.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LogDestination LogDestination { get; set; }

        /// <summary>
        /// Checks to see if the LogDestination property is set.
        /// </summary>
        internal bool IsSetLogDestination() => this.LogDestination != null;

        /// <summary>
        /// Gets and sets the property LogGroupArn. 
        /// <para>
        /// If log destination is <c>CLOUDWATCH</c>, logs are sent to the specified log group
        /// in Amazon CloudWatch.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupArn property is set.
        /// </summary>
        internal bool IsSetLogGroupArn() => this.LogGroupArn != null;

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// If log destination is <c>S3</c>, logs are sent to the specified Amazon S3 bucket name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string S3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketName property is set.
        /// </summary>
        internal bool IsSetS3BucketName() => this.S3BucketName != null;
    }
}
