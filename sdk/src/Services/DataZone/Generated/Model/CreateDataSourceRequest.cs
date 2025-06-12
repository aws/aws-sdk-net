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
    /// Container for the parameters to the CreateDataSource operation.
    /// Creates an Amazon DataZone data source.
    /// </summary>
    public partial class CreateDataSourceRequest : AmazonDataZoneRequest
    {
        private List<FormInput> _assetFormsInput = AWSConfigs.InitializeCollections ? new List<FormInput>() : null;
        private string _clientToken;
        private DataSourceConfigurationInput _configuration;
        private string _connectionIdentifier;
        private string _description;
        private string _domainIdentifier;
        private EnableSetting _enableSetting;
        private string _environmentIdentifier;
        private string _name;
        private string _projectIdentifier;
        private bool? _publishOnImport;
        private RecommendationConfiguration _recommendation;
        private ScheduleConfiguration _schedule;
        private string _type;

        /// <summary>
        /// Gets and sets the property AssetFormsInput. 
        /// <para>
        /// The metadata forms that are to be attached to the assets that this data source works
        /// with.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=10)]
        public List<FormInput> AssetFormsInput
        {
            get { return this._assetFormsInput; }
            set { this._assetFormsInput = value; }
        }

        // Check to see if AssetFormsInput property is set
        internal bool IsSetAssetFormsInput()
        {
            return this._assetFormsInput != null && (this._assetFormsInput.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that is provided to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Specifies the configuration of the data source. It can be set to either <c>glueRunConfiguration</c>
        /// or <c>redshiftRunConfiguration</c>.
        /// </para>
        /// </summary>
        public DataSourceConfigurationInput Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionIdentifier. 
        /// <para>
        /// The ID of the connection.
        /// </para>
        /// </summary>
        public string ConnectionIdentifier
        {
            get { return this._connectionIdentifier; }
            set { this._connectionIdentifier = value; }
        }

        // Check to see if ConnectionIdentifier property is set
        internal bool IsSetConnectionIdentifier()
        {
            return this._connectionIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the data source.
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
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain where the data source is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EnableSetting. 
        /// <para>
        /// Specifies whether the data source is enabled.
        /// </para>
        /// </summary>
        public EnableSetting EnableSetting
        {
            get { return this._enableSetting; }
            set { this._enableSetting = value; }
        }

        // Check to see if EnableSetting property is set
        internal bool IsSetEnableSetting()
        {
            return this._enableSetting != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        /// The unique identifier of the Amazon DataZone environment to which the data source
        /// publishes assets. 
        /// </para>
        /// </summary>
        public string EnvironmentIdentifier
        {
            get { return this._environmentIdentifier; }
            set { this._environmentIdentifier = value; }
        }

        // Check to see if EnvironmentIdentifier property is set
        internal bool IsSetEnvironmentIdentifier()
        {
            return this._environmentIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
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
        /// Gets and sets the property ProjectIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone project in which you want to add this data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProjectIdentifier
        {
            get { return this._projectIdentifier; }
            set { this._projectIdentifier = value; }
        }

        // Check to see if ProjectIdentifier property is set
        internal bool IsSetProjectIdentifier()
        {
            return this._projectIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property PublishOnImport. 
        /// <para>
        /// Specifies whether the assets that this data source creates in the inventory are to
        /// be also automatically published to the catalog.
        /// </para>
        /// </summary>
        public bool? PublishOnImport
        {
            get { return this._publishOnImport; }
            set { this._publishOnImport = value; }
        }

        // Check to see if PublishOnImport property is set
        internal bool IsSetPublishOnImport()
        {
            return this._publishOnImport.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Recommendation. 
        /// <para>
        /// Specifies whether the business name generation is to be enabled for this data source.
        /// </para>
        /// </summary>
        public RecommendationConfiguration Recommendation
        {
            get { return this._recommendation; }
            set { this._recommendation = value; }
        }

        // Check to see if Recommendation property is set
        internal bool IsSetRecommendation()
        {
            return this._recommendation != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule of the data source runs.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ScheduleConfiguration Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the data source. In Amazon DataZone, you can use data sources to import
        /// technical metadata of assets (data) from the source databases or data warehouses into
        /// Amazon DataZone. In the current release of Amazon DataZone, you can create and run
        /// data sources for Amazon Web Services Glue and Amazon Redshift.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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

    }
}