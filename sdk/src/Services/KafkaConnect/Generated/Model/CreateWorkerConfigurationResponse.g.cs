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

namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// This is the response object from the CreateWorkerConfiguration operation.
    /// </summary>
    public partial class CreateWorkerConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the worker configuration was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LatestRevision. 
        /// <para>
        /// The latest revision of the worker configuration.
        /// </para>
        /// </summary>
        public WorkerConfigurationRevisionSummary LatestRevision { get; set; }

        /// <summary>
        /// Checks to see if the LatestRevision property is set.
        /// </summary>
        internal bool IsSetLatestRevision() => this.LatestRevision != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the worker configuration.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property WorkerConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that Amazon assigned to the worker configuration.
        /// </para>
        /// </summary>
        public string WorkerConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkerConfigurationArn property is set.
        /// </summary>
        internal bool IsSetWorkerConfigurationArn() => this.WorkerConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property WorkerConfigurationState. 
        /// <para>
        /// The state of the worker configuration.
        /// </para>
        /// </summary>
        public WorkerConfigurationState WorkerConfigurationState { get; set; }

        /// <summary>
        /// Checks to see if the WorkerConfigurationState property is set.
        /// </summary>
        internal bool IsSetWorkerConfigurationState() => this.WorkerConfigurationState != null;
    }
}
