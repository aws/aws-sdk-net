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
    /// Container for the parameters to the UpdateSubscriptionTarget operation.
    /// Updates the specified subscription target in Amazon DataZone.
    /// </summary>
    public partial class UpdateSubscriptionTargetRequest : AmazonDataZoneRequest
    {
        private List<string> _applicableAssetTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _authorizedPrincipals = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _domainIdentifier;
        private string _environmentIdentifier;
        private string _identifier;
        private string _manageAccessRole;
        private string _name;
        private string _provider;
        private List<SubscriptionTargetForm> _subscriptionTargetConfig = AWSConfigs.InitializeCollections ? new List<SubscriptionTargetForm>() : null;

        /// <summary>
        /// Gets and sets the property ApplicableAssetTypes. 
        /// <para>
        /// The applicable asset types to be updated as part of the <c>UpdateSubscriptionTarget</c>
        /// action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ApplicableAssetTypes
        {
            get { return this._applicableAssetTypes; }
            set { this._applicableAssetTypes = value; }
        }

        // Check to see if ApplicableAssetTypes property is set
        internal bool IsSetApplicableAssetTypes()
        {
            return this._applicableAssetTypes != null && (this._applicableAssetTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AuthorizedPrincipals. 
        /// <para>
        /// The authorized principals to be updated as part of the <c>UpdateSubscriptionTarget</c>
        /// action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> AuthorizedPrincipals
        {
            get { return this._authorizedPrincipals; }
            set { this._authorizedPrincipals = value; }
        }

        // Check to see if AuthorizedPrincipals property is set
        internal bool IsSetAuthorizedPrincipals()
        {
            return this._authorizedPrincipals != null && (this._authorizedPrincipals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which a subscription target is to
        /// be updated.
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
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        /// The identifier of the environment in which a subscription target is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Identifier of the subscription target that is to be updated.
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
        /// Gets and sets the property ManageAccessRole. 
        /// <para>
        /// The manage access role to be updated as part of the <c>UpdateSubscriptionTarget</c>
        /// action.
        /// </para>
        /// </summary>
        public string ManageAccessRole
        {
            get { return this._manageAccessRole; }
            set { this._manageAccessRole = value; }
        }

        // Check to see if ManageAccessRole property is set
        internal bool IsSetManageAccessRole()
        {
            return this._manageAccessRole != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name to be updated as part of the <c>UpdateSubscriptionTarget</c> action.
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
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider to be updated as part of the <c>UpdateSubscriptionTarget</c> action.
        /// </para>
        /// </summary>
        public string Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionTargetConfig. 
        /// <para>
        /// The configuration to be updated as part of the <c>UpdateSubscriptionTarget</c> action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubscriptionTargetForm> SubscriptionTargetConfig
        {
            get { return this._subscriptionTargetConfig; }
            set { this._subscriptionTargetConfig = value; }
        }

        // Check to see if SubscriptionTargetConfig property is set
        internal bool IsSetSubscriptionTargetConfig()
        {
            return this._subscriptionTargetConfig != null && (this._subscriptionTargetConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}