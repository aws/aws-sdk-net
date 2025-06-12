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
    /// This is the response object from the GetConfiguration operation.
    /// </summary>
    public partial class GetConfigurationResponse : AmazonWebServiceResponse
    {
        private string _account;
        private string _configurationDefinitionId;
        private DateTime? _createdAt;
        private string _id;
        private DateTime? _lastModifiedAt;
        private string _managerArn;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _region;
        private List<StatusSummary> _statusSummaries = AWSConfigs.InitializeCollections ? new List<StatusSummary>() : null;
        private string _type;
        private string _typeVersion;

        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// The ID of the Amazon Web Services account where the configuration was deployed.
        /// </para>
        /// </summary>
        public string Account
        {
            get { return this._account; }
            set { this._account = value; }
        }

        // Check to see if Account property is set
        internal bool IsSetAccount()
        {
            return this._account != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationDefinitionId. 
        /// <para>
        /// The ID of the configuration definition.
        /// </para>
        /// </summary>
        public string ConfigurationDefinitionId
        {
            get { return this._configurationDefinitionId; }
            set { this._configurationDefinitionId = value; }
        }

        // Check to see if ConfigurationDefinitionId property is set
        internal bool IsSetConfigurationDefinitionId()
        {
            return this._configurationDefinitionId != null;
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
        /// Gets and sets the property Id. 
        /// <para>
        /// A service generated identifier for the configuration.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region where the configuration was deployed.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the Quick Setup configuration.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property TypeVersion. 
        /// <para>
        /// The version of the Quick Setup type used.
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