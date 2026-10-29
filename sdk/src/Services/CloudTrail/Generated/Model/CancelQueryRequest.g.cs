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
    /// Container for the parameters to the CancelQuery operation. <important> <para> CloudTrail
    /// Lake will no longer be open to new customers starting May 31, 2026. If you would like
    /// to use CloudTrail Lake, sign up prior to that date. Existing customers can continue
    /// to use the service as normal. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-service-availability-change.html">CloudTrail
    /// Lake availability change</a>. </para> </important> <para> Cancels a query if the query
    /// is not in a terminated state, such as <c>CANCELLED</c>, <c>FAILED</c>, <c>TIMED_OUT</c>,
    /// or <c>FINISHED</c>. You must specify an ARN value for <c>EventDataStore</c>. The ID
    /// of the query that you want to cancel is also required. When you run <c>CancelQuery</c>,
    /// the query status might show as <c>CANCELLED</c> even if the operation is not yet finished.
    /// </para>
    /// </summary>
    public partial class CancelQueryRequest : AmazonCloudTrailRequest
    {
        /// <summary>
        /// Gets and sets the property EventDataStore. 
        /// <para>
        /// The ARN (or the ID suffix of the ARN) of an event data store on which the specified
        /// query is running.
        /// </para>
        /// </summary>
        [Obsolete("EventDataStore is no longer required by CancelQueryRequest")]
        [AWSProperty(Min = 3, Max = 256)]
        public string EventDataStore { get; set; }

        /// <summary>
        /// Checks to see if the EventDataStore property is set.
        /// </summary>
        internal bool IsSetEventDataStore() => this.EventDataStore != null;

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
        /// The ID of the query that you want to cancel. The <c>QueryId</c> comes from the response
        /// of a <c>StartQuery</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string QueryId { get; set; }

        /// <summary>
        /// Checks to see if the QueryId property is set.
        /// </summary>
        internal bool IsSetQueryId() => this.QueryId != null;
    }
}
