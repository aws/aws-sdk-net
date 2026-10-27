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

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// Container for the parameters to the StartVectorEnrichmentJob operation. Creates a
    /// Vector Enrichment job for the supplied job type. Currently, there are two supported
    /// job types: reverse geocoding and map matching.
    /// </summary>
    public partial class StartVectorEnrichmentJobRequest : AmazonSageMakerGeospatialRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique token that guarantees that the call to this API is idempotent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that you specified for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property InputConfig. 
        /// <para>
        /// Input configuration information for the Vector Enrichment job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VectorEnrichmentJobInputConfig InputConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputConfig property is set.
        /// </summary>
        internal bool IsSetInputConfig() => this.InputConfig != null;

        /// <summary>
        /// Gets and sets the property JobConfig. 
        /// <para>
        /// An object containing information about the job configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VectorEnrichmentJobConfig JobConfig { get; set; }

        /// <summary>
        /// Checks to see if the JobConfig property is set.
        /// </summary>
        internal bool IsSetJobConfig() => this.JobConfig != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Key Management Service key ID for server-side encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Vector Enrichment job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 200)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Each tag consists of a key and a value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
