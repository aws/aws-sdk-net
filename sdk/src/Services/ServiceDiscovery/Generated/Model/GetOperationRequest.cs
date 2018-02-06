/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// Container for the parameters to the GetOperation operation.
    /// Gets information about any operation that returns an operation ID in the response,
    /// such as a <code>CreateService</code> request.
    /// 
    ///  <note> 
    /// <para>
    /// To get a list of operations that match specified criteria, see <a>ListOperations</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetOperationRequest : AmazonServiceDiscoveryRequest
    {
        private string _operationId;

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The ID of the operation that you want to get more information about.
        /// </para>
        /// </summary>
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

    }
}