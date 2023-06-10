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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Tnb.Model
{
    /// <summary>
    /// This is the response object from the GetSolNetworkPackageContent operation.
    /// </summary>
    public partial class GetSolNetworkPackageContentResponse : AmazonWebServiceResponse
    {
        private PackageContentType _contentType;
        private MemoryStream _nsdContent;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// Indicates the media type of the resource.
        /// </para>
        /// </summary>
        public PackageContentType ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property NsdContent. 
        /// <para>
        /// Content of the network service descriptor in the network package.
        /// </para>
        /// </summary>
        public MemoryStream NsdContent
        {
            get { return this._nsdContent; }
            set { this._nsdContent = value; }
        }

        // Check to see if NsdContent property is set
        internal bool IsSetNsdContent()
        {
            return this._nsdContent != null;
        }

    }
}