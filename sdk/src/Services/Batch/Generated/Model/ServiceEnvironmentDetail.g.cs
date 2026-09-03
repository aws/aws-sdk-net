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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Detailed information about a service environment, including its configuration, state,
    /// and capacity limits.
    /// </summary>
    public partial class ServiceEnvironmentDetail
    {
        /// <summary>
        /// Gets and sets the property CapacityLimits. 
        /// <para>
        /// The capacity limits for the service environment. This defines the maximum resources
        /// that can be used by service jobs in this environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<CapacityLimit> CapacityLimits { get; set; } = AWSConfigs.InitializeCollections ? new List<CapacityLimit>() : null;

        /// <summary>
        /// Checks to see if the CapacityLimits property is set.
        /// </summary>
        internal bool IsSetCapacityLimits() => this.CapacityLimits != null && (this.CapacityLimits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceEnvironmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServiceEnvironmentArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceEnvironmentArn property is set.
        /// </summary>
        internal bool IsSetServiceEnvironmentArn() => this.ServiceEnvironmentArn != null;

        /// <summary>
        /// Gets and sets the property ServiceEnvironmentName. 
        /// <para>
        /// The name of the service environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServiceEnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceEnvironmentName property is set.
        /// </summary>
        internal bool IsSetServiceEnvironmentName() => this.ServiceEnvironmentName != null;

        /// <summary>
        /// Gets and sets the property ServiceEnvironmentType. 
        /// <para>
        /// The type of service environment. For SageMaker Training jobs, this value is <c>SAGEMAKER_TRAINING</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceEnvironmentType ServiceEnvironmentType { get; set; }

        /// <summary>
        /// Checks to see if the ServiceEnvironmentType property is set.
        /// </summary>
        internal bool IsSetServiceEnvironmentType() => this.ServiceEnvironmentType != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the service environment. Valid values are <c>ENABLED</c> and <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public ServiceEnvironmentState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the service environment.
        /// </para>
        /// </summary>
        public ServiceEnvironmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the service environment. Each tag consists of a key and an
        /// optional value. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/using-tags.html">Tagging
        /// your Batch resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
