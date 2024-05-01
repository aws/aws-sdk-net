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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
        private RateBasedStatementManagedKeysIPSet _managedKeysIPV4;
        private RateBasedStatementManagedKeysIPSet _managedKeysIPV6;

        /// <summary>
        /// Gets and sets the property ManagedKeysIPV4. 
        /// <para>
        /// The keys that are of Internet Protocol version 4 (IPv4). 
        /// </para>
        /// </summary>
        public RateBasedStatementManagedKeysIPSet ManagedKeysIPV4
        {
            get { return this._managedKeysIPV4; }
            set { this._managedKeysIPV4 = value; }
        }

        // Check to see if ManagedKeysIPV4 property is set
        internal bool IsSetManagedKeysIPV4()
        {
            return this._managedKeysIPV4 != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedKeysIPV6. 
        /// <para>
        /// The keys that are of Internet Protocol version 6 (IPv6). 
        /// </para>
        /// </summary>
        public RateBasedStatementManagedKeysIPSet ManagedKeysIPV6
        {
            get { return this._managedKeysIPV6; }
            set { this._managedKeysIPV6 = value; }
        }

        // Check to see if ManagedKeysIPV6 property is set
        internal bool IsSetManagedKeysIPV6()
        {
            return this._managedKeysIPV6 != null;
        }

    }
}