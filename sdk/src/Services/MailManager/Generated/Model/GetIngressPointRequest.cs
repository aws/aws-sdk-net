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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// Container for the parameters to the GetIngressPoint operation.
    /// Fetch ingress endpoint resource attributes.
    /// </summary>
    public partial class GetIngressPointRequest : AmazonMailManagerRequest
    {
        private TrustStoreResponseOption _includeTrustStoreContents;
        private string _ingressPointId;

        /// <summary>
        /// Gets and sets the property IncludeTrustStoreContents. 
        /// <para>
        /// Whether to include the trust store contents in the response. Use INCLUDE to retrieve
        /// trust store certificate and CRL contents.
        /// </para>
        /// </summary>
        public TrustStoreResponseOption IncludeTrustStoreContents
        {
            get { return this._includeTrustStoreContents; }
            set { this._includeTrustStoreContents = value; }
        }

        // Check to see if IncludeTrustStoreContents property is set
        internal bool IsSetIncludeTrustStoreContents()
        {
            return this._includeTrustStoreContents != null;
        }

        /// <summary>
        /// Gets and sets the property IngressPointId. 
        /// <para>
        /// The identifier of an ingress endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string IngressPointId
        {
            get { return this._ingressPointId; }
            set { this._ingressPointId = value; }
        }

        // Check to see if IngressPointId property is set
        internal bool IsSetIngressPointId()
        {
            return this._ingressPointId != null;
        }

    }
}