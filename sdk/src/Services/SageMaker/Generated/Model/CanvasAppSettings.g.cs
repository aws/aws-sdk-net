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
    /// The SageMaker Canvas application settings.
    /// </summary>
    public partial class CanvasAppSettings
    {
        /// <summary>
        /// Gets and sets the property DirectDeploySettings. 
        /// <para>
        /// The model deployment settings for the SageMaker Canvas application.
        /// </para>
        /// </summary>
        public DirectDeploySettings DirectDeploySettings { get; set; }

        /// <summary>
        /// Checks to see if the DirectDeploySettings property is set.
        /// </summary>
        internal bool IsSetDirectDeploySettings() => this.DirectDeploySettings != null;

        /// <summary>
        /// Gets and sets the property EmrServerlessSettings. 
        /// <para>
        /// The settings for running Amazon EMR Serverless data processing jobs in SageMaker Canvas.
        /// </para>
        /// </summary>
        public EmrServerlessSettings EmrServerlessSettings { get; set; }

        /// <summary>
        /// Checks to see if the EmrServerlessSettings property is set.
        /// </summary>
        internal bool IsSetEmrServerlessSettings() => this.EmrServerlessSettings != null;

        /// <summary>
        /// Gets and sets the property GenerativeAiSettings. 
        /// <para>
        /// The generative AI settings for the SageMaker Canvas application.
        /// </para>
        /// </summary>
        public GenerativeAiSettings GenerativeAiSettings { get; set; }

        /// <summary>
        /// Checks to see if the GenerativeAiSettings property is set.
        /// </summary>
        internal bool IsSetGenerativeAiSettings() => this.GenerativeAiSettings != null;

        /// <summary>
        /// Gets and sets the property IdentityProviderOAuthSettings. 
        /// <para>
        /// The settings for connecting to an external data source with OAuth.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<IdentityProviderOAuthSetting> IdentityProviderOAuthSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<IdentityProviderOAuthSetting>() : null;

        /// <summary>
        /// Checks to see if the IdentityProviderOAuthSettings property is set.
        /// </summary>
        internal bool IsSetIdentityProviderOAuthSettings() => this.IdentityProviderOAuthSettings != null && (this.IdentityProviderOAuthSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KendraSettings. 
        /// <para>
        /// The settings for document querying.
        /// </para>
        /// </summary>
        public KendraSettings KendraSettings { get; set; }

        /// <summary>
        /// Checks to see if the KendraSettings property is set.
        /// </summary>
        internal bool IsSetKendraSettings() => this.KendraSettings != null;

        /// <summary>
        /// Gets and sets the property ModelRegisterSettings. 
        /// <para>
        /// The model registry settings for the SageMaker Canvas application.
        /// </para>
        /// </summary>
        public ModelRegisterSettings ModelRegisterSettings { get; set; }

        /// <summary>
        /// Checks to see if the ModelRegisterSettings property is set.
        /// </summary>
        internal bool IsSetModelRegisterSettings() => this.ModelRegisterSettings != null;

        /// <summary>
        /// Gets and sets the property TimeSeriesForecastingSettings. 
        /// <para>
        /// Time series forecast settings for the SageMaker Canvas application.
        /// </para>
        /// </summary>
        public TimeSeriesForecastingSettings TimeSeriesForecastingSettings { get; set; }

        /// <summary>
        /// Checks to see if the TimeSeriesForecastingSettings property is set.
        /// </summary>
        internal bool IsSetTimeSeriesForecastingSettings() => this.TimeSeriesForecastingSettings != null;

        /// <summary>
        /// Gets and sets the property WorkspaceSettings. 
        /// <para>
        /// The workspace settings for the SageMaker Canvas application.
        /// </para>
        /// </summary>
        public WorkspaceSettings WorkspaceSettings { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceSettings property is set.
        /// </summary>
        internal bool IsSetWorkspaceSettings() => this.WorkspaceSettings != null;
    }
}
