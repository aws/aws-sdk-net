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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
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
namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// Container for the parameters to the GetOperation operation.
    /// Gets information about any operation that returns an operation ID in the response,
    /// such as a <c>CreateHttpNamespace</c> request.
    /// 
    ///  <note> 
    /// <para>
    /// To get a list of operations that match specified criteria, see <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_ListOperations.html">ListOperations</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetOperationRequest : AmazonServiceDiscoveryRequest
    {
        private string _operationId;
        private string _ownerAccount;

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The ID of the operation that you want to get more information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string OperationId
        {
            get { return this._operationId; }
            set { this._operationId = value; }
        }

        // Check to see if OperationId property is set
        internal bool IsSetOperationId()
        {
            return this._operationId != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the namespace associated with
        /// the operation, as specified in the namespace <c>ResourceOwner</c> field. For operations
        /// associated with namespaces that are shared with your account, you must specify an
        /// <c>OwnerAccount</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string OwnerAccount
        {
            get { return this._ownerAccount; }
            set { this._ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this._ownerAccount != null;
        }

    }
}