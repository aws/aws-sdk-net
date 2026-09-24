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
    /// Container for the parameters to the UpdateEnvironmentBlueprint operation. Updates
    /// an environment blueprint in Amazon DataZone.
    /// </summary>
    public partial class UpdateEnvironmentBlueprintRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property BlueprintCategory. 
        /// <para>
        /// The category to update. The only valid value is <c>TOOLING</c>.
        /// </para>
        /// </summary>
        public BlueprintCategory BlueprintCategory { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintCategory property is set.
        /// </summary>
        internal bool IsSetBlueprintCategory() => this.BlueprintCategory != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to be updated as part of the <c>UpdateEnvironmentBlueprint</c> action.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which an environment blueprint is
        /// to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the environment blueprint to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property ProvisioningProperties. 
        /// <para>
        /// The provisioning properties to be updated as part of the <c>UpdateEnvironmentBlueprint</c>
        /// action.
        /// </para>
        /// </summary>
        public ProvisioningProperties ProvisioningProperties { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningProperties property is set.
        /// </summary>
        internal bool IsSetProvisioningProperties() => this.ProvisioningProperties != null;

        /// <summary>
        /// Gets and sets the property UserParameters. 
        /// <para>
        /// The user parameters to be updated as part of the <c>UpdateEnvironmentBlueprint</c>
        /// action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomParameter> UserParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomParameter>() : null;

        /// <summary>
        /// Checks to see if the UserParameters property is set.
        /// </summary>
        internal bool IsSetUserParameters() => this.UserParameters != null && (this.UserParameters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
