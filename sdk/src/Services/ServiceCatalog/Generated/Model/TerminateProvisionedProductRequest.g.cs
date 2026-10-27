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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the TerminateProvisionedProduct operation. Terminates
    /// the specified provisioned product. <para> This operation does not delete any records
    /// associated with the provisioned product. </para> <para> You can check the status of
    /// this request using <a>DescribeRecord</a>. </para>
    /// </summary>
    public partial class TerminateProvisionedProductRequest : AmazonServiceCatalogRequest
    {
        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>jp</c> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zh</c> - Chinese
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Checks to see if the AcceptLanguage property is set.
        /// </summary>
        internal bool IsSetAcceptLanguage() => this.AcceptLanguage != null;

        /// <summary>
        /// Gets and sets the property IgnoreErrors. 
        /// <para>
        /// If set to true, Service Catalog stops managing the specified provisioned product even
        /// if it cannot delete the underlying resources.
        /// </para>
        /// </summary>
        public bool? IgnoreErrors { get; set; }

        /// <summary>
        /// Checks to see if the IgnoreErrors property is set.
        /// </summary>
        internal bool IsSetIgnoreErrors() => this.IgnoreErrors.HasValue;

        /// <summary>
        /// Gets and sets the property ProvisionedProductId. 
        /// <para>
        /// The identifier of the provisioned product. You cannot specify both <c>ProvisionedProductName</c>
        /// and <c>ProvisionedProductId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ProvisionedProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedProductId property is set.
        /// </summary>
        internal bool IsSetProvisionedProductId() => this.ProvisionedProductId != null;

        /// <summary>
        /// Gets and sets the property ProvisionedProductName. 
        /// <para>
        /// The name of the provisioned product. You cannot specify both <c>ProvisionedProductName</c>
        /// and <c>ProvisionedProductId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1224)]
        public string ProvisionedProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedProductName property is set.
        /// </summary>
        internal bool IsSetProvisionedProductName() => this.ProvisionedProductName != null;

        /// <summary>
        /// Gets and sets the property RetainPhysicalResources. 
        /// <para>
        /// When this boolean parameter is set to true, the <c>TerminateProvisionedProduct</c>
        /// API deletes the Service Catalog provisioned product. However, it does not remove the
        /// CloudFormation stack, stack set, or the underlying resources of the deleted provisioned
        /// product. The default value is false.
        /// </para>
        /// </summary>
        public bool? RetainPhysicalResources { get; set; }

        /// <summary>
        /// Checks to see if the RetainPhysicalResources property is set.
        /// </summary>
        internal bool IsSetRetainPhysicalResources() => this.RetainPhysicalResources.HasValue;

        /// <summary>
        /// Gets and sets the property TerminateToken. 
        /// <para>
        /// An idempotency token that uniquely identifies the termination request. This token
        /// is only valid during the termination process. After the provisioned product is terminated,
        /// subsequent requests to terminate the same provisioned product always return <b>ResourceNotFound</b>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TerminateToken { get; set; }

        /// <summary>
        /// Checks to see if the TerminateToken property is set.
        /// </summary>
        internal bool IsSetTerminateToken() => this.TerminateToken != null;
    }
}
