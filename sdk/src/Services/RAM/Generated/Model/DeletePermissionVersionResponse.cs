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

namespace Amazon.RAM.Model
{
    /// <summary>
    /// This is the response object from the DeletePermissionVersion operation.
    /// </summary>
    public partial class DeletePermissionVersionResponse : AmazonWebServiceResponse
    {
        private string _clientToken;
        private PermissionStatus _permissionStatus;
        private bool? _returnValue;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency identifier associated with this request. If you want to repeat the
        /// same operation in an idempotent manner then you must include this value in the <code>clientToken</code>
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
        /// Gets and sets the property PermissionStatus. 
        /// <para>
        /// This operation is performed asynchronously, and this response parameter indicates
        /// the current status.
        /// </para>
        /// </summary>
        public PermissionStatus PermissionStatus
        {
            get { return this._permissionStatus; }
            set { this._permissionStatus = value; }
        }

        // Check to see if PermissionStatus property is set
        internal bool IsSetPermissionStatus()
        {
            return this._permissionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnValue. 
        /// <para>
        /// A boolean value that indicates whether the operation is successful.
        /// </para>
        /// </summary>
        public bool ReturnValue
        {
            get { return this._returnValue.GetValueOrDefault(); }
            set { this._returnValue = value; }
        }

        // Check to see if ReturnValue property is set
        internal bool IsSetReturnValue()
        {
            return this._returnValue.HasValue; 
        }

    }
}