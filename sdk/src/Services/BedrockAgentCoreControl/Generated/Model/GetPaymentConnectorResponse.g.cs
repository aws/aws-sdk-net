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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// This is the response object from the GetPaymentConnector operation.
    /// </summary>
    public partial class GetPaymentConnectorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AuthorizationUrl. 
        /// <para>
        /// The URL that the user must open to complete OAuth consent. This field is only present
        /// when the payment connector status is <c>PENDING_AUTHENTICATION</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string AuthorizationUrl { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationUrl property is set.
        /// </summary>
        internal bool IsSetAuthorizationUrl() => this.AuthorizationUrl != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the payment connector was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CredentialProviderConfigurations. 
        /// <para>
        /// The credential provider configurations for the payment connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1)]
        public List<CredentialsProviderConfiguration> CredentialProviderConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<CredentialsProviderConfiguration>() : null;

        /// <summary>
        /// Checks to see if the CredentialProviderConfigurations property is set.
        /// </summary>
        internal bool IsSetCredentialProviderConfigurations() => this.CredentialProviderConfigurations != null && (this.CredentialProviderConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CredentialsUpdatedAt. 
        /// <para>
        /// The timestamp when the payment connector's current service-managed credentials took
        /// effect. It is first set when the credentials are provisioned and is updated by each
        /// rotation. This field is present only for payment connectors with a <c>provisionMode</c>
        /// of <c>QUICK_CREATE</c>.
        /// </para>
        /// </summary>
        public DateTime? CredentialsUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CredentialsUpdatedAt property is set.
        /// </summary>
        internal bool IsSetCredentialsUpdatedAt() => this.CredentialsUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the payment connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the payment connector was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the payment connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PaymentConnectorId. 
        /// <para>
        /// The unique identifier of the payment connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 211)]
        public string PaymentConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the PaymentConnectorId property is set.
        /// </summary>
        internal bool IsSetPaymentConnectorId() => this.PaymentConnectorId != null;

        /// <summary>
        /// Gets and sets the property ProvisionMode. 
        /// <para>
        /// Specifies how the payment connector was provisioned. Payment connectors that were
        /// created before this field was available return <c>MANUAL</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MANUAL</c> - You provided the credential provider configurations, so you own the
        /// credentials. Rotate them with the payment provider, then call <c>UpdatePaymentCredentialProvider</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>QUICK_CREATE</c> - AgentCore provisioned the credential provider for you, so the
        /// credentials are service-managed. You can rotate them with <c>RotatePaymentConnectorCredentials</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PaymentConnectorProvisionMode ProvisionMode { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionMode property is set.
        /// </summary>
        internal bool IsSetProvisionMode() => this.ProvisionMode != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the payment connector. Possible values include <c>CREATING</c>,
        /// <c>READY</c>, <c>UPDATING</c>, <c>DELETING</c>, <c>CREATE_FAILED</c>, <c>UPDATE_FAILED</c>,
        /// and <c>DELETE_FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PaymentConnectorStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the payment connector, which determines the payment provider integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PaymentConnectorType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
