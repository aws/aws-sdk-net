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
 * Do not modify this file. This file is generated from the ssm-quicksetup-2018-05-10.normal.json service model.
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
namespace Amazon.SSMQuickSetup.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConfigurationDefinition operation.
    /// Updates a Quick Setup configuration definition.
    /// </summary>
    public partial class UpdateConfigurationDefinitionRequest : AmazonSSMQuickSetupRequest
    {
        private string _id;
        private string _localDeploymentAdministrationRoleArn;
        private string _localDeploymentExecutionRoleName;
        private string _managerArn;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _typeVersion;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the configuration definition you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LocalDeploymentAdministrationRoleArn. 
        /// <para>
        /// The ARN of the IAM role used to administrate local configuration deployments.
        /// </para>
        /// </summary>
        public string LocalDeploymentAdministrationRoleArn
        {
            get { return this._localDeploymentAdministrationRoleArn; }
            set { this._localDeploymentAdministrationRoleArn = value; }
        }

        // Check to see if LocalDeploymentAdministrationRoleArn property is set
        internal bool IsSetLocalDeploymentAdministrationRoleArn()
        {
            return this._localDeploymentAdministrationRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property LocalDeploymentExecutionRoleName. 
        /// <para>
        /// The name of the IAM role used to deploy local configurations.
        /// </para>
        /// </summary>
        public string LocalDeploymentExecutionRoleName
        {
            get { return this._localDeploymentExecutionRoleName; }
            set { this._localDeploymentExecutionRoleName = value; }
        }

        // Check to see if LocalDeploymentExecutionRoleName property is set
        internal bool IsSetLocalDeploymentExecutionRoleName()
        {
            return this._localDeploymentExecutionRoleName != null;
        }

        /// <summary>
        /// Gets and sets the property ManagerArn. 
        /// <para>
        /// The ARN of the configuration manager associated with the definition to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ManagerArn
        {
            get { return this._managerArn; }
            set { this._managerArn = value; }
        }

        // Check to see if ManagerArn property is set
        internal bool IsSetManagerArn()
        {
            return this._managerArn != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters for the configuration definition type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TypeVersion. 
        /// <para>
        /// The version of the Quick Setup type to use.
        /// </para>
        /// </summary>
        public string TypeVersion
        {
            get { return this._typeVersion; }
            set { this._typeVersion = value; }
        }

        // Check to see if TypeVersion property is set
        internal bool IsSetTypeVersion()
        {
            return this._typeVersion != null;
        }

    }
}