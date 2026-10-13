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

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBatchImportJob operation. Creates a batch
    /// import job.
    /// </summary>
    public partial class CreateBatchImportJobRequest : AmazonFraudDetectorRequest
    {
        /// <summary>
        /// Gets and sets the property EventTypeName. 
        /// <para>
        /// The name of the event type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EventTypeName { get; set; }

        /// <summary>
        /// Checks to see if the EventTypeName property is set.
        /// </summary>
        internal bool IsSetEventTypeName() => this.EventTypeName != null;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The ARN of the IAM role created for Amazon S3 bucket that holds your data file.
        /// </para>
        ///  
        /// <para>
        /// The IAM role must have read permissions to your input S3 bucket and write permissions
        /// to your output S3 bucket. For more information about bucket permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/example-policies-s3.html">User
        /// policy examples</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property InputPath. 
        /// <para>
        /// The URI that points to the Amazon S3 location of your data file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string InputPath { get; set; }

        /// <summary>
        /// Checks to see if the InputPath property is set.
        /// </summary>
        internal bool IsSetInputPath() => this.InputPath != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the batch import job. The ID cannot be of a past job, unless the job exists
        /// in <c>CREATE_FAILED</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property OutputPath. 
        /// <para>
        /// The URI that points to the Amazon S3 location for storing your results. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string OutputPath { get; set; }

        /// <summary>
        /// Checks to see if the OutputPath property is set.
        /// </summary>
        internal bool IsSetOutputPath() => this.OutputPath != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A collection of key-value pairs associated with this request. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
