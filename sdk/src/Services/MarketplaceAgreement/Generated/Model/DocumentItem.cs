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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Includes the list of references to legal resources proposed by the proposer to the
    /// acceptor. Each <c>DocumentItem</c> refers to an individual reference.
    /// </summary>
    public partial class DocumentItem
    {
        private string _type;
        private string _url;
        private string _version;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Category of the document. Document types include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CustomEula</c> – A custom EULA provided by you as seller. A URL for a EULA stored
        /// in an accessible Amazon S3 bucket is required for this document type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CustomDsa</c> – A custom Data Subscription Agreement (DSA) provided by you as
        /// seller. A URL for a DSA stored in an accessible Amazon S3 bucket is required for this
        /// document type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>StandardEula</c> – The Standard Contract for AWS Marketplace (SCMP). For more
        /// information about SCMP, see the AWS Marketplace Seller Guide. You don’t provide a
        /// URL for this type because it’s managed by AWS Marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>StandardDsa</c> – DSA for AWS Marketplace. For more information about the DSA,
        /// see the AWS Data Exchange User Guide. You don’t provide a URL for this type because
        /// it’s managed by AWS Marketplace.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// A URL to the legal document for buyers to read. Required when <c>Type</c> is <c>CustomEula</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version of standard contracts provided by AWS Marketplace. Required when Type is <c>StandardEula</c>
        /// or <c>StandardDsa</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}