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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A container for the bucket where the Amazon S3 Storage Lens metrics export files are
    /// located.
    /// </summary>
    public partial class S3BucketDestination
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID of the owner of the S3 Storage Lens metrics export bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the bucket. This property is read-only and follows
        /// the following format: <c> arn:aws:s3:<i>us-east-1</i>:<i>example-account-id</i>:bucket/<i>your-destination-bucket-name</i>
        /// </c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Encryption. 
        /// <para>
        /// The container for the type encryption of the metrics exports in this bucket.
        /// </para>
        /// </summary>
        public StorageLensDataExportEncryption Encryption { get; set; }

        /// <summary>
        /// Checks to see if the Encryption property is set.
        /// </summary>
        internal bool IsSetEncryption() => this.Encryption != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Format Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property OutputSchemaVersion. 
        /// <para>
        /// The schema version of the export file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputSchemaVersion OutputSchemaVersion { get; set; }

        /// <summary>
        /// Checks to see if the OutputSchemaVersion property is set.
        /// </summary>
        internal bool IsSetOutputSchemaVersion() => this.OutputSchemaVersion != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The prefix of the destination bucket where the metrics export will be delivered.
        /// </para>
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;
    }
}
