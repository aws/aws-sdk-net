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
    /// Container for the parameters to the DeleteProvisionedProductPlan operation.
    /// Deletes the specified plan.
    /// </summary>
    public partial class DeleteProvisionedProductPlanRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private bool? _ignoreErrors;
        private string _planId;

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
        /// Gets and sets the property PlanId. 
        /// <para>
        /// The plan identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string PlanId
        {
            get { return this._planId; }
            set { this._planId = value; }
        }

        // Check to see if PlanId property is set
        internal bool IsSetPlanId()
        {
            return this._planId != null;
        }

    }
}