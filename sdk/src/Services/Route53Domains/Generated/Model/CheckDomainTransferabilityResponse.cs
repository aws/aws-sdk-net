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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// The CheckDomainTransferability response includes the following elements.
    /// </summary>
    public partial class CheckDomainTransferabilityResponse : AmazonWebServiceResponse
    {
        private DomainTransferability _transferability;

        /// <summary>
        /// Gets and sets the property Transferability. 
        /// <para>
        /// A complex type that contains information about whether the specified domain can be
        /// transferred to Route 53.
        /// </para>
        /// </summary>
        public DomainTransferability Transferability
        {
            get { return this._transferability; }
            set { this._transferability = value; }
        }

        // Check to see if Transferability property is set
        internal bool IsSetTransferability()
        {
            return this._transferability != null;
        }

    }
}