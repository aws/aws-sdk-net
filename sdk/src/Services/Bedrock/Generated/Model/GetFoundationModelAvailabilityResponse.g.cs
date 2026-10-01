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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the GetFoundationModelAvailability operation.
    /// </summary>
    public partial class GetFoundationModelAvailabilityResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgreementAvailability. 
        /// <para>
        /// Agreement availability. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgreementAvailability AgreementAvailability { get; set; }

        /// <summary>
        /// Checks to see if the AgreementAvailability property is set.
        /// </summary>
        internal bool IsSetAgreementAvailability() => this.AgreementAvailability != null;

        /// <summary>
        /// Gets and sets the property AuthorizationStatus. 
        /// <para>
        /// Authorization status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthorizationStatus AuthorizationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationStatus property is set.
        /// </summary>
        internal bool IsSetAuthorizationStatus() => this.AuthorizationStatus != null;

        /// <summary>
        /// Gets and sets the property EntitlementAvailability. 
        /// <para>
        /// Entitlement availability. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EntitlementAvailability EntitlementAvailability { get; set; }

        /// <summary>
        /// Checks to see if the EntitlementAvailability property is set.
        /// </summary>
        internal bool IsSetEntitlementAvailability() => this.EntitlementAvailability != null;

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The model Id of the foundation model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 140)]
        public string ModelId { get; set; }

        /// <summary>
        /// Checks to see if the ModelId property is set.
        /// </summary>
        internal bool IsSetModelId() => this.ModelId != null;

        /// <summary>
        /// Gets and sets the property RegionAvailability. 
        /// <para>
        /// Region availability. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RegionAvailability RegionAvailability { get; set; }

        /// <summary>
        /// Checks to see if the RegionAvailability property is set.
        /// </summary>
        internal bool IsSetRegionAvailability() => this.RegionAvailability != null;
    }
}
