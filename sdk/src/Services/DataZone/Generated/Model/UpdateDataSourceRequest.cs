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
    /// Container for the parameters to the UpdateDataSource operation.
    /// Updates the specified data source in Amazon DataZone.
    /// </summary>
    public partial class UpdateDataSourceRequest : AmazonDataZoneRequest
    {
        private List<FormInput> _assetFormsInput = AWSConfigs.InitializeCollections ? new List<FormInput>() : null;
        private DataSourceConfigurationInput _configuration;
        private string _description;
        private string _domainIdentifier;
        private EnableSetting _enableSetting;
        private string _identifier;
        private string _name;
        private bool? _publishOnImport;
        private RecommendationConfiguration _recommendation;
        private bool? _retainPermissionsOnRevokeFailure;
        private ScheduleConfiguration _schedule;

        /// <summary>
        /// Gets and sets the property AssetFormsInput. 
        /// <para>
        /// The asset forms to be updated as part of the <c>UpdateDataSource</c> action.
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
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration to be updated as part of the <c>UpdateDataSource</c> action.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to be updated as part of the <c>UpdateDataSource</c> action.
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
        /// The identifier of the domain in which to update a data source.
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
        /// The enable setting to be updated as part of the <c>UpdateDataSource</c> action.
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
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the data source to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name to be updated as part of the <c>UpdateDataSource</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
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
        /// Gets and sets the property PublishOnImport. 
        /// <para>
        /// The publish on import setting to be updated as part of the <c>UpdateDataSource</c>
        /// action.
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
        /// The recommendation to be updated as part of the <c>UpdateDataSource</c> action.
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
        /// Gets and sets the property RetainPermissionsOnRevokeFailure. 
        /// <para>
        /// Specifies that the granted permissions are retained in case of a self-subscribe functionality
        /// failure for a data source.
        /// </para>
        /// </summary>
        public bool? RetainPermissionsOnRevokeFailure
        {
            get { return this._retainPermissionsOnRevokeFailure; }
            set { this._retainPermissionsOnRevokeFailure = value; }
        }

        // Check to see if RetainPermissionsOnRevokeFailure property is set
        internal bool IsSetRetainPermissionsOnRevokeFailure()
        {
            return this._retainPermissionsOnRevokeFailure.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule to be updated as part of the <c>UpdateDataSource</c> action.
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

    }
}