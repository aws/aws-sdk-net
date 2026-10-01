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

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApplicationComponentConfig operation. Updates
    /// the configuration of an application component.
    /// </summary>
    public partial class UpdateApplicationComponentConfigRequest : AmazonMigrationHubStrategyRecommendationsRequest
    {
        /// <summary>
        /// Gets and sets the property AppType. 
        /// <para>
        /// The type of known component.
        /// </para>
        /// </summary>
        public AppType AppType { get; set; }

        /// <summary>
        /// Checks to see if the AppType property is set.
        /// </summary>
        internal bool IsSetAppType() => this.AppType != null;

        /// <summary>
        /// Gets and sets the property ApplicationComponentId. 
        /// <para>
        ///  The ID of the application component. The ID is unique within an AWS account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 44)]
        public string ApplicationComponentId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationComponentId property is set.
        /// </summary>
        internal bool IsSetApplicationComponentId() => this.ApplicationComponentId != null;

        /// <summary>
        /// Gets and sets the property ConfigureOnly. 
        /// <para>
        /// Update the configuration request of an application component. If it is set to true,
        /// the source code and/or database credentials are updated. If it is set to false, the
        /// source code and/or database credentials are updated and an analysis is initiated.
        /// </para>
        /// </summary>
        public bool? ConfigureOnly { get; set; }

        /// <summary>
        /// Checks to see if the ConfigureOnly property is set.
        /// </summary>
        internal bool IsSetConfigureOnly() => this.ConfigureOnly.HasValue;

        /// <summary>
        /// Gets and sets the property InclusionStatus. 
        /// <para>
        ///  Indicates whether the application component has been included for server recommendation
        /// or not. 
        /// </para>
        /// </summary>
        public InclusionStatus InclusionStatus { get; set; }

        /// <summary>
        /// Checks to see if the InclusionStatus property is set.
        /// </summary>
        internal bool IsSetInclusionStatus() => this.InclusionStatus != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerKey. 
        /// <para>
        ///  Database credentials. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 512)]
        public string SecretsManagerKey { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerKey property is set.
        /// </summary>
        internal bool IsSetSecretsManagerKey() => this.SecretsManagerKey != null;

        /// <summary>
        /// Gets and sets the property SourceCodeList. 
        /// <para>
        ///  The list of source code configurations to update for the application component. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SourceCode> SourceCodeList { get; set; } = AWSConfigs.InitializeCollections ? new List<SourceCode>() : null;

        /// <summary>
        /// Checks to see if the SourceCodeList property is set.
        /// </summary>
        internal bool IsSetSourceCodeList() => this.SourceCodeList != null && (this.SourceCodeList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StrategyOption. 
        /// <para>
        ///  The preferred strategy options for the application component. Use values from the
        /// <a>GetApplicationComponentStrategies</a> response. 
        /// </para>
        /// </summary>
        public StrategyOption StrategyOption { get; set; }

        /// <summary>
        /// Checks to see if the StrategyOption property is set.
        /// </summary>
        internal bool IsSetStrategyOption() => this.StrategyOption != null;
    }
}
