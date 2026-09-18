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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the GetProvisionedModelThroughput operation.
    /// </summary>
    public partial class GetProvisionedModelThroughputResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CommitmentDuration. 
        /// <para>
        /// Commitment duration of the Provisioned Throughput.
        /// </para>
        /// </summary>
        public CommitmentDuration CommitmentDuration { get; set; }

        /// <summary>
        /// Checks to see if the CommitmentDuration property is set.
        /// </summary>
        internal bool IsSetCommitmentDuration() => this.CommitmentDuration != null;

        /// <summary>
        /// Gets and sets the property CommitmentExpirationTime. 
        /// <para>
        /// The timestamp for when the commitment term for the Provisioned Throughput expires.
        /// </para>
        /// </summary>
        public DateTime? CommitmentExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the CommitmentExpirationTime property is set.
        /// </summary>
        internal bool IsSetCommitmentExpirationTime() => this.CommitmentExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp of the creation time for this Provisioned Throughput. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DesiredModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model requested to be associated to this Provisioned
        /// Throughput. This value differs from the <c>modelArn</c> if updating hasn't completed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1011)]
        public string DesiredModelArn { get; set; }

        /// <summary>
        /// Checks to see if the DesiredModelArn property is set.
        /// </summary>
        internal bool IsSetDesiredModelArn() => this.DesiredModelArn != null;

        /// <summary>
        /// Gets and sets the property DesiredModelUnits. 
        /// <para>
        /// The number of model units that was requested for this Provisioned Throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? DesiredModelUnits { get; set; }

        /// <summary>
        /// Checks to see if the DesiredModelUnits property is set.
        /// </summary>
        internal bool IsSetDesiredModelUnits() => this.DesiredModelUnits.HasValue;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// A failure message for any issues that occurred during creation, updating, or deletion
        /// of the Provisioned Throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property FoundationModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the base model for which the Provisioned Throughput
        /// was created, or of the base model that the custom model for which the Provisioned
        /// Throughput was created was customized.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FoundationModelArn { get; set; }

        /// <summary>
        /// Checks to see if the FoundationModelArn property is set.
        /// </summary>
        internal bool IsSetFoundationModelArn() => this.FoundationModelArn != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp of the last time that this Provisioned Throughput was modified. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model associated with this Provisioned Throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1011)]
        public string ModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelArn property is set.
        /// </summary>
        internal bool IsSetModelArn() => this.ModelArn != null;

        /// <summary>
        /// Gets and sets the property ModelUnits. 
        /// <para>
        /// The number of model units allocated to this Provisioned Throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? ModelUnits { get; set; }

        /// <summary>
        /// Checks to see if the ModelUnits property is set.
        /// </summary>
        internal bool IsSetModelUnits() => this.ModelUnits.HasValue;

        /// <summary>
        /// Gets and sets the property ProvisionedModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Provisioned Throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProvisionedModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedModelArn property is set.
        /// </summary>
        internal bool IsSetProvisionedModelArn() => this.ProvisionedModelArn != null;

        /// <summary>
        /// Gets and sets the property ProvisionedModelName. 
        /// <para>
        /// The name of the Provisioned Throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ProvisionedModelName { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedModelName property is set.
        /// </summary>
        internal bool IsSetProvisionedModelName() => this.ProvisionedModelName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Provisioned Throughput. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProvisionedModelStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
