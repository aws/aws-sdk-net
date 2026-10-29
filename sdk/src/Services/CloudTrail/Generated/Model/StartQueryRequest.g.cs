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
    /// Container for the parameters to the StartQuery operation. <important> <para> CloudTrail
    /// Lake will no longer be open to new customers starting May 31, 2026. If you would like
    /// to use CloudTrail Lake, sign up prior to that date. Existing customers can continue
    /// to use the service as normal. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-service-availability-change.html">CloudTrail
    /// Lake availability change</a>. </para> </important> <para> Starts a CloudTrail Lake
    /// query. Use the <c>QueryStatement</c> parameter to provide your SQL query, enclosed
    /// in single quotation marks. Use the optional <c>DeliveryS3Uri</c> parameter to deliver
    /// the query results to an S3 bucket. </para> <para> <c>StartQuery</c> requires you specify
    /// either the <c>QueryStatement</c> parameter, or a <c>QueryAlias</c> and any <c>QueryParameters</c>.
    /// In the current release, the <c>QueryAlias</c> and <c>QueryParameters</c> parameters
    /// are used only for the queries that populate the CloudTrail Lake dashboards. </para>
    /// </summary>
    public partial class StartQueryRequest : AmazonCloudTrailRequest
    {
        /// <summary>
        /// Gets and sets the property DeliveryS3Uri. 
        /// <para>
        ///  The URI for the S3 bucket where CloudTrail delivers the query results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DeliveryS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryS3Uri property is set.
        /// </summary>
        internal bool IsSetDeliveryS3Uri() => this.DeliveryS3Uri != null;

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
        /// Gets and sets the property QueryAlias. 
        /// <para>
        ///  The alias that identifies a query template. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string QueryAlias { get; set; }

        /// <summary>
        /// Checks to see if the QueryAlias property is set.
        /// </summary>
        internal bool IsSetQueryAlias() => this.QueryAlias != null;

        /// <summary>
        /// Gets and sets the property QueryParameters. 
        /// <para>
        ///  The query parameters for the specified <c>QueryAlias</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> QueryParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the QueryParameters property is set.
        /// </summary>
        internal bool IsSetQueryParameters() => this.QueryParameters != null && (this.QueryParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryStatement. 
        /// <para>
        /// The SQL code of your query.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public string QueryStatement { get; set; }

        /// <summary>
        /// Checks to see if the QueryStatement property is set.
        /// </summary>
        internal bool IsSetQueryStatement() => this.QueryStatement != null;
    }
}
