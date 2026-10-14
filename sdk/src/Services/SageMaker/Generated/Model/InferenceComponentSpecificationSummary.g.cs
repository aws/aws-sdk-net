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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Details about the resources that are deployed with this inference component.
    /// </summary>
    public partial class InferenceComponentSpecificationSummary
    {
        /// <summary>
        /// Gets and sets the property BaseInferenceComponentName. 
        /// <para>
        /// The name of the base inference component that contains this inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string BaseInferenceComponentName { get; set; }

        /// <summary>
        /// Checks to see if the BaseInferenceComponentName property is set.
        /// </summary>
        internal bool IsSetBaseInferenceComponentName() => this.BaseInferenceComponentName != null;

        /// <summary>
        /// Gets and sets the property ComputeResourceRequirements. 
        /// <para>
        /// The compute resources allocated to run the model, plus any adapter models, that you
        /// assign to the inference component.
        /// </para>
        /// </summary>
        public InferenceComponentComputeResourceRequirements ComputeResourceRequirements { get; set; }

        /// <summary>
        /// Checks to see if the ComputeResourceRequirements property is set.
        /// </summary>
        internal bool IsSetComputeResourceRequirements() => this.ComputeResourceRequirements != null;

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// Details about the container that provides the runtime environment for the model that
        /// is deployed with the inference component.
        /// </para>
        /// </summary>
        public InferenceComponentContainerSpecificationSummary Container { get; set; }

        /// <summary>
        /// Checks to see if the Container property is set.
        /// </summary>
        internal bool IsSetContainer() => this.Container != null;

        /// <summary>
        /// Gets and sets the property DataCacheConfig. 
        /// <para>
        /// Settings that affect how the inference component caches data.
        /// </para>
        /// </summary>
        public InferenceComponentDataCacheConfigSummary DataCacheConfig { get; set; }

        /// <summary>
        /// Checks to see if the DataCacheConfig property is set.
        /// </summary>
        internal bool IsSetDataCacheConfig() => this.DataCacheConfig != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The ML compute instance type associated with this inference component specification.
        /// </para>
        /// </summary>
        public ProductionVariantInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the SageMaker AI model object that is deployed with the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property SchedulingConfig. 
        /// <para>
        /// The scheduling configuration that determines how inference component copies are placed
        /// across available instances when copies are added or removed.
        /// </para>
        /// </summary>
        public InferenceComponentSchedulingConfig SchedulingConfig { get; set; }

        /// <summary>
        /// Checks to see if the SchedulingConfig property is set.
        /// </summary>
        internal bool IsSetSchedulingConfig() => this.SchedulingConfig != null;

        /// <summary>
        /// Gets and sets the property StartupParameters. 
        /// <para>
        /// Settings that take effect while the model container starts up.
        /// </para>
        /// </summary>
        public InferenceComponentStartupParameters StartupParameters { get; set; }

        /// <summary>
        /// Checks to see if the StartupParameters property is set.
        /// </summary>
        internal bool IsSetStartupParameters() => this.StartupParameters != null;
    }
}
