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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the GetFoundationModelAvailability operation.
    /// </summary>
    public partial class GetFoundationModelAvailabilityResponse : AmazonWebServiceResponse
    {
        private AgreementAvailability _agreementAvailability;
        private AuthorizationStatus _authorizationStatus;
        private EntitlementAvailability _entitlementAvailability;
        private string _modelId;
        private RegionAvailability _regionAvailability;

        /// <summary>
        /// Gets and sets the property AgreementAvailability. 
        /// <para>
        /// Agreement availability. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgreementAvailability AgreementAvailability
        {
            get { return this._agreementAvailability; }
            set { this._agreementAvailability = value; }
        }

        // Check to see if AgreementAvailability property is set
        internal bool IsSetAgreementAvailability()
        {
            return this._agreementAvailability != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizationStatus. 
        /// <para>
        /// Authorization status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthorizationStatus AuthorizationStatus
        {
            get { return this._authorizationStatus; }
            set { this._authorizationStatus = value; }
        }

        // Check to see if AuthorizationStatus property is set
        internal bool IsSetAuthorizationStatus()
        {
            return this._authorizationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EntitlementAvailability. 
        /// <para>
        /// Entitlement availability. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EntitlementAvailability EntitlementAvailability
        {
            get { return this._entitlementAvailability; }
            set { this._entitlementAvailability = value; }
        }

        // Check to see if EntitlementAvailability property is set
        internal bool IsSetEntitlementAvailability()
        {
            return this._entitlementAvailability != null;
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The model Id of the foundation model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=140)]
        public string ModelId
        {
            get { return this._modelId; }
            set { this._modelId = value; }
        }

        // Check to see if ModelId property is set
        internal bool IsSetModelId()
        {
            return this._modelId != null;
        }

        /// <summary>
        /// Gets and sets the property RegionAvailability. 
        /// <para>
        /// Region availability. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegionAvailability RegionAvailability
        {
            get { return this._regionAvailability; }
            set { this._regionAvailability = value; }
        }

        // Check to see if RegionAvailability property is set
        internal bool IsSetRegionAvailability()
        {
            return this._regionAvailability != null;
        }

    }
}