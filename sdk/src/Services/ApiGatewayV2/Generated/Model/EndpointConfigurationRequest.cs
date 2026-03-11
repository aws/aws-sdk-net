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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
        private ACMManaged _acmManaged;
        private None _none;

        /// <summary>
        /// Gets and sets the property AcmManaged. 
        /// <para>
        /// Represents a domain name and certificate for a portal.
        /// </para>
        /// </summary>
        public ACMManaged AcmManaged
        {
            get { return this._acmManaged; }
            set { this._acmManaged = value; }
        }

        // Check to see if AcmManaged property is set
        internal bool IsSetAcmManaged()
        {
            return this._acmManaged != null;
        }

        /// <summary>
        /// Gets and sets the property None. 
        /// <para>
        /// Use the default portal domain name that is generated and managed by API Gateway.
        /// </para>
        /// </summary>
        public None None
        {
            get { return this._none; }
            set { this._none = value; }
        }

        // Check to see if None property is set
        internal bool IsSetNone()
        {
            return this._none != null;
        }

    }
}