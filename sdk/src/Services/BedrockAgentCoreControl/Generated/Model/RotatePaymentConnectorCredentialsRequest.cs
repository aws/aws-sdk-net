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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
    /// Container for the parameters to the RotatePaymentConnectorCredentials operation.
    /// Replaces the service-managed credentials of a payment connector with newly issued
    /// credentials.
    /// 
    ///  
    /// <para>
    /// Use this operation only for payment connectors with a <c>provisionMode</c> of <c>QUICK_CREATE</c>.
    /// For payment connectors with a <c>provisionMode</c> of <c>MANUAL</c>, call <c>UpdatePaymentCredentialProvider</c>
    /// instead after rotating credentials with the payment provider directly.
    /// </para>
    ///  
    /// <para>
    /// The rotation finishes before the response is returned, and only one rotation runs
    /// at a time for a given payment connector. When it succeeds, the new credential is in
    /// effect and the payment connector stays in the <c>READY</c> state. When it fails, an
    /// error is returned, the payment connector and its existing credential are left unchanged,
    /// and you can retry the request.
    /// </para>
    ///  
    /// <para>
    /// Rotation replaces the credential on the connector's credential provider, so every
    /// payment connector that uses that provider is affected. Replace any copy of the previous
    /// credential that you use outside AgentCore.
    /// </para>
    /// </summary>
    public partial class RotatePaymentConnectorCredentialsRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _clientToken;
        private CredentialRotationConfig _credentialsToRotate;
        private string _paymentConnectorId;
        private string _paymentManagerId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If you don't specify this field, a value is randomly generated for
        /// you. If this token matches a previous request, the service ignores the request, but
        /// doesn't return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
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
        /// Gets and sets the property CredentialsToRotate. 
        /// <para>
        /// The credentials to rotate. Specify the member that matches the payment connector's
        /// <c>type</c>. Each credential that you select is rotated independently.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CredentialRotationConfig CredentialsToRotate
        {
            get { return this._credentialsToRotate; }
            set { this._credentialsToRotate = value; }
        }

        // Check to see if CredentialsToRotate property is set
        internal bool IsSetCredentialsToRotate()
        {
            return this._credentialsToRotate != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentConnectorId. 
        /// <para>
        /// The unique identifier of the payment connector whose credentials you want to rotate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=211)]
        public string PaymentConnectorId
        {
            get { return this._paymentConnectorId; }
            set { this._paymentConnectorId = value; }
        }

        // Check to see if PaymentConnectorId property is set
        internal bool IsSetPaymentConnectorId()
        {
            return this._paymentConnectorId != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentManagerId. 
        /// <para>
        /// The unique identifier of the parent payment manager.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=211)]
        public string PaymentManagerId
        {
            get { return this._paymentManagerId; }
            set { this._paymentManagerId = value; }
        }

        // Check to see if PaymentManagerId property is set
        internal bool IsSetPaymentManagerId()
        {
            return this._paymentManagerId != null;
        }

    }
}