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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// This is the response object from the GetS3TableIntegration operation.
    /// </summary>
    public partial class GetS3TableIntegrationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 Table integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedTimeStamp. 
        /// <para>
        /// The timestamp when the S3 Table integration was created.
        /// </para>
        /// </summary>
        public long? CreatedTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimeStamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimeStamp() => this.CreatedTimeStamp.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationTableBucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 bucket used as the destination for the table
        /// data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string DestinationTableBucketArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationTableBucketArn property is set.
        /// </summary>
        internal bool IsSetDestinationTableBucketArn() => this.DestinationTableBucketArn != null;

        /// <summary>
        /// Gets and sets the property Encryption. 
        /// <para>
        /// The encryption configuration for the S3 Table integration.
        /// </para>
        /// </summary>
        public Encryption Encryption { get; set; }

        /// <summary>
        /// Checks to see if the Encryption property is set.
        /// </summary>
        internal bool IsSetEncryption() => this.Encryption != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used by the S3 Table integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the S3 Table integration.
        /// </para>
        /// </summary>
        public IntegrationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
