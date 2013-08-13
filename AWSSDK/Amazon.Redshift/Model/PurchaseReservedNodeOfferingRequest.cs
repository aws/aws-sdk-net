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
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the PurchaseReservedNodeOffering operation.
    /// <para> Allows you to purchase reserved nodes. Amazon Redshift offers a predefined set of reserved node offerings. You can purchase one of
    /// the offerings. You can call the DescribeReservedNodeOfferings API to obtain the available reserved node offerings. You can call this API by
    /// providing a specific reserved node offering and the number of nodes you want to reserve. </para> <para> For more information about managing
    /// parameter groups, go to Purchasing Reserved Nodes in the <i>Amazon Redshift Management Guide</i> .
    /// 
    /// </para>
    /// </summary>
    /// <seealso cref="Amazon.Redshift.AmazonRedshift.PurchaseReservedNodeOffering"/>
    public class PurchaseReservedNodeOfferingRequest : AmazonWebServiceRequest
    {
        private string reservedNodeOfferingId;
        private int? nodeCount;

        /// <summary>
        /// The unique identifier of the reserved node offering you want to purchase.
        ///  
        /// </summary>
        public string ReservedNodeOfferingId
        {
            get { return this.reservedNodeOfferingId; }
            set { this.reservedNodeOfferingId = value; }
        }

        /// <summary>
        /// Sets the ReservedNodeOfferingId property
        /// </summary>
        /// <param name="reservedNodeOfferingId">The value to set for the ReservedNodeOfferingId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PurchaseReservedNodeOfferingRequest WithReservedNodeOfferingId(string reservedNodeOfferingId)
        {
            this.reservedNodeOfferingId = reservedNodeOfferingId;
            return this;
        }
            

        // Check to see if ReservedNodeOfferingId property is set
        internal bool IsSetReservedNodeOfferingId()
        {
            return this.reservedNodeOfferingId != null;
        }

        /// <summary>
        /// The number of reserved nodes you want to purchase. Default: <c>1</c>
        ///  
        /// </summary>
        public int NodeCount
        {
            get { return this.nodeCount ?? default(int); }
            set { this.nodeCount = value; }
        }

        /// <summary>
        /// Sets the NodeCount property
        /// </summary>
        /// <param name="nodeCount">The value to set for the NodeCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PurchaseReservedNodeOfferingRequest WithNodeCount(int nodeCount)
        {
            this.nodeCount = nodeCount;
            return this;
        }
            

        // Check to see if NodeCount property is set
        internal bool IsSetNodeCount()
        {
            return this.nodeCount.HasValue;
        }
    }
}
    
