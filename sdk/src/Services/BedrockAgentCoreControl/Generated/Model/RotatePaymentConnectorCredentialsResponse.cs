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
    /// This is the response object from the RotatePaymentConnectorCredentials operation.
    /// </summary>
    public partial class RotatePaymentConnectorCredentialsResponse : AmazonWebServiceResponse
    {
        private DateTime? _lastUpdatedAt;
        private string _paymentConnectorId;
        private string _paymentManagerId;
        private PaymentConnectorStatus _status;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the payment connector was last updated, which is when the rotation
        /// completed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PaymentConnectorId. 
        /// <para>
        /// The unique identifier of the payment connector.
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the payment connector, which is <c>READY</c> after a successful
        /// rotation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentConnectorStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}