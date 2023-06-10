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
    /// Container for the parameters to the UpdateProvisionedProductProperties operation.
    /// Requests updates to the properties of the specified provisioned product.
    /// </summary>
    public partial class UpdateProvisionedProductPropertiesRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private string _idempotencyToken;
        private string _provisionedProductId;
        private Dictionary<string, string> _provisionedProductProperties = new Dictionary<string, string>();

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
        /// The idempotency token that uniquely identifies the provisioning product update request.
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
        /// Gets and sets the property ProvisionedProductId. 
        /// <para>
        /// The identifier of the provisioned product.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property ProvisionedProductProperties. 
        /// <para>
        /// A map that contains the provisioned product properties to be updated.
        /// </para>
        ///  
        /// <para>
        /// The <code>LAUNCH_ROLE</code> key accepts role ARNs. This key allows an administrator
        /// to call <code>UpdateProvisionedProductProperties</code> to update the launch role
        /// that is associated with a provisioned product. This role is used when an end user
        /// calls a provisioning operation such as <code>UpdateProvisionedProduct</code>, <code>TerminateProvisionedProduct</code>,
        /// or <code>ExecuteProvisionedProductServiceAction</code>. Only a role ARN is valid.
        /// A user ARN is invalid. 
        /// </para>
        ///  
        /// <para>
        /// The <code>OWNER</code> key accepts user ARNs, IAM role ARNs, and STS assumed-role
        /// ARNs. The owner is the user that has permission to see, update, terminate, and execute
        /// service actions in the provisioned product.
        /// </para>
        ///  
        /// <para>
        /// The administrator can change the owner of a provisioned product to another IAM or
        /// STS entity within the same account. Both end user owners and administrators can see
        /// ownership history of the provisioned product using the <code>ListRecordHistory</code>
        /// API. The new owner can describe all past records for the provisioned product using
        /// the <code>DescribeRecord</code> API. The previous owner can no longer use <code>DescribeRecord</code>,
        /// but can still see the product's history from when he was an owner using <code>ListRecordHistory</code>.
        /// </para>
        ///  
        /// <para>
        /// If a provisioned product ownership is assigned to an end user, they can see and perform
        /// any action through the API or Service Catalog console such as update, terminate, and
        /// execute service actions. If an end user provisions a product and the owner is updated
        /// to someone else, they will no longer be able to see or perform any actions through
        /// API or the Service Catalog console on that provisioned product.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public Dictionary<string, string> ProvisionedProductProperties
        {
            get { return this._provisionedProductProperties; }
            set { this._provisionedProductProperties = value; }
        }

        // Check to see if ProvisionedProductProperties property is set
        internal bool IsSetProvisionedProductProperties()
        {
            return this._provisionedProductProperties != null && this._provisionedProductProperties.Count > 0; 
        }

    }
}