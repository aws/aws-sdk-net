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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// This is the response object from the CancelQuery operation.
    /// </summary>
    public partial class CancelQueryResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EventDataStoreOwnerAccountId. 
        /// <para>
        ///  The account ID of the event data store owner. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 16)]
        public string EventDataStoreOwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the EventDataStoreOwnerAccountId property is set.
        /// </summary>
        internal bool IsSetEventDataStoreOwnerAccountId() => this.EventDataStoreOwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The ID of the canceled query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string QueryId { get; set; }

        /// <summary>
        /// Checks to see if the QueryId property is set.
        /// </summary>
        internal bool IsSetQueryId() => this.QueryId != null;

        /// <summary>
        /// Gets and sets the property QueryStatus. 
        /// <para>
        /// Shows the status of a query after a <c>CancelQuery</c> request. Typically, the values
        /// shown are either <c>RUNNING</c> or <c>CANCELLED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QueryStatus QueryStatus { get; set; }

        /// <summary>
        /// Checks to see if the QueryStatus property is set.
        /// </summary>
        internal bool IsSetQueryStatus() => this.QueryStatus != null;
    }
}
