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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
        private string _bucketName;
        private string _bucketPrefix;
        private bool? _failOnFirstDestinationError;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        ///  Specifies the name of the Amazon S3 bucket. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property BucketPrefix. 
        /// <para>
        ///  Specifies the Amazon S3 bucket prefix. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string BucketPrefix
        {
            get { return this._bucketPrefix; }
            set { this._bucketPrefix = value; }
        }

        // Check to see if BucketPrefix property is set
        internal bool IsSetBucketPrefix()
        {
            return this._bucketPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property FailOnFirstDestinationError. 
        /// <para>
        ///  Specifies if the flow should fail after the first instance of a failure when attempting
        /// to place data in the destination. 
        /// </para>
        /// </summary>
        public bool? FailOnFirstDestinationError
        {
            get { return this._failOnFirstDestinationError; }
            set { this._failOnFirstDestinationError = value; }
        }

        // Check to see if FailOnFirstDestinationError property is set
        internal bool IsSetFailOnFirstDestinationError()
        {
            return this._failOnFirstDestinationError.HasValue; 
        }

    }
}