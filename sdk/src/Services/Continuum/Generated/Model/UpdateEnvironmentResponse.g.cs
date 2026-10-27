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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// This is the response object from the UpdateEnvironment operation.
    /// </summary>
    public partial class UpdateEnvironmentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Configuration. Type-specific state, including Collector
        /// details and the latest scan. Read source and operating-policy settings through GetEnvironment.
        /// </summary>
        [AWSProperty(Required = true)]
        public EnvironmentConfigurationDetails Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. The timestamp when the environment was created.
        /// Uses the existing GetEnvironment/ListEnvironments ISO-8601 wire format for this field.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EnvironmentArn. The ARN of the updated environment.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string EnvironmentArn { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentArn property is set.
        /// </summary>
        internal bool IsSetEnvironmentArn() => this.EnvironmentArn != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. The unique identifier of the updated environment.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property Name. The current customer-visible name of the environment.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. The current operational status of the environment.
        /// </summary>
        [AWSProperty(Required = true)]
        public EnvironmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. Human-readable details about the current
        /// status.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property StatusUpdatedAt. The timestamp when the status last transitioned.
        /// Uses the existing GetEnvironment/ListEnvironments ISO-8601 wire format for this field.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StatusUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the StatusUpdatedAt property is set.
        /// </summary>
        internal bool IsSetStatusUpdatedAt() => this.StatusUpdatedAt.HasValue;
    }
}
