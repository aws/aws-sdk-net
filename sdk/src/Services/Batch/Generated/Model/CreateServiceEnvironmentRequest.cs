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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
    /// Container for the parameters to the CreateServiceEnvironment operation.
    /// Creates a service environment for running service jobs. Service environments define
    /// capacity limits for specific service types such as SageMaker Training jobs.
    /// </summary>
    public partial class CreateServiceEnvironmentRequest : AmazonBatchRequest
    {
        private List<CapacityLimit> _capacityLimits = AWSConfigs.InitializeCollections ? new List<CapacityLimit>() : null;
        private string _serviceEnvironmentName;
        private ServiceEnvironmentType _serviceEnvironmentType;
        private ServiceEnvironmentState _state;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CapacityLimits. 
        /// <para>
        /// The capacity limits for the service environment. The number of instances a job consumes
        /// is the total number of instances requested in the submit training job request resource
        /// configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<CapacityLimit> CapacityLimits
        {
            get { return this._capacityLimits; }
            set { this._capacityLimits = value; }
        }

        // Check to see if CapacityLimits property is set
        internal bool IsSetCapacityLimits()
        {
            return this._capacityLimits != null && (this._capacityLimits.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceEnvironmentName. 
        /// <para>
        /// The name for the service environment. It can be up to 128 characters long and can
        /// contain letters, numbers, hyphens (-), and underscores (_).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceEnvironmentName
        {
            get { return this._serviceEnvironmentName; }
            set { this._serviceEnvironmentName = value; }
        }

        // Check to see if ServiceEnvironmentName property is set
        internal bool IsSetServiceEnvironmentName()
        {
            return this._serviceEnvironmentName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceEnvironmentType. 
        /// <para>
        /// The type of service environment. For SageMaker Training jobs, specify <c>SAGEMAKER_TRAINING</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceEnvironmentType ServiceEnvironmentType
        {
            get { return this._serviceEnvironmentType; }
            set { this._serviceEnvironmentType = value; }
        }

        // Check to see if ServiceEnvironmentType property is set
        internal bool IsSetServiceEnvironmentType()
        {
            return this._serviceEnvironmentType != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the service environment. Valid values are <c>ENABLED</c> and <c>DISABLED</c>.
        /// The default value is <c>ENABLED</c>.
        /// </para>
        /// </summary>
        public ServiceEnvironmentState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you apply to the service environment to help you categorize and organize
        /// your resources. Each tag consists of a key and an optional value. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/using-tags.html">Tagging
        /// your Batch resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}