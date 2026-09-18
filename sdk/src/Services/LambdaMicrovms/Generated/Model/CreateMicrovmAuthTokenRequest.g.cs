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

namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMicrovmAuthToken operation. Creates an authentication
    /// token for accessing a running MicroVM. The token grants access to the specified ports
    /// on the MicroVM endpoint.
    /// </summary>
    public partial class CreateMicrovmAuthTokenRequest : AmazonLambdaMicrovmsRequest
    {
        /// <summary>
        /// Gets and sets the property AllowedPorts. 
        /// <para>
        /// The list of port specifications that the authentication token grants access to on
        /// the MicroVM.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<PortSpecification> AllowedPorts { get; set; } = AWSConfigs.InitializeCollections ? new List<PortSpecification>() : null;

        /// <summary>
        /// Checks to see if the AllowedPorts property is set.
        /// </summary>
        internal bool IsSetAllowedPorts() => this.AllowedPorts != null && (this.AllowedPorts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExpirationInMinutes. 
        /// <para>
        /// The duration in minutes before the authentication token expires. Maximum: 60 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? ExpirationInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationInMinutes property is set.
        /// </summary>
        internal bool IsSetExpirationInMinutes() => this.ExpirationInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property MicrovmIdentifier. 
        /// <para>
        /// The ID of the MicroVM to create an authentication token for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string MicrovmIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MicrovmIdentifier property is set.
        /// </summary>
        internal bool IsSetMicrovmIdentifier() => this.MicrovmIdentifier != null;
    }
}
