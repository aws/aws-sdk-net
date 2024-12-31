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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An HTTP 200 response if the request succeeds, or an error message if the request fails.
    /// </summary>
    public partial class CreateMultiRegionEndpointResponse : AmazonWebServiceResponse
    {
        private string _endpointId;
        private Status _status;

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The ID of the multi-region endpoint (global-endpoint).
        /// </para>
        /// </summary>
        public string EndpointId
        {
            get { return this._endpointId; }
            set { this._endpointId = value; }
        }

        // Check to see if EndpointId property is set
        internal bool IsSetEndpointId()
        {
            return this._endpointId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A status of the multi-region endpoint (global-endpoint) right after the create request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> – The resource is being provisioned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READY</c> – The resource is ready to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – The resource failed to be provisioned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> – The resource is being deleted as requested.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}