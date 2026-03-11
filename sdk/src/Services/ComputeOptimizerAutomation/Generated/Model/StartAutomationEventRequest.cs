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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
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
namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Container for the parameters to the StartAutomationEvent operation.
    /// Initiates a one-time, on-demand automation for the specified recommended action.
    /// 
    /// 
    ///  <note> 
    /// <para>
    /// Management accounts and delegated administrators can only initiate recommended actions
    /// for associated member accounts. You can associate a member account using <c>AssociateAccounts</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StartAutomationEventRequest : AmazonComputeOptimizerAutomationRequest
    {
        private string _clientToken;
        private string _recommendedActionId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. Must be 1-64 characters long and contain only alphanumeric characters,
        /// underscores, and hyphens.
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
        /// Gets and sets the property RecommendedActionId. 
        /// <para>
        ///  The ID of the recommended action to automate. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RecommendedActionId
        {
            get { return this._recommendedActionId; }
            set { this._recommendedActionId = value; }
        }

        // Check to see if RecommendedActionId property is set
        internal bool IsSetRecommendedActionId()
        {
            return this._recommendedActionId != null;
        }

    }
}