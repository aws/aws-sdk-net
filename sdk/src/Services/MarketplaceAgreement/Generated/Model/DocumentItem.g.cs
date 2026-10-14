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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        [AWSProperty(Min = 1, Max = 4096)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// A URL to the legal document for buyers to read. Required when <c>Type</c> is <c>CustomEula</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version of standard contracts provided by AWS Marketplace. Required when Type is <c>StandardEula</c>
        /// or <c>StandardDsa</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
