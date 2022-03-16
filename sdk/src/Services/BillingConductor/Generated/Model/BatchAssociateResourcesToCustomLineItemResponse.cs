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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// This is the response object from the BatchAssociateResourcesToCustomLineItem operation.
    /// </summary>
    public partial class BatchAssociateResourcesToCustomLineItemResponse : AmazonWebServiceResponse
    {
        private List<AssociateResourceResponseElement> _failedAssociatedResources = new List<AssociateResourceResponseElement>();
        private List<AssociateResourceResponseElement> _successfullyAssociatedResources = new List<AssociateResourceResponseElement>();

        /// <summary>
        /// Gets and sets the property FailedAssociatedResources. 
        /// <para>
        ///  A list of <code>AssociateResourceResponseElement</code> for each resource that failed
        /// association to a percentage custom line item. 
        /// </para>
        /// </summary>
        public List<AssociateResourceResponseElement> FailedAssociatedResources
        {
            get { return this._failedAssociatedResources; }
            set { this._failedAssociatedResources = value; }
        }

        // Check to see if FailedAssociatedResources property is set
        internal bool IsSetFailedAssociatedResources()
        {
            return this._failedAssociatedResources != null && this._failedAssociatedResources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SuccessfullyAssociatedResources. 
        /// <para>
        ///  A list of <code>AssociateResourceResponseElement</code> for each resource that's
        /// been associated to a percentage custom line item successfully. 
        /// </para>
        /// </summary>
        public List<AssociateResourceResponseElement> SuccessfullyAssociatedResources
        {
            get { return this._successfullyAssociatedResources; }
            set { this._successfullyAssociatedResources = value; }
        }

        // Check to see if SuccessfullyAssociatedResources property is set
        internal bool IsSetSuccessfullyAssociatedResources()
        {
            return this._successfullyAssociatedResources != null && this._successfullyAssociatedResources.Count > 0; 
        }

    }
}