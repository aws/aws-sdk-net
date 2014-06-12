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
    /// Container for the parameters to the DescribeReservedNodeOfferings operation.
    /// Returns a list of the            available reserved node offerings by
    /// Amazon Redshift with their descriptions including             the node type, the fixed
    /// and recurring costs of reserving the node and duration the node will             be
    /// reserved for you. These descriptions help you             determine which reserve
    /// node offering you want to purchase. You then use the unique offering ID          
    ///   in you call to <a>PurchaseReservedNodeOffering</a> to reserve one or more nodes
    /// for your             Amazon Redshift cluster.        
    /// 
    ///         
    /// <para>
    ///             For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
    /// Reserved Nodes</a> in the <i>Amazon Redshift Management Guide</i>.               
    ///      
    /// </para>
    /// </summary>
    public partial class DescribeReservedNodeOfferingsRequest : AmazonWebServiceRequest
    {
        private string _marker;
        private int? _maxRecords;
        private string _reservedNodeOfferingId;


        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///            An optional parameter that specifies the starting point to return a set
        /// of response records.            When the results of a <a>DescribeReservedNodeOfferings</a>
        /// request exceed the value specified in <code>MaxRecords</code>,            AWS returns
        /// a value in the <code>Marker</code> field of the response. You can retrieve the next
        /// set of            response records by providing the returned marker value in the <code>Marker</code>
        /// parameter and            retrying the request.       
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }


        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeReservedNodeOfferingsRequest WithMarker(string marker)
        {
            this._marker = marker;
            return this;
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }


        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        ///            The maximum number of response records to return in each call.        
        ///    If the number of remaining response records exceeds the specified <code>MaxRecords</code>
        /// value,            a value is returned in a <code>marker</code> field of the response.
        ///            You can retrieve the next set of records by retrying the command with the
        /// returned marker value.       
        /// </para>
        ///        
        /// <para>
        /// Default: <code>100</code>
        /// </para>
        ///        
        /// <para>
        /// Constraints: minimum 20, maximum 100.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }


        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeReservedNodeOfferingsRequest WithMaxRecords(int maxRecords)
        {
            this._maxRecords = maxRecords;
            return this;
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property ReservedNodeOfferingId. 
        /// <para>
        /// The unique identifier for the offering.
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
        public DescribeReservedNodeOfferingsRequest WithReservedNodeOfferingId(string reservedNodeOfferingId)
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