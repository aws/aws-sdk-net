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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
    /// Container for the parameters to the DescribeQuery operation.
    /// Returns metadata about a query, including query run time in milliseconds, number of
    /// events scanned and matched, and query status. If the query results were delivered
    /// to an S3 bucket, the response also provides the S3 URI and the delivery status.
    /// 
    ///  
    /// <para>
    /// You must specify either <c>QueryId</c> or <c>QueryAlias</c>. Specifying the <c>QueryAlias</c>
    /// parameter returns information about the last query run for the alias. You can provide
    /// <c>RefreshId</c> along with <c>QueryAlias</c> to view the query results of a dashboard
    /// query for the specified <c>RefreshId</c>.
    /// </para>
    /// </summary>
    public partial class DescribeQueryRequest : AmazonCloudTrailRequest
    {
        private string _eventDataStore;
        private string _eventDataStoreOwnerAccountId;
        private string _queryAlias;
        private string _queryId;
        private string _refreshId;

        /// <summary>
        /// Gets and sets the property EventDataStore. 
        /// <para>
        /// The ARN (or the ID suffix of the ARN) of an event data store on which the specified
        /// query was run.
        /// </para>
        /// </summary>
        [Obsolete("EventDataStore is no longer required by DescribeQueryRequest")]
        [AWSProperty(Min=3, Max=256)]
        public string EventDataStore
        {
            get { return this._eventDataStore; }
            set { this._eventDataStore = value; }
        }

        // Check to see if EventDataStore property is set
        internal bool IsSetEventDataStore()
        {
            return this._eventDataStore != null;
        }

        /// <summary>
        /// Gets and sets the property EventDataStoreOwnerAccountId. 
        /// <para>
        ///  The account ID of the event data store owner. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=16)]
        public string EventDataStoreOwnerAccountId
        {
            get { return this._eventDataStoreOwnerAccountId; }
            set { this._eventDataStoreOwnerAccountId = value; }
        }

        // Check to see if EventDataStoreOwnerAccountId property is set
        internal bool IsSetEventDataStoreOwnerAccountId()
        {
            return this._eventDataStoreOwnerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property QueryAlias. 
        /// <para>
        ///  The alias that identifies a query template. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string QueryAlias
        {
            get { return this._queryAlias; }
            set { this._queryAlias = value; }
        }

        // Check to see if QueryAlias property is set
        internal bool IsSetQueryAlias()
        {
            return this._queryAlias != null;
        }

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The query ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string QueryId
        {
            get { return this._queryId; }
            set { this._queryId = value; }
        }

        // Check to see if QueryId property is set
        internal bool IsSetQueryId()
        {
            return this._queryId != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshId. 
        /// <para>
        ///  The ID of the dashboard refresh. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=20)]
        public string RefreshId
        {
            get { return this._refreshId; }
            set { this._refreshId = value; }
        }

        // Check to see if RefreshId property is set
        internal bool IsSetRefreshId()
        {
            return this._refreshId != null;
        }

    }
}