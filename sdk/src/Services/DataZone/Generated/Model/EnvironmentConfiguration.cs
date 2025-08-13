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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
        private List<string> _accountPools = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AwsAccount _awsAccount;
        private Region _awsRegion;
        private EnvironmentConfigurationParametersDetails _configurationParameters;
        private DeploymentMode _deploymentMode;
        private int? _deploymentOrder;
        private string _description;
        private string _environmentBlueprintId;
        private string _id;
        private string _name;

        /// <summary>
        /// Gets and sets the property AccountPools. 
        /// <para>
        /// The account pools used by a custom project profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> AccountPools
        {
            get { return this._accountPools; }
            set { this._accountPools = value; }
        }

        // Check to see if AccountPools property is set
        internal bool IsSetAccountPools()
        {
            return this._accountPools != null && (this._accountPools.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AwsAccount. 
        /// <para>
        /// The Amazon Web Services account of the environment.
        /// </para>
        /// </summary>
        public AwsAccount AwsAccount
        {
            get { return this._awsAccount; }
            set { this._awsAccount = value; }
        }

        // Check to see if AwsAccount property is set
        internal bool IsSetAwsAccount()
        {
            return this._awsAccount != null;
        }

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The Amazon Web Services Region of the environment.
        /// </para>
        /// </summary>
        public Region AwsRegion
        {
            get { return this._awsRegion; }
            set { this._awsRegion = value; }
        }

        // Check to see if AwsRegion property is set
        internal bool IsSetAwsRegion()
        {
            return this._awsRegion != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationParameters. 
        /// <para>
        /// The configuration parameters of the environment.
        /// </para>
        /// </summary>
        public EnvironmentConfigurationParametersDetails ConfigurationParameters
        {
            get { return this._configurationParameters; }
            set { this._configurationParameters = value; }
        }

        // Check to see if ConfigurationParameters property is set
        internal bool IsSetConfigurationParameters()
        {
            return this._configurationParameters != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentMode. 
        /// <para>
        /// The deployment mode of the environment.
        /// </para>
        /// </summary>
        public DeploymentMode DeploymentMode
        {
            get { return this._deploymentMode; }
            set { this._deploymentMode = value; }
        }

        // Check to see if DeploymentMode property is set
        internal bool IsSetDeploymentMode()
        {
            return this._deploymentMode != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentOrder. 
        /// <para>
        /// The deployment order of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16)]
        public int? DeploymentOrder
        {
            get { return this._deploymentOrder; }
            set { this._deploymentOrder = value; }
        }

        // Check to see if DeploymentOrder property is set
        internal bool IsSetDeploymentOrder()
        {
            return this._deploymentOrder.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The environment description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentBlueprintId. 
        /// <para>
        /// The environment blueprint ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EnvironmentBlueprintId
        {
            get { return this._environmentBlueprintId; }
            set { this._environmentBlueprintId = value; }
        }

        // Check to see if EnvironmentBlueprintId property is set
        internal bool IsSetEnvironmentBlueprintId()
        {
            return this._environmentBlueprintId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The environment ID.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The environment name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}