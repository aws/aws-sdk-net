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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the TerminateProvisionedProduct operation.
    /// Terminates the specified provisioned product.
    /// 
    ///  
    /// <para>
    /// This operation does not delete any records associated with the provisioned product.
    /// </para>
    ///  
    /// <para>
    /// You can check the status of this request using <a>DescribeRecord</a>.
    /// </para>
    /// </summary>
    public partial class TerminateProvisionedProductRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private bool? _ignoreErrors;
        private string _provisionedProductId;
        private string _provisionedProductName;
        private bool? _retainPhysicalResources;
        private string _terminateToken;

        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>jp</code> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>zh</code> - Chinese
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=100)]
        public string AcceptLanguage
        {
            get { return this._acceptLanguage; }
            set { this._acceptLanguage = value; }
        }

        // Check to see if AcceptLanguage property is set
        internal bool IsSetAcceptLanguage()
        {
            return this._acceptLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property IgnoreErrors. 
        /// <para>
        /// If set to true, Service Catalog stops managing the specified provisioned product even
        /// if it cannot delete the underlying resources.
        /// </para>
        /// </summary>
        public bool IgnoreErrors
        {
            get { return this._ignoreErrors.GetValueOrDefault(); }
            set { this._ignoreErrors = value; }
        }

        // Check to see if IgnoreErrors property is set
        internal bool IsSetIgnoreErrors()
        {
            return this._ignoreErrors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProvisionedProductId. 
        /// <para>
        /// The identifier of the provisioned product. You cannot specify both <code>ProvisionedProductName</code>
        /// and <code>ProvisionedProductId</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ProvisionedProductId
        {
            get { return this._provisionedProductId; }
            set { this._provisionedProductId = value; }
        }

        // Check to see if ProvisionedProductId property is set
        internal bool IsSetProvisionedProductId()
        {
            return this._provisionedProductId != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedProductName. 
        /// <para>
        /// The name of the provisioned product. You cannot specify both <code>ProvisionedProductName</code>
        /// and <code>ProvisionedProductId</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string ProvisionedProductName
        {
            get { return this._provisionedProductName; }
            set { this._provisionedProductName = value; }
        }

        // Check to see if ProvisionedProductName property is set
        internal bool IsSetProvisionedProductName()
        {
            return this._provisionedProductName != null;
        }

        /// <summary>
        /// Gets and sets the property RetainPhysicalResources. 
        /// <para>
        /// When this boolean parameter is set to true, the <code>TerminateProvisionedProduct</code>
        /// API deletes the Service Catalog provisioned product. However, it does not remove the
        /// CloudFormation stack, stack set, or the underlying resources of the deleted provisioned
        /// product. The default value is false.
        /// </para>
        /// </summary>
        public bool RetainPhysicalResources
        {
            get { return this._retainPhysicalResources.GetValueOrDefault(); }
            set { this._retainPhysicalResources = value; }
        }

        // Check to see if RetainPhysicalResources property is set
        internal bool IsSetRetainPhysicalResources()
        {
            return this._retainPhysicalResources.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TerminateToken. 
        /// <para>
        /// An idempotency token that uniquely identifies the termination request. This token
        /// is only valid during the termination process. After the provisioned product is terminated,
        /// subsequent requests to terminate the same provisioned product always return <b>ResourceNotFound</b>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string TerminateToken
        {
            get { return this._terminateToken; }
            set { this._terminateToken = value; }
        }

        // Check to see if TerminateToken property is set
        internal bool IsSetTerminateToken()
        {
            return this._terminateToken != null;
        }

    }
}