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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the ImportTable operation. Imports table data from
    /// an S3 bucket.
    /// </summary>
    public partial class ImportTableRequest : AmazonDynamoDBRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Providing a <c>ClientToken</c> makes the call to <c>ImportTableInput</c> idempotent,
        /// meaning that multiple identical calls have the same effect as one single call.
        /// </para>
        ///  
        /// <para>
        /// A client token is valid for 8 hours after the first request that uses it is completed.
        /// After 8 hours, any request with the same client token is treated as a new request.
        /// Do not resubmit the same request with the same client token for more than 8 hours,
        /// or the result might not be idempotent.
        /// </para>
        ///  
        /// <para>
        /// If you submit a request with the same client token but a change in other parameters
        /// within the 8-hour idempotency window, DynamoDB returns an <c>IdempotentParameterMismatch</c>
        /// exception.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property InputCompressionType. 
        /// <para>
        ///  Type of compression to be used on the input coming from the imported table. 
        /// </para>
        /// </summary>
        public InputCompressionType InputCompressionType { get; set; }

        /// <summary>
        /// Checks to see if the InputCompressionType property is set.
        /// </summary>
        internal bool IsSetInputCompressionType() => this.InputCompressionType != null;

        /// <summary>
        /// Gets and sets the property InputFormat. 
        /// <para>
        ///  The format of the source data. Valid values for <c>ImportFormat</c> are <c>CSV</c>,
        /// <c>DYNAMODB_JSON</c> or <c>ION</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InputFormat InputFormat { get; set; }

        /// <summary>
        /// Checks to see if the InputFormat property is set.
        /// </summary>
        internal bool IsSetInputFormat() => this.InputFormat != null;

        /// <summary>
        /// Gets and sets the property InputFormatOptions. 
        /// <para>
        ///  Additional properties that specify how the input is formatted, 
        /// </para>
        /// </summary>
        public InputFormatOptions InputFormatOptions { get; set; }

        /// <summary>
        /// Checks to see if the InputFormatOptions property is set.
        /// </summary>
        internal bool IsSetInputFormatOptions() => this.InputFormatOptions != null;

        /// <summary>
        /// Gets and sets the property S3BucketSource. 
        /// <para>
        ///  The S3 bucket that provides the source for the import. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3BucketSource S3BucketSource { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketSource property is set.
        /// </summary>
        internal bool IsSetS3BucketSource() => this.S3BucketSource != null;

        /// <summary>
        /// Gets and sets the property TableCreationParameters. 
        /// <para>
        /// Parameters for the table to import the data into. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TableCreationParameters TableCreationParameters { get; set; }

        /// <summary>
        /// Checks to see if the TableCreationParameters property is set.
        /// </summary>
        internal bool IsSetTableCreationParameters() => this.TableCreationParameters != null;
    }
}
