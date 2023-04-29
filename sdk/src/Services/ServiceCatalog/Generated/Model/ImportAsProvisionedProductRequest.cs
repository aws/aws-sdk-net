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
    /// Container for the parameters to the ImportAsProvisionedProduct operation.
    /// Requests the import of a resource as an Service Catalog provisioned product that
    /// is associated to an Service Catalog product and provisioning artifact. Once imported,
    /// all supported governance actions are supported on the provisioned product. 
    /// 
    ///  
    /// <para>
    ///  Resource import only supports CloudFormation stack ARNs. CloudFormation StackSets,
    /// and non-root nested stacks are not supported. 
    /// </para>
    ///  
    /// <para>
    ///  The CloudFormation stack must have one of the following statuses to be imported:
    /// <code>CREATE_COMPLETE</code>, <code>UPDATE_COMPLETE</code>, <code>UPDATE_ROLLBACK_COMPLETE</code>,
    /// <code>IMPORT_COMPLETE</code>, and <code>IMPORT_ROLLBACK_COMPLETE</code>. 
    /// </para>
    ///  
    /// <para>
    ///  Import of the resource requires that the CloudFormation stack template matches the
    /// associated Service Catalog product provisioning artifact. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  When you import an existing CloudFormation stack into a portfolio, constraints that
    /// are associated with the product aren't applied during the import process. The constraints
    /// are applied after you call <code>UpdateProvisionedProduct</code> for the provisioned
    /// product. 
    /// </para>
    ///  </note> 
    /// <para>
    ///  The user or role that performs this operation must have the <code>cloudformation:GetTemplate</code>
    /// and <code>cloudformation:DescribeStacks</code> IAM policy permissions. 
    /// </para>
    /// </summary>
    public partial class ImportAsProvisionedProductRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private string _idempotencyToken;
        private string _physicalId;
        private string _productId;
        private string _provisionedProductName;
        private string _provisioningArtifactId;

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
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique identifier that you provide to ensure idempotency. If multiple requests differ
        /// only by the idempotency token, the same response is returned for each repeated request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property PhysicalId. 
        /// <para>
        /// The unique identifier of the resource to be imported. It only currently supports CloudFormation
        /// stack IDs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PhysicalId
        {
            get { return this._physicalId; }
            set { this._physicalId = value; }
        }

        // Check to see if PhysicalId property is set
        internal bool IsSetPhysicalId()
        {
            return this._physicalId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedProductName. 
        /// <para>
        /// The user-friendly name of the provisioned product. The value must be unique for the
        /// Amazon Web Services account. The name cannot be updated after the product is provisioned.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property ProvisioningArtifactId. 
        /// <para>
        /// The identifier of the provisioning artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ProvisioningArtifactId
        {
            get { return this._provisioningArtifactId; }
            set { this._provisioningArtifactId = value; }
        }

        // Check to see if ProvisioningArtifactId property is set
        internal bool IsSetProvisioningArtifactId()
        {
            return this._provisioningArtifactId != null;
        }

    }
}