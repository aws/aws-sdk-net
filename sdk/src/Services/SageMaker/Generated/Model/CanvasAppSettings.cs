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
    /// The SageMaker Canvas application settings.
    /// </summary>
    public partial class CanvasAppSettings
    {
        private DirectDeploySettings _directDeploySettings;
        private EmrServerlessSettings _emrServerlessSettings;
        private GenerativeAiSettings _generativeAiSettings;
        private List<IdentityProviderOAuthSetting> _identityProviderOAuthSettings = AWSConfigs.InitializeCollections ? new List<IdentityProviderOAuthSetting>() : null;
        private KendraSettings _kendraSettings;
        private ModelRegisterSettings _modelRegisterSettings;
        private TimeSeriesForecastingSettings _timeSeriesForecastingSettings;
        private WorkspaceSettings _workspaceSettings;

        /// <summary>
        /// Gets and sets the property DirectDeploySettings. 
        /// <para>
        /// The model deployment settings for the SageMaker Canvas application.
        /// </para>
        /// </summary>
        public DirectDeploySettings DirectDeploySettings
        {
            get { return this._directDeploySettings; }
            set { this._directDeploySettings = value; }
        }

        // Check to see if DirectDeploySettings property is set
        internal bool IsSetDirectDeploySettings()
        {
            return this._directDeploySettings != null;
        }

        /// <summary>
        /// Gets and sets the property EmrServerlessSettings. 
        /// <para>
        /// The settings for running Amazon EMR Serverless data processing jobs in SageMaker Canvas.
        /// </para>
        /// </summary>
        public EmrServerlessSettings EmrServerlessSettings
        {
            get { return this._emrServerlessSettings; }
            set { this._emrServerlessSettings = value; }
        }

        // Check to see if EmrServerlessSettings property is set
        internal bool IsSetEmrServerlessSettings()
        {
            return this._emrServerlessSettings != null;
        }

        /// <summary>
        /// Gets and sets the property GenerativeAiSettings. 
        /// <para>
        /// The generative AI settings for the SageMaker Canvas application.
        /// </para>
        /// </summary>
        public GenerativeAiSettings GenerativeAiSettings
        {
            get { return this._generativeAiSettings; }
            set { this._generativeAiSettings = value; }
        }

        // Check to see if GenerativeAiSettings property is set
        internal bool IsSetGenerativeAiSettings()
        {
            return this._generativeAiSettings != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderOAuthSettings. 
        /// <para>
        /// The settings for connecting to an external data source with OAuth.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<IdentityProviderOAuthSetting> IdentityProviderOAuthSettings
        {
            get { return this._identityProviderOAuthSettings; }
            set { this._identityProviderOAuthSettings = value; }
        }

        // Check to see if IdentityProviderOAuthSettings property is set
        internal bool IsSetIdentityProviderOAuthSettings()
        {
            return this._identityProviderOAuthSettings != null && (this._identityProviderOAuthSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KendraSettings. 
        /// <para>
        /// The settings for document querying.
        /// </para>
        /// </summary>
        public KendraSettings KendraSettings
        {
            get { return this._kendraSettings; }
            set { this._kendraSettings = value; }
        }

        // Check to see if KendraSettings property is set
        internal bool IsSetKendraSettings()
        {
            return this._kendraSettings != null;
        }

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
        /// Time series forecast settings for the SageMaker Canvas application.
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