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
    /// Allows you to purchase reserved nodes. Amazon Redshift offers a predefined
    /// set of reserved node offerings.           You can purchase one of the offerings. You
    /// can call the           <a>DescribeReservedNodeOfferings</a> API to obtain the available
    /// reserved node offerings. You can call this            API by providing a specific
    /// reserved node offering and the number of nodes you want to reserve.       
    /// 
    ///        
    /// <para>
    ///            For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
    /// Reserved Nodes</a> in the <i>Amazon Redshift Management Guide</i>.               
    ///     
    /// </para>
    /// </summary>
    public partial class PurchaseReservedNodeOfferingRequest : AmazonWebServiceRequest
    {
        private int? _nodeCount;
        private string _reservedNodeOfferingId;


        /// <summary>
        /// Gets and sets the property NodeCount. 
        /// <para>
        /// The number of reserved nodes you want to purchase.
        /// </para>
        ///        
        /// <para>
        /// Default: <code>1</code>
        /// </para>
        /// </summary>
        public int NodeCount
        {
            get { return this._nodeCount.GetValueOrDefault(); }
            set { this._nodeCount = value; }
        }


        /// <summary>
        /// Sets the NodeCount property
        /// </summary>
        /// <param name="nodeCount">The value to set for the NodeCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PurchaseReservedNodeOfferingRequest WithNodeCount(int nodeCount)
        {
            this._nodeCount = nodeCount;
            return this;
        }

        // Check to see if NodeCount property is set
        internal bool IsSetNodeCount()
        {
            return this._nodeCount.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property ReservedNodeOfferingId. 
        /// <para>
        /// The unique identifier of the reserved node offering you want to purchase.
        /// </para>
        /// </summary>
        public string ReservedNodeOfferingId
        {
            get { return this._reservedNodeOfferingId; }
            set { this._reservedNodeOfferingId = value; }
        }


        /// <summary>
        /// Sets the ReservedNodeOfferingId property
        /// </summary>
        /// <param name="reservedNodeOfferingId">The value to set for the ReservedNodeOfferingId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PurchaseReservedNodeOfferingRequest WithReservedNodeOfferingId(string reservedNodeOfferingId)
        {
            this._reservedNodeOfferingId = reservedNodeOfferingId;
            return this;
        }

        // Check to see if ReservedNodeOfferingId property is set
        internal bool IsSetReservedNodeOfferingId()
        {
            return this._reservedNodeOfferingId != null;
        }

    }
}