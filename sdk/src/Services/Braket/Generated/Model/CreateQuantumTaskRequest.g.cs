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

namespace Amazon.Braket.Model
{
    /// <summary>
    /// Container for the parameters to the CreateQuantumTask operation. Creates a quantum
    /// task.
    /// </summary>
    public partial class CreateQuantumTaskRequest : AmazonBraketRequest
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action associated with the quantum task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Associations. 
        /// <para>
        /// The list of Amazon Braket resources associated with the quantum task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<Association> Associations { get; set; } = AWSConfigs.InitializeCollections ? new List<Association>() : null;

        /// <summary>
        /// Checks to see if the Associations property is set.
        /// </summary>
        internal bool IsSetAssociations() => this.Associations != null && (this.Associations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The ARN of the device to run the quantum task on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string DeviceArn { get; set; }

        /// <summary>
        /// Checks to see if the DeviceArn property is set.
        /// </summary>
        internal bool IsSetDeviceArn() => this.DeviceArn != null;

        /// <summary>
        /// Gets and sets the property DeviceParameters. 
        /// <para>
        /// The parameters for the device to run the quantum task on.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 48000)]
        public string DeviceParameters { get; set; }

        /// <summary>
        /// Checks to see if the DeviceParameters property is set.
        /// </summary>
        internal bool IsSetDeviceParameters() => this.DeviceParameters != null;

        /// <summary>
        /// Gets and sets the property ExperimentalCapabilities. 
        /// <para>
        /// Enable experimental capabilities for the quantum task.
        /// </para>
        /// </summary>
        public ExperimentalCapabilities ExperimentalCapabilities { get; set; }

        /// <summary>
        /// Checks to see if the ExperimentalCapabilities property is set.
        /// </summary>
        internal bool IsSetExperimentalCapabilities() => this.ExperimentalCapabilities != null;

        /// <summary>
        /// Gets and sets the property JobToken. 
        /// <para>
        /// The token for an Amazon Braket hybrid job that associates it with the quantum task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string JobToken { get; set; }

        /// <summary>
        /// Checks to see if the JobToken property is set.
        /// </summary>
        internal bool IsSetJobToken() => this.JobToken != null;

        /// <summary>
        /// Gets and sets the property OutputS3Bucket. 
        /// <para>
        /// The S3 bucket to store quantum task result files in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 63)]
        public string OutputS3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3Bucket property is set.
        /// </summary>
        internal bool IsSetOutputS3Bucket() => this.OutputS3Bucket != null;

        /// <summary>
        /// Gets and sets the property OutputS3KeyPrefix. 
        /// <para>
        /// The key prefix for the location in the S3 bucket to store quantum task results in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string OutputS3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetOutputS3KeyPrefix() => this.OutputS3KeyPrefix != null;

        /// <summary>
        /// Gets and sets the property Shots. 
        /// <para>
        /// The number of shots to use for the quantum task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? Shots { get; set; }

        /// <summary>
        /// Checks to see if the Shots property is set.
        /// </summary>
        internal bool IsSetShots() => this.Shots.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to be added to the quantum task you're creating.
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
