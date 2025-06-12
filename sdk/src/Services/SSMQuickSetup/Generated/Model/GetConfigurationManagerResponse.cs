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
    /// This is the response object from the GetConfigurationManager operation.
    /// </summary>
    public partial class GetConfigurationManagerResponse : AmazonWebServiceResponse
    {
        private List<ConfigurationDefinition> _configurationDefinitions = AWSConfigs.InitializeCollections ? new List<ConfigurationDefinition>() : null;
        private DateTime? _createdAt;
        private string _description;
        private DateTime? _lastModifiedAt;
        private string _managerArn;
        private string _name;
        private List<StatusSummary> _statusSummaries = AWSConfigs.InitializeCollections ? new List<StatusSummary>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ConfigurationDefinitions. 
        /// <para>
        /// The configuration definitions association with the configuration manager.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConfigurationDefinition> ConfigurationDefinitions
        {
            get { return this._configurationDefinitions; }
            set { this._configurationDefinitions = value; }
        }

        // Check to see if ConfigurationDefinitions property is set
        internal bool IsSetConfigurationDefinitions()
        {
            return this._configurationDefinitions != null && (this._configurationDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The datetime stamp when the configuration manager was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the configuration manager.
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
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The datetime stamp when the configuration manager was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedAt
        {
            get { return this._lastModifiedAt; }
            set { this._lastModifiedAt = value; }
        }

        // Check to see if LastModifiedAt property is set
        internal bool IsSetLastModifiedAt()
        {
            return this._lastModifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManagerArn. 
        /// <para>
        /// The ARN of the configuration manager.
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
        /// The name of the configuration manager.
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
        /// A summary of the state of the configuration manager. This includes deployment statuses,
        /// association statuses, drift statuses, health checks, and more.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs of metadata to assign to the configuration manager.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}