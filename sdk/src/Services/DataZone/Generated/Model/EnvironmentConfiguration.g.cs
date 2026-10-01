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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The configuration of an environment.
    /// </summary>
    public partial class EnvironmentConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccountPools. 
        /// <para>
        /// The account pools used by a custom project profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> AccountPools { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccountPools property is set.
        /// </summary>
        internal bool IsSetAccountPools() => this.AccountPools != null && (this.AccountPools.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AwsAccount. 
        /// <para>
        /// The Amazon Web Services account of the environment.
        /// </para>
        /// </summary>
        public AwsAccount AwsAccount { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccount property is set.
        /// </summary>
        internal bool IsSetAwsAccount() => this.AwsAccount != null;

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The Amazon Web Services Region of the environment.
        /// </para>
        /// </summary>
        public Region AwsRegion { get; set; }

        /// <summary>
        /// Checks to see if the AwsRegion property is set.
        /// </summary>
        internal bool IsSetAwsRegion() => this.AwsRegion != null;

        /// <summary>
        /// Gets and sets the property ConfigurationParameters. 
        /// <para>
        /// The configuration parameters of the environment.
        /// </para>
        /// </summary>
        public EnvironmentConfigurationParametersDetails ConfigurationParameters { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationParameters property is set.
        /// </summary>
        internal bool IsSetConfigurationParameters() => this.ConfigurationParameters != null;

        /// <summary>
        /// Gets and sets the property DeploymentMode. 
        /// <para>
        /// The deployment mode of the environment.
        /// </para>
        /// </summary>
        public DeploymentMode DeploymentMode { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentMode property is set.
        /// </summary>
        internal bool IsSetDeploymentMode() => this.DeploymentMode != null;

        /// <summary>
        /// Gets and sets the property DeploymentOrder. 
        /// <para>
        /// The deployment order of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 16)]
        public int? DeploymentOrder { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentOrder property is set.
        /// </summary>
        internal bool IsSetDeploymentOrder() => this.DeploymentOrder.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The environment description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnvironmentBlueprintId. 
        /// <para>
        /// The environment blueprint ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EnvironmentBlueprintId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentBlueprintId property is set.
        /// </summary>
        internal bool IsSetEnvironmentBlueprintId() => this.EnvironmentBlueprintId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The environment ID.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The environment name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
