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
    /// The SageMaker Canvas application settings.
    /// </summary>
    public partial class CanvasAppSettings
    {
        private ModelRegisterSettings _modelRegisterSettings;
        private TimeSeriesForecastingSettings _timeSeriesForecastingSettings;
        private WorkspaceSettings _workspaceSettings;

        /// <summary>
        /// Gets and sets the property ModelRegisterSettings. 
        /// <para>
        /// The model registry settings for the SageMaker Canvas application.
        /// </para>
        /// </summary>
        public ModelRegisterSettings ModelRegisterSettings
        {
            get { return this._modelRegisterSettings; }
            set { this._modelRegisterSettings = value; }
        }

        // Check to see if ModelRegisterSettings property is set
        internal bool IsSetModelRegisterSettings()
        {
            return this._modelRegisterSettings != null;
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesForecastingSettings. 
        /// <para>
        /// Time series forecast settings for the Canvas application.
        /// </para>
        /// </summary>
        public TimeSeriesForecastingSettings TimeSeriesForecastingSettings
        {
            get { return this._timeSeriesForecastingSettings; }
            set { this._timeSeriesForecastingSettings = value; }
        }

        // Check to see if TimeSeriesForecastingSettings property is set
        internal bool IsSetTimeSeriesForecastingSettings()
        {
            return this._timeSeriesForecastingSettings != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceSettings. 
        /// <para>
        /// The workspace settings for the SageMaker Canvas application.
        /// </para>
        /// </summary>
        public WorkspaceSettings WorkspaceSettings
        {
            get { return this._workspaceSettings; }
            set { this._workspaceSettings = value; }
        }

        // Check to see if WorkspaceSettings property is set
        internal bool IsSetWorkspaceSettings()
        {
            return this._workspaceSettings != null;
        }

    }
}