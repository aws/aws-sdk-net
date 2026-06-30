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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
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
namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// This is the response object from the DescribeAcmeExternalAccountBinding operation.
    /// </summary>
    public partial class DescribeAcmeExternalAccountBindingResponse : AmazonWebServiceResponse
    {
        private AcmeExternalAccountBinding _externalAccountBinding;

        /// <summary>
        /// Gets and sets the property ExternalAccountBinding. 
        /// <para>
        /// The external account binding details.
        /// </para>
        /// </summary>
        public AcmeExternalAccountBinding ExternalAccountBinding
        {
            get { return this._externalAccountBinding; }
            set { this._externalAccountBinding = value; }
        }

        // Check to see if ExternalAccountBinding property is set
        internal bool IsSetExternalAccountBinding()
        {
            return this._externalAccountBinding != null;
        }

    }
}