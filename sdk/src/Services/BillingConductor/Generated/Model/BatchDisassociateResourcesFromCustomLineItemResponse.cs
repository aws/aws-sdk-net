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
    /// This is the response object from the BatchDisassociateResourcesFromCustomLineItem operation.
    /// </summary>
    public partial class BatchDisassociateResourcesFromCustomLineItemResponse : AmazonWebServiceResponse
    {
        private List<DisassociateResourceResponseElement> _failedDisassociatedResources = new List<DisassociateResourceResponseElement>();
        private List<DisassociateResourceResponseElement> _successfullyDisassociatedResources = new List<DisassociateResourceResponseElement>();

        /// <summary>
        /// Gets and sets the property FailedDisassociatedResources. 
        /// <para>
        ///  A list of <code>DisassociateResourceResponseElement</code> for each resource that
        /// failed disassociation from a percentage custom line item. 
        /// </para>
        /// </summary>
        public List<DisassociateResourceResponseElement> FailedDisassociatedResources
        {
            get { return this._failedDisassociatedResources; }
            set { this._failedDisassociatedResources = value; }
        }

        // Check to see if FailedDisassociatedResources property is set
        internal bool IsSetFailedDisassociatedResources()
        {
            return this._failedDisassociatedResources != null && this._failedDisassociatedResources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SuccessfullyDisassociatedResources. 
        /// <para>
        ///  A list of <code>DisassociateResourceResponseElement</code> for each resource that's
        /// been disassociated from a percentage custom line item successfully. 
        /// </para>
        /// </summary>
        public List<DisassociateResourceResponseElement> SuccessfullyDisassociatedResources
        {
            get { return this._successfullyDisassociatedResources; }
            set { this._successfullyDisassociatedResources = value; }
        }

        // Check to see if SuccessfullyDisassociatedResources property is set
        internal bool IsSetSuccessfullyDisassociatedResources()
        {
            return this._successfullyDisassociatedResources != null && this._successfullyDisassociatedResources.Count > 0; 
        }

    }
}