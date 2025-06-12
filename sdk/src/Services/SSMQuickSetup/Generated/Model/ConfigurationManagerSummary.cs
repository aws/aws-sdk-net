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
    /// A summary of a Quick Setup configuration manager.
    /// </summary>
    public partial class ConfigurationManagerSummary
    {
        private List<ConfigurationDefinitionSummary> _configurationDefinitionSummaries = AWSConfigs.InitializeCollections ? new List<ConfigurationDefinitionSummary>() : null;
        private string _description;
        private string _managerArn;
        private string _name;
        private List<StatusSummary> _statusSummaries = AWSConfigs.InitializeCollections ? new List<StatusSummary>() : null;

        /// <summary>
        /// Gets and sets the property ConfigurationDefinitionSummaries. 
        /// <para>
        /// A summary of the Quick Setup configuration definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConfigurationDefinitionSummary> ConfigurationDefinitionSummaries
        {
            get { return this._configurationDefinitionSummaries; }
            set { this._configurationDefinitionSummaries = value; }
        }

        // Check to see if ConfigurationDefinitionSummaries property is set
        internal bool IsSetConfigurationDefinitionSummaries()
        {
            return this._configurationDefinitionSummaries != null && (this._configurationDefinitionSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the configuration.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ManagerArn. 
        /// <para>
        /// The ARN of the Quick Setup configuration.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the configuration
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property StatusSummaries. 
        /// <para>
        /// Summaries of the state of the configuration manager. These summaries include an aggregate
        /// of the statuses from the configuration definition associated with the configuration
        /// manager. This includes deployment statuses, association statuses, drift statuses,
        /// health checks, and more.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StatusSummary> StatusSummaries
        {
            get { return this._statusSummaries; }
            set { this._statusSummaries = value; }
        }

        // Check to see if StatusSummaries property is set
        internal bool IsSetStatusSummaries()
        {
            return this._statusSummaries != null && (this._statusSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}