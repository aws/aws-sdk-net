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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// This is the response object from the GetServicesInScope operation.
    /// </summary>
    public partial class GetServicesInScopeResponse : AmazonWebServiceResponse
    {
        private List<ServiceMetadata> _serviceMetadata = new List<ServiceMetadata>();

        /// <summary>
        /// Gets and sets the property ServiceMetadata. 
        /// <para>
        ///  The metadata associated with the aAWS service. 
        /// </para>
        /// </summary>
        public List<ServiceMetadata> ServiceMetadata
        {
            get { return this._serviceMetadata; }
            set { this._serviceMetadata = value; }
        }

        // Check to see if ServiceMetadata property is set
        internal bool IsSetServiceMetadata()
        {
            return this._serviceMetadata != null && this._serviceMetadata.Count > 0; 
        }

    }
}