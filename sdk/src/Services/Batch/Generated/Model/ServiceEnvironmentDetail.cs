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
    /// Detailed information about a service environment, including its configuration, state,
    /// and capacity limits.
    /// </summary>
    public partial class ServiceEnvironmentDetail
    {
        private List<CapacityLimit> _capacityLimits = AWSConfigs.InitializeCollections ? new List<CapacityLimit>() : null;
        private string _serviceEnvironmentArn;
        private string _serviceEnvironmentName;
        private ServiceEnvironmentType _serviceEnvironmentType;
        private ServiceEnvironmentState _state;
        private ServiceEnvironmentStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CapacityLimits. 
        /// <para>
        /// The capacity limits for the service environment. This defines the maximum resources
        /// that can be used by service jobs in this environment.
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
        /// Gets and sets the property ServiceEnvironmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceEnvironmentArn
        {
            get { return this._serviceEnvironmentArn; }
            set { this._serviceEnvironmentArn = value; }
        }

        // Check to see if ServiceEnvironmentArn property is set
        internal bool IsSetServiceEnvironmentArn()
        {
            return this._serviceEnvironmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceEnvironmentName. 
        /// <para>
        /// The name of the service environment.
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
        /// The type of service environment. For SageMaker Training jobs, this value is <c>SAGEMAKER_TRAINING</c>.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the service environment.
        /// </para>
        /// </summary>
        public ServiceEnvironmentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the service environment. Each tag consists of a key and an
        /// optional value. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/using-tags.html">Tagging
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