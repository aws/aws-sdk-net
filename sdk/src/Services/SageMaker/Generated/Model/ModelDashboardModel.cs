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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A model displayed in the Amazon SageMaker Model Dashboard.
    /// </summary>
    public partial class ModelDashboardModel
    {
        private List<ModelDashboardEndpoint> _endpoints = new List<ModelDashboardEndpoint>();
        private TransformJob _lastBatchTransformJob;
        private Model _model;
        private ModelDashboardModelCard _modelCard;
        private List<ModelDashboardMonitoringSchedule> _monitoringSchedules = new List<ModelDashboardMonitoringSchedule>();

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The endpoints that host a model.
        /// </para>
        /// </summary>
        public List<ModelDashboardEndpoint> Endpoints
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }

        // Check to see if Endpoints property is set
        internal bool IsSetEndpoints()
        {
            return this._endpoints != null && this._endpoints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastBatchTransformJob.
        /// </summary>
        public TransformJob LastBatchTransformJob
        {
            get { return this._lastBatchTransformJob; }
            set { this._lastBatchTransformJob = value; }
        }

        // Check to see if LastBatchTransformJob property is set
        internal bool IsSetLastBatchTransformJob()
        {
            return this._lastBatchTransformJob != null;
        }

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// A model displayed in the Model Dashboard.
        /// </para>
        /// </summary>
        public Model Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        // Check to see if Model property is set
        internal bool IsSetModel()
        {
            return this._model != null;
        }

        /// <summary>
        /// Gets and sets the property ModelCard. 
        /// <para>
        /// The model card for a model.
        /// </para>
        /// </summary>
        public ModelDashboardModelCard ModelCard
        {
            get { return this._modelCard; }
            set { this._modelCard = value; }
        }

        // Check to see if ModelCard property is set
        internal bool IsSetModelCard()
        {
            return this._modelCard != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringSchedules. 
        /// <para>
        /// The monitoring schedules for a model.
        /// </para>
        /// </summary>
        public List<ModelDashboardMonitoringSchedule> MonitoringSchedules
        {
            get { return this._monitoringSchedules; }
            set { this._monitoringSchedules = value; }
        }

        // Check to see if MonitoringSchedules property is set
        internal bool IsSetMonitoringSchedules()
        {
            return this._monitoringSchedules != null && this._monitoringSchedules.Count > 0; 
        }

    }
}