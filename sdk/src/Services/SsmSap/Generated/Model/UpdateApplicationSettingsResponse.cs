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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// This is the response object from the UpdateApplicationSettings operation.
    /// </summary>
    public partial class UpdateApplicationSettingsResponse : AmazonWebServiceResponse
    {
        private string _message;
        private List<string> _operationIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The update message.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property OperationIds. 
        /// <para>
        /// The IDs of the operations.
        /// </para>
        /// </summary>
        public List<string> OperationIds
        {
            get { return this._operationIds; }
            set { this._operationIds = value; }
        }

        // Check to see if OperationIds property is set
        internal bool IsSetOperationIds()
        {
            return this._operationIds != null && this._operationIds.Count > 0; 
        }

    }
}