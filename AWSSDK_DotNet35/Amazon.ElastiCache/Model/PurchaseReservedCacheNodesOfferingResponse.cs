/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Returns information about the PurchaseReservedCacheNodesOffering response and response metadata.
    /// </summary>
    public class PurchaseReservedCacheNodesOfferingResponse : PurchaseReservedCacheNodesOfferingResult
    {
        /// 
        /// Gets and sets the PurchaseReservedCacheNodesOfferingResult property.
        /// Contains the result of a successful invocation of the PurchaseReservedCacheNodesOffering
        /// action.
        /// 
        [Obsolete(@"This property has been deprecated. All properties of the PurchaseReservedCacheNodesOfferingResult class are now available on the PurchaseReservedCacheNodesOfferingResponse class. You should use the properties on PurchaseReservedCacheNodesOfferingResponse instead of accessing them through PurchaseReservedCacheNodesOfferingResult.")]
        public PurchaseReservedCacheNodesOfferingResult PurchaseReservedCacheNodesOfferingResult
        {
            get
            {
                return this;
            }
        }
    }
}
    
