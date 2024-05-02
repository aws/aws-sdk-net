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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
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
namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// This is the response object from the CreateAccessor operation.
    /// </summary>
    public partial class CreateAccessorResponse : AmazonWebServiceResponse
    {
        private string _accessorId;
        private string _billingToken;
        private AccessorNetworkType _networkType;

        /// <summary>
        /// Gets and sets the property AccessorId. 
        /// <para>
        /// The unique identifier of the accessor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string AccessorId
        {
            get { return this._accessorId; }
            set { this._accessorId = value; }
        }

        // Check to see if AccessorId property is set
        internal bool IsSetAccessorId()
        {
            return this._accessorId != null;
        }

        /// <summary>
        /// Gets and sets the property BillingToken. 
        /// <para>
        /// The billing token is a property of the Accessor. Use this token to when making calls
        /// to the blockchain network. The billing token is used to track your accessor token
        /// for billing requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=42, Max=42)]
        public string BillingToken
        {
            get { return this._billingToken; }
            set { this._billingToken = value; }
        }

        // Check to see if BillingToken property is set
        internal bool IsSetBillingToken()
        {
            return this._billingToken != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The blockchain network that the accessor token is created for.
        /// </para>
        /// </summary>
        public AccessorNetworkType NetworkType
        {
            get { return this._networkType; }
            set { this._networkType = value; }
        }

        // Check to see if NetworkType property is set
        internal bool IsSetNetworkType()
        {
            return this._networkType != null;
        }

    }
}