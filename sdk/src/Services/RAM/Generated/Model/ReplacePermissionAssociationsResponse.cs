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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
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
namespace Amazon.RAM.Model
{
    /// <summary>
    /// This is the response object from the ReplacePermissionAssociations operation.
    /// </summary>
    public partial class ReplacePermissionAssociationsResponse : AmazonWebServiceResponse
    {
        private string _clientToken;
        private ReplacePermissionAssociationsWork _replacePermissionAssociationsWork;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency identifier associated with this request. If you want to repeat the
        /// same operation in an idempotent manner then you must include this value in the <c>clientToken</c>
        /// request parameter of that later call. All other parameters must also have the same
        /// values that you used in the first call.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ReplacePermissionAssociationsWork. 
        /// <para>
        /// Specifies a data structure that you can use to track the asynchronous tasks that RAM
        /// performs to complete this operation. You can use the <a>ListReplacePermissionAssociationsWork</a>
        /// operation and pass the <c>id</c> value returned in this structure.
        /// </para>
        /// </summary>
        public ReplacePermissionAssociationsWork ReplacePermissionAssociationsWork
        {
            get { return this._replacePermissionAssociationsWork; }
            set { this._replacePermissionAssociationsWork = value; }
        }

        // Check to see if ReplacePermissionAssociationsWork property is set
        internal bool IsSetReplacePermissionAssociationsWork()
        {
            return this._replacePermissionAssociationsWork != null;
        }

    }
}