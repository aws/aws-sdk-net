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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The settings that determine how Amazon AppFlow handles an error when placing data
    /// in the destination. For example, this setting would determine if the flow should fail
    /// after one insertion error, or continue and attempt to insert every record regardless
    /// of the initial failure. <c>ErrorHandlingConfig</c> is a part of the destination connector
    /// details.
    /// </summary>
    public partial class ErrorHandlingConfig
    {
        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        ///  Specifies the name of the Amazon S3 bucket. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string BucketName { get; set; }

        /// <summary>
        /// Checks to see if the BucketName property is set.
        /// </summary>
        internal bool IsSetBucketName() => this.BucketName != null;

        /// <summary>
        /// Gets and sets the property BucketPrefix. 
        /// <para>
        ///  Specifies the Amazon S3 bucket prefix. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string BucketPrefix { get; set; }

        /// <summary>
        /// Checks to see if the BucketPrefix property is set.
        /// </summary>
        internal bool IsSetBucketPrefix() => this.BucketPrefix != null;

        /// <summary>
        /// Gets and sets the property FailOnFirstDestinationError. 
        /// <para>
        ///  Specifies if the flow should fail after the first instance of a failure when attempting
        /// to place data in the destination. 
        /// </para>
        /// </summary>
        public bool? FailOnFirstDestinationError { get; set; }

        /// <summary>
        /// Checks to see if the FailOnFirstDestinationError property is set.
        /// </summary>
        internal bool IsSetFailOnFirstDestinationError() => this.FailOnFirstDestinationError.HasValue;
    }
}
