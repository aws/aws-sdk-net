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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Details of a provisioned service catalog product. For information about service catalog,
    /// see <a href="https://docs.aws.amazon.com/servicecatalog/latest/adminguide/introduction.html">What
    /// is Amazon Web Services Service Catalog</a>.
    /// </summary>
    public partial class ServiceCatalogProvisionedProductDetails
    {
        private string _provisionedProductId;
        private string _provisionedProductStatusMessage;

        /// <summary>
        /// Gets and sets the property ProvisionedProductId. 
        /// <para>
        /// The ID of the provisioned product.
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
        /// Gets and sets the property ProvisionedProductStatusMessage. 
        /// <para>
        /// The current status of the product.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> - Stable state, ready to perform any operation. The most recent
        /// operation succeeded and completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNDER_CHANGE</c> - Transitive state. Operations performed might not have valid
        /// results. Wait for an AVAILABLE status before performing operations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TAINTED</c> - Stable state, ready to perform any operation. The stack has completed
        /// the requested operation but is not exactly what was requested. For example, a request
        /// to update to a new version failed and the stack rolled back to the current version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c> - An unexpected error occurred. The provisioned product exists but the
        /// stack is not running. For example, CloudFormation received a parameter value that
        /// was not valid and could not launch the stack.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PLAN_IN_PROGRESS</c> - Transitive state. The plan operations were performed to
        /// provision a new product, but resources have not yet been created. After reviewing
        /// the list of resources to be created, execute the plan. Wait for an AVAILABLE status
        /// before performing operations.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ProvisionedProductStatusMessage
        {
            get { return this._provisionedProductStatusMessage; }
            set { this._provisionedProductStatusMessage = value; }
        }

        // Check to see if ProvisionedProductStatusMessage property is set
        internal bool IsSetProvisionedProductStatusMessage()
        {
            return this._provisionedProductStatusMessage != null;
        }

    }
}