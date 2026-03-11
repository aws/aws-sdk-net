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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrainingPlan operation.
    /// Creates a new training plan in SageMaker to reserve compute capacity.
    /// 
    ///  
    /// <para>
    /// Amazon SageMaker Training Plan is a capability within SageMaker that allows customers
    /// to reserve and manage GPU capacity for large-scale AI model training. It provides
    /// a way to secure predictable access to computational resources within specific timelines
    /// and budgets, without the need to manage underlying infrastructure. 
    /// </para>
    ///  
    /// <para>
    ///  <b>How it works</b> 
    /// </para>
    ///  
    /// <para>
    /// Plans can be created for specific resources such as SageMaker Training Jobs or SageMaker
    /// HyperPod clusters, automatically provisioning resources, setting up infrastructure,
    /// executing workloads, and handling infrastructure failures.
    /// </para>
    ///  
    /// <para>
    ///  <b>Plan creation workflow</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Users search for available plan offerings based on their requirements (e.g., instance
    /// type, count, start time, duration) using the <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_SearchTrainingPlanOfferings.html">SearchTrainingPlanOfferings</a>
    /// </c> API operation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// They create a plan that best matches their needs using the ID of the plan offering
    /// they want to use. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// After successful upfront payment, the plan's status becomes <c>Scheduled</c>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The plan can be used to:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Queue training jobs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Allocate to an instance group of a SageMaker HyperPod cluster. 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// When the plan start date arrives, it becomes <c>Active</c>. Based on available reserved
    /// capacity:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Training jobs are launched.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Instance groups are provisioned.
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    ///  <b>Plan composition</b> 
    /// </para>
    ///  
    /// <para>
    /// A plan can consist of one or more Reserved Capacities, each defined by a specific
    /// instance type, quantity, Availability Zone, duration, and start and end times. For
    /// more information about Reserved Capacity, see <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ReservedCapacitySummary.html">ReservedCapacitySummary</a>
    /// </c>.
    /// </para>
    /// </summary>
    public partial class CreateTrainingPlanRequest : AmazonSageMakerRequest
    {
        private int? _spareInstanceCountPerUltraServer;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _trainingPlanName;
        private string _trainingPlanOfferingId;

        /// <summary>
        /// Gets and sets the property SpareInstanceCountPerUltraServer. 
        /// <para>
        /// Number of spare instances to reserve per UltraServer for enhanced resiliency. Default
        /// is 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? SpareInstanceCountPerUltraServer
        {
            get { return this._spareInstanceCountPerUltraServer; }
            set { this._spareInstanceCountPerUltraServer = value; }
        }

        // Check to see if SpareInstanceCountPerUltraServer property is set
        internal bool IsSetSpareInstanceCountPerUltraServer()
        {
            return this._spareInstanceCountPerUltraServer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs to apply to this training plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrainingPlanName. 
        /// <para>
        /// The name of the training plan to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string TrainingPlanName
        {
            get { return this._trainingPlanName; }
            set { this._trainingPlanName = value; }
        }

        // Check to see if TrainingPlanName property is set
        internal bool IsSetTrainingPlanName()
        {
            return this._trainingPlanName != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingPlanOfferingId. 
        /// <para>
        /// The unique identifier of the training plan offering to use for creating this plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TrainingPlanOfferingId
        {
            get { return this._trainingPlanOfferingId; }
            set { this._trainingPlanOfferingId = value; }
        }

        // Check to see if TrainingPlanOfferingId property is set
        internal bool IsSetTrainingPlanOfferingId()
        {
            return this._trainingPlanOfferingId != null;
        }

    }
}