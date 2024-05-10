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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// A trust store that can be associated with a web portal. A trust store contains certificate
    /// authority (CA) certificates. Once associated with a web portal, the browser in a streaming
    /// session will recognize certificates that have been issued using any of the CAs in
    /// the trust store. If your organization has internal websites that use certificates
    /// issued by private CAs, you should add the private CA certificate to the trust store.
    /// </summary>
    public partial class TrustStore
    {
        private List<string> _associatedPortalArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _trustStoreArn;

        /// <summary>
        /// Gets and sets the property AssociatedPortalArns. 
        /// <para>
        /// A list of web portal ARNs that this trust store is associated with.
        /// </para>
        /// </summary>
        public List<string> AssociatedPortalArns
        {
            get { return this._associatedPortalArns; }
            set { this._associatedPortalArns = value; }
        }

        // Check to see if AssociatedPortalArns property is set
        internal bool IsSetAssociatedPortalArns()
        {
            return this._associatedPortalArns != null && (this._associatedPortalArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrustStoreArn. 
        /// <para>
        /// The ARN of the trust store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string TrustStoreArn
        {
            get { return this._trustStoreArn; }
            set { this._trustStoreArn = value; }
        }

        // Check to see if TrustStoreArn property is set
        internal bool IsSetTrustStoreArn()
        {
            return this._trustStoreArn != null;
        }

    }
}