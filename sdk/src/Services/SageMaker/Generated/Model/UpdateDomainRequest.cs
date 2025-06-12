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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDomain operation.
    /// Updates the default settings for new user profiles in the domain.
    /// </summary>
    public partial class UpdateDomainRequest : AmazonSageMakerRequest
    {
        private AppNetworkAccessType _appNetworkAccessType;
        private AppSecurityGroupManagement _appSecurityGroupManagement;
        private DefaultSpaceSettings _defaultSpaceSettings;
        private UserSettings _defaultUserSettings;
        private string _domainId;
        private DomainSettingsForUpdate _domainSettingsForUpdate;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TagPropagation _tagPropagation;

        /// <summary>
        /// Gets and sets the property AppNetworkAccessType. 
        /// <para>
        /// Specifies the VPC used for non-EFS traffic.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PublicInternetOnly</c> - Non-EFS traffic is through a VPC managed by Amazon SageMaker
        /// AI, which allows direct internet access.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VpcOnly</c> - All Studio traffic is through the specified VPC and subnets.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This configuration can only be modified if there are no apps in the <c>InService</c>,
        /// <c>Pending</c>, or <c>Deleting</c> state. The configuration cannot be updated if <c>DomainSettings.RStudioServerProDomainSettings.DomainExecutionRoleArn</c>
        /// is already set or <c>DomainSettings.RStudioServerProDomainSettings.DomainExecutionRoleArn</c>
        /// is provided as part of the same request.
        /// </para>
        /// </summary>
        public AppNetworkAccessType AppNetworkAccessType
        {
            get { return this._appNetworkAccessType; }
            set { this._appNetworkAccessType = value; }
        }

        // Check to see if AppNetworkAccessType property is set
        internal bool IsSetAppNetworkAccessType()
        {
            return this._appNetworkAccessType != null;
        }

        /// <summary>
        /// Gets and sets the property AppSecurityGroupManagement. 
        /// <para>
        /// The entity that creates and manages the required security groups for inter-app communication
        /// in <c>VPCOnly</c> mode. Required when <c>CreateDomain.AppNetworkAccessType</c> is
        /// <c>VPCOnly</c> and <c>DomainSettings.RStudioServerProDomainSettings.DomainExecutionRoleArn</c>
        /// is provided. If setting up the domain for use with RStudio, this value must be set
        /// to <c>Service</c>.
        /// </para>
        /// </summary>
        public AppSecurityGroupManagement AppSecurityGroupManagement
        {
            get { return this._appSecurityGroupManagement; }
            set { this._appSecurityGroupManagement = value; }
        }

        // Check to see if AppSecurityGroupManagement property is set
        internal bool IsSetAppSecurityGroupManagement()
        {
            return this._appSecurityGroupManagement != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultSpaceSettings. 
        /// <para>
        /// The default settings for shared spaces that users create in the domain.
        /// </para>
        /// </summary>
        public DefaultSpaceSettings DefaultSpaceSettings
        {
            get { return this._defaultSpaceSettings; }
            set { this._defaultSpaceSettings = value; }
        }

        // Check to see if DefaultSpaceSettings property is set
        internal bool IsSetDefaultSpaceSettings()
        {
            return this._defaultSpaceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultUserSettings. 
        /// <para>
        /// A collection of settings.
        /// </para>
        /// </summary>
        public UserSettings DefaultUserSettings
        {
            get { return this._defaultUserSettings; }
            set { this._defaultUserSettings = value; }
        }

        // Check to see if DefaultUserSettings property is set
        internal bool IsSetDefaultUserSettings()
        {
            return this._defaultUserSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the domain to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property DomainSettingsForUpdate. 
        /// <para>
        /// A collection of <c>DomainSettings</c> configuration values to update.
        /// </para>
        /// </summary>
        public DomainSettingsForUpdate DomainSettingsForUpdate
        {
            get { return this._domainSettingsForUpdate; }
            set { this._domainSettingsForUpdate = value; }
        }

        // Check to see if DomainSettingsForUpdate property is set
        internal bool IsSetDomainSettingsForUpdate()
        {
            return this._domainSettingsForUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The VPC subnets that Studio uses for communication.
        /// </para>
        ///  
        /// <para>
        /// If removing subnets, ensure there are no apps in the <c>InService</c>, <c>Pending</c>,
        /// or <c>Deleting</c> state.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TagPropagation. 
        /// <para>
        /// Indicates whether custom tag propagation is supported for the domain. Defaults to
        /// <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public TagPropagation TagPropagation
        {
            get { return this._tagPropagation; }
            set { this._tagPropagation = value; }
        }

        // Check to see if TagPropagation property is set
        internal bool IsSetTagPropagation()
        {
            return this._tagPropagation != null;
        }

    }
}