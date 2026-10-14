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
    /// A model displayed in the Amazon SageMaker Model Dashboard.
    /// </summary>
    public partial class ModelDashboardModel
    {
        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The endpoints that host a model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ModelDashboardEndpoint> Endpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<ModelDashboardEndpoint>() : null;

        /// <summary>
        /// Checks to see if the Endpoints property is set.
        /// </summary>
        internal bool IsSetEndpoints() => this.Endpoints != null && (this.Endpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastBatchTransformJob.
        /// </summary>
        public TransformJob LastBatchTransformJob { get; set; }

        /// <summary>
        /// Checks to see if the LastBatchTransformJob property is set.
        /// </summary>
        internal bool IsSetLastBatchTransformJob() => this.LastBatchTransformJob != null;

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// A model displayed in the Model Dashboard.
        /// </para>
        /// </summary>
        public Model Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property ModelCard. 
        /// <para>
        /// The model card for a model.
        /// </para>
        /// </summary>
        public ModelDashboardModelCard ModelCard { get; set; }

        /// <summary>
        /// Checks to see if the ModelCard property is set.
        /// </summary>
        internal bool IsSetModelCard() => this.ModelCard != null;

        /// <summary>
        /// Gets and sets the property MonitoringSchedules. 
        /// <para>
        /// The monitoring schedules for a model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ModelDashboardMonitoringSchedule> MonitoringSchedules { get; set; } = AWSConfigs.InitializeCollections ? new List<ModelDashboardMonitoringSchedule>() : null;

        /// <summary>
        /// Checks to see if the MonitoringSchedules property is set.
        /// </summary>
        internal bool IsSetMonitoringSchedules() => this.MonitoringSchedules != null && (this.MonitoringSchedules.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
