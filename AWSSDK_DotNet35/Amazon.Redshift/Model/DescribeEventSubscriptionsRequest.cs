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
    /// Container for the parameters to the DescribeEventSubscriptions operation.
    /// <para> Lists descriptions of all the Amazon Redshift event notifications subscription for a customer account. If you specify a subscription
    /// name, lists the description for that subscription. </para>
    /// </summary>
    public partial class DescribeEventSubscriptionsRequest : AmazonRedshiftRequest
    {
        private string subscriptionName;
        private int? maxRecords;
        private string marker;


        /// <summary>
        /// The name of the Amazon Redshift event notification subscription to be described.
        ///  
        /// </summary>
        public string SubscriptionName
        {
            get { return this.subscriptionName; }
            set { this.subscriptionName = value; }
        }

        // Check to see if SubscriptionName property is set
        internal bool IsSetSubscriptionName()
        {
            return this.subscriptionName != null;
        }

        /// <summary>
        /// The maximum number of records to include in the response. If more records exist than the specified MaxRecords value, a pagination token
        /// called a marker is included in the response so that the remaining results can be retrieved. Default: 100 Constraints: minimum 20, maximum
        /// 100
        ///  
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;
        }

        /// <summary>
        /// An optional pagination token provided by a previous DescribeOrderableClusterOptions request. If this parameter is specified, the response
        /// includes only records beyond the marker, up to the value specified by MaxRecords.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

    }
}
    
