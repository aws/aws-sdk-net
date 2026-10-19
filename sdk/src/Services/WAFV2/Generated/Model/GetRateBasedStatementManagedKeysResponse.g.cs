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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// This is the response object from the GetRateBasedStatementManagedKeys operation.
    /// </summary>
    public partial class GetRateBasedStatementManagedKeysResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ManagedKeysIPV4. 
        /// <para>
        /// The keys that are of Internet Protocol version 4 (IPv4). 
        /// </para>
        /// </summary>
        public RateBasedStatementManagedKeysIPSet ManagedKeysIPV4 { get; set; }

        /// <summary>
        /// Checks to see if the ManagedKeysIPV4 property is set.
        /// </summary>
        internal bool IsSetManagedKeysIPV4() => this.ManagedKeysIPV4 != null;

        /// <summary>
        /// Gets and sets the property ManagedKeysIPV6. 
        /// <para>
        /// The keys that are of Internet Protocol version 6 (IPv6). 
        /// </para>
        /// </summary>
        public RateBasedStatementManagedKeysIPSet ManagedKeysIPV6 { get; set; }

        /// <summary>
        /// Checks to see if the ManagedKeysIPV6 property is set.
        /// </summary>
        internal bool IsSetManagedKeysIPV6() => this.ManagedKeysIPV6 != null;
    }
}
