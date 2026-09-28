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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSubscriptionTarget operation. Updates the
    /// specified subscription target in Amazon DataZone.
    /// </summary>
    public partial class UpdateSubscriptionTargetRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicableAssetTypes. 
        /// <para>
        /// The applicable asset types to be updated as part of the <c>UpdateSubscriptionTarget</c>
        /// action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ApplicableAssetTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ApplicableAssetTypes property is set.
        /// </summary>
        internal bool IsSetApplicableAssetTypes() => this.ApplicableAssetTypes != null && (this.ApplicableAssetTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthorizedPrincipals. 
        /// <para>
        /// The authorized principals to be updated as part of the <c>UpdateSubscriptionTarget</c>
        /// action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<string> AuthorizedPrincipals { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AuthorizedPrincipals property is set.
        /// </summary>
        internal bool IsSetAuthorizedPrincipals() => this.AuthorizedPrincipals != null && (this.AuthorizedPrincipals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which a subscription target is to
        /// be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        /// The identifier of the environment in which a subscription target is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EnvironmentIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentIdentifier property is set.
        /// </summary>
        internal bool IsSetEnvironmentIdentifier() => this.EnvironmentIdentifier != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Identifier of the subscription target that is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property ManageAccessRole. 
        /// <para>
        /// The manage access role to be updated as part of the <c>UpdateSubscriptionTarget</c>
        /// action.
        /// </para>
        /// </summary>
        public string ManageAccessRole { get; set; }

        /// <summary>
        /// Checks to see if the ManageAccessRole property is set.
        /// </summary>
        internal bool IsSetManageAccessRole() => this.ManageAccessRole != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name to be updated as part of the <c>UpdateSubscriptionTarget</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider to be updated as part of the <c>UpdateSubscriptionTarget</c> action.
        /// </para>
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property SubscriptionGrantCreationMode. 
        /// <para>
        ///  Determines the subscription grant creation mode for this target, defining if grants
        /// are auto-created upon subscription approval or managed manually. 
        /// </para>
        /// </summary>
        public SubscriptionGrantCreationMode SubscriptionGrantCreationMode { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionGrantCreationMode property is set.
        /// </summary>
        internal bool IsSetSubscriptionGrantCreationMode() => this.SubscriptionGrantCreationMode != null;

        /// <summary>
        /// Gets and sets the property SubscriptionTargetConfig. 
        /// <para>
        /// The configuration to be updated as part of the <c>UpdateSubscriptionTarget</c> action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubscriptionTargetForm> SubscriptionTargetConfig { get; set; } = AWSConfigs.InitializeCollections ? new List<SubscriptionTargetForm>() : null;

        /// <summary>
        /// Checks to see if the SubscriptionTargetConfig property is set.
        /// </summary>
        internal bool IsSetSubscriptionTargetConfig() => this.SubscriptionTargetConfig != null && (this.SubscriptionTargetConfig.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
