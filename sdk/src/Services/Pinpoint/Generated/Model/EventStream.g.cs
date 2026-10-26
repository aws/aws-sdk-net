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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies settings for publishing event data to an Amazon Kinesis data stream or an
    /// Amazon Kinesis Data Firehose delivery stream.
    /// </summary>
    public partial class EventStream
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application to publish event data for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property DestinationStreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Kinesis data stream or Amazon Kinesis
        /// Data Firehose delivery stream to publish event data to.
        /// </para>
        ///  
        /// <para>
        /// For a Kinesis data stream, the ARN format is: arn:aws:kinesis:<replaceable>region</replaceable>:<replaceable>account-id</replaceable>:stream/<replaceable>stream_name</replaceable>
        /// 
        /// </para>
        ///  
        /// <para>
        /// For a Kinesis Data Firehose delivery stream, the ARN format is: arn:aws:firehose:<replaceable>region</replaceable>:<replaceable>account-id</replaceable>:deliverystream/<replaceable>stream_name</replaceable>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationStreamArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationStreamArn property is set.
        /// </summary>
        internal bool IsSetDestinationStreamArn() => this.DestinationStreamArn != null;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// (Deprecated) Your AWS account ID, which you assigned to an external ID key in an IAM
        /// trust policy. Amazon Pinpoint previously used this value to assume an IAM role when
        /// publishing event data, but we removed this requirement. We don't recommend use of
        /// external IDs for IAM roles that are assumed by Amazon Pinpoint.
        /// </para>
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date, in ISO 8601 format, when the event stream was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        /// The IAM user who last modified the event stream.
        /// </para>
        /// </summary>
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedBy property is set.
        /// </summary>
        internal bool IsSetLastUpdatedBy() => this.LastUpdatedBy != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The AWS Identity and Access Management (IAM) role that authorizes Amazon Pinpoint
        /// to publish event data to the stream in your AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
