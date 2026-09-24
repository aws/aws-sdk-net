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

namespace Amazon.SSMQuickSetup.Model
{
    /// <summary>
    /// The definition of a Quick Setup configuration.
    /// </summary>
    public partial class ConfigurationDefinition
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the configuration definition.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LocalDeploymentAdministrationRoleArn. 
        /// <para>
        /// The ARN of the IAM role used to administrate local configuration deployments.
        /// </para>
        /// </summary>
        public string LocalDeploymentAdministrationRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the LocalDeploymentAdministrationRoleArn property is set.
        /// </summary>
        internal bool IsSetLocalDeploymentAdministrationRoleArn() => this.LocalDeploymentAdministrationRoleArn != null;

        /// <summary>
        /// Gets and sets the property LocalDeploymentExecutionRoleName. 
        /// <para>
        /// The name of the IAM role used to deploy local configurations.
        /// </para>
        /// </summary>
        public string LocalDeploymentExecutionRoleName { get; set; }

        /// <summary>
        /// Checks to see if the LocalDeploymentExecutionRoleName property is set.
        /// </summary>
        internal bool IsSetLocalDeploymentExecutionRoleName() => this.LocalDeploymentExecutionRoleName != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of key-value pairs containing the required parameters for the configuration
        /// type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, string> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the Quick Setup configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property TypeVersion. 
        /// <para>
        /// The version of the Quick Setup type used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TypeVersion { get; set; }

        /// <summary>
        /// Checks to see if the TypeVersion property is set.
        /// </summary>
        internal bool IsSetTypeVersion() => this.TypeVersion != null;
    }
}
