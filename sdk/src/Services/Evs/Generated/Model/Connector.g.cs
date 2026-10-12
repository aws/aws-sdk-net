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

namespace Amazon.Evs.Model
{
    /// <summary>
    /// An object that represents a connector for an Amazon EVS environment. A connector establishes
    /// a connection to the given appliance type using the credentials stored in Amazon Web
    /// Services Secrets Manager.
    /// </summary>
    public partial class Connector
    {
        /// <summary>
        /// Gets and sets the property ApplianceFqdn. 
        /// <para>
        /// The fully qualified domain name (FQDN) of the VCF appliance that the connector connects
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 253)]
        public string ApplianceFqdn { get; set; }

        /// <summary>
        /// Checks to see if the ApplianceFqdn property is set.
        /// </summary>
        internal bool IsSetApplianceFqdn() => this.ApplianceFqdn != null;

        /// <summary>
        /// Gets and sets the property Checks. 
        /// <para>
        /// A list of checks that are run on the connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConnectorCheck> Checks { get; set; } = AWSConfigs.InitializeCollections ? new List<ConnectorCheck>() : null;

        /// <summary>
        /// Checks to see if the Checks property is set.
        /// </summary>
        internal bool IsSetChecks() => this.Checks != null && (this.Checks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// The unique ID of the connector.
        /// </para>
        /// </summary>
        public string ConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorId property is set.
        /// </summary>
        internal bool IsSetConnectorId() => this.ConnectorId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the connector was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The unique ID of the environment that the connector belongs to.
        /// </para>
        /// </summary>
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The date and time that the connector was modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Secrets Manager secret that
        /// stores the credentials for the VCF appliance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the connector.
        /// </para>
        /// </summary>
        public ConnectorState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateDetails. 
        /// <para>
        /// A detailed description of the connector state.
        /// </para>
        /// </summary>
        public string StateDetails { get; set; }

        /// <summary>
        /// Checks to see if the StateDetails property is set.
        /// </summary>
        internal bool IsSetStateDetails() => this.StateDetails != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the connector.
        /// </para>
        /// </summary>
        public CheckResult Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the connector.
        /// </para>
        /// </summary>
        public ConnectorType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
