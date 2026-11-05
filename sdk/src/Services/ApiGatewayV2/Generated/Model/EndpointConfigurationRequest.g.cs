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

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Represents an endpoint configuration.
    /// </summary>
    public partial class EndpointConfigurationRequest
    {
        /// <summary>
        /// Gets and sets the property AcmManaged. 
        /// <para>
        /// Represents a domain name and certificate for a portal.
        /// </para>
        /// </summary>
        public ACMManaged AcmManaged { get; set; }

        /// <summary>
        /// Checks to see if the AcmManaged property is set.
        /// </summary>
        internal bool IsSetAcmManaged() => this.AcmManaged != null;

        /// <summary>
        /// Gets and sets the property None. 
        /// <para>
        /// Use the default portal domain name that is generated and managed by API Gateway.
        /// </para>
        /// </summary>
        public None None { get; set; }

        /// <summary>
        /// Checks to see if the None property is set.
        /// </summary>
        internal bool IsSetNone() => this.None != null;
    }
}
