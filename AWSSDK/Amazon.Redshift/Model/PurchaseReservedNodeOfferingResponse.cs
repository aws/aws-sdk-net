/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System;
using Amazon.Runtime;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Returns information about the PurchaseReservedNodeOfferingResult response and response metadata.
    /// </summary>
    public class PurchaseReservedNodeOfferingResponse : AmazonWebServiceResponse
    {
        private PurchaseReservedNodeOfferingResult _purchaseReservedNodeOfferingResult;

        /// <summary>
        /// Gets and sets the PurchaseReservedNodeOfferingResult property.
        /// Represents the output of a PurchaseReservedNodeOffering operation.
        /// </summary>
        public PurchaseReservedNodeOfferingResult PurchaseReservedNodeOfferingResult
        {
            get
            {
                if(this._purchaseReservedNodeOfferingResult == null)
                {
                    this._purchaseReservedNodeOfferingResult = new PurchaseReservedNodeOfferingResult();
                }
                return this._purchaseReservedNodeOfferingResult;
            }
            set { this._purchaseReservedNodeOfferingResult = value; }
        }
    }
}