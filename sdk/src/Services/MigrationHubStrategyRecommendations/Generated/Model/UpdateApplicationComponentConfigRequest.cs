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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApplicationComponentConfig operation.
    /// Updates the configuration of an application component.
    /// </summary>
    public partial class UpdateApplicationComponentConfigRequest : AmazonMigrationHubStrategyRecommendationsRequest
    {
        private string _applicationComponentId;
        private AppType _appType;
        private bool? _configureOnly;
        private InclusionStatus _inclusionStatus;
        private string _secretsManagerKey;
        private List<SourceCode> _sourceCodeList = new List<SourceCode>();
        private StrategyOption _strategyOption;

        /// <summary>
        /// Gets and sets the property ApplicationComponentId. 
        /// <para>
        ///  The ID of the application component. The ID is unique within an AWS account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=44)]
        public string ApplicationComponentId
        {
            get { return this._applicationComponentId; }
            set { this._applicationComponentId = value; }
        }

        // Check to see if ApplicationComponentId property is set
        internal bool IsSetApplicationComponentId()
        {
            return this._applicationComponentId != null;
        }

        /// <summary>
        /// Gets and sets the property AppType. 
        /// <para>
        /// The type of known component.
        /// </para>
        /// </summary>
        public AppType AppType
        {
            get { return this._appType; }
            set { this._appType = value; }
        }

        // Check to see if AppType property is set
        internal bool IsSetAppType()
        {
            return this._appType != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigureOnly. 
        /// <para>
        /// Update the configuration request of an application component. If it is set to true,
        /// the source code and/or database credentials are updated. If it is set to false, the
        /// source code and/or database credentials are updated and an analysis is initiated.
        /// </para>
        /// </summary>
        public bool ConfigureOnly
        {
            get { return this._configureOnly.GetValueOrDefault(); }
            set { this._configureOnly = value; }
        }

        // Check to see if ConfigureOnly property is set
        internal bool IsSetConfigureOnly()
        {
            return this._configureOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InclusionStatus. 
        /// <para>
        ///  Indicates whether the application component has been included for server recommendation
        /// or not. 
        /// </para>
        /// </summary>
        public InclusionStatus InclusionStatus
        {
            get { return this._inclusionStatus; }
            set { this._inclusionStatus = value; }
        }

        // Check to see if InclusionStatus property is set
        internal bool IsSetInclusionStatus()
        {
            return this._inclusionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerKey. 
        /// <para>
        ///  Database credentials. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string SecretsManagerKey
        {
            get { return this._secretsManagerKey; }
            set { this._secretsManagerKey = value; }
        }

        // Check to see if SecretsManagerKey property is set
        internal bool IsSetSecretsManagerKey()
        {
            return this._secretsManagerKey != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCodeList. 
        /// <para>
        ///  The list of source code configurations to update for the application component. 
        /// </para>
        /// </summary>
        public List<SourceCode> SourceCodeList
        {
            get { return this._sourceCodeList; }
            set { this._sourceCodeList = value; }
        }

        // Check to see if SourceCodeList property is set
        internal bool IsSetSourceCodeList()
        {
            return this._sourceCodeList != null && this._sourceCodeList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StrategyOption. 
        /// <para>
        ///  The preferred strategy options for the application component. Use values from the
        /// <a>GetApplicationComponentStrategies</a> response. 
        /// </para>
        /// </summary>
        public StrategyOption StrategyOption
        {
            get { return this._strategyOption; }
            set { this._strategyOption = value; }
        }

        // Check to see if StrategyOption property is set
        internal bool IsSetStrategyOption()
        {
            return this._strategyOption != null;
        }

    }
}