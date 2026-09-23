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

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// This is the response object from the GetPropertygraphStream operation.
    /// </summary>
    public partial class GetPropertygraphStreamResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// Serialization format for the change records being returned. Currently, the only supported
        /// value is <c>PG_JSON</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property LastEventId. 
        /// <para>
        /// Sequence identifier of the last change in the stream response.
        /// </para>
        ///  
        /// <para>
        /// An event ID is composed of two fields: a <c>commitNum</c>, which identifies a transaction
        /// that changed the graph, and an <c>opNum</c>, which identifies a specific operation
        /// within that transaction:
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, string> LastEventId { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the LastEventId property is set.
        /// </summary>
        internal bool IsSetLastEventId() => this.LastEventId != null && (this.LastEventId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastTrxTimestampInMillis. 
        /// <para>
        /// The time at which the commit for the transaction was requested, in milliseconds from
        /// the Unix epoch.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? LastTrxTimestampInMillis { get; set; }

        /// <summary>
        /// Checks to see if the LastTrxTimestampInMillis property is set.
        /// </summary>
        internal bool IsSetLastTrxTimestampInMillis() => this.LastTrxTimestampInMillis.HasValue;

        /// <summary>
        /// Gets and sets the property Records. 
        /// <para>
        /// An array of serialized change-log stream records included in the response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<PropertygraphRecord> Records { get; set; } = AWSConfigs.InitializeCollections ? new List<PropertygraphRecord>() : null;

        /// <summary>
        /// Checks to see if the Records property is set.
        /// </summary>
        internal bool IsSetRecords() => this.Records != null && (this.Records.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalRecords. 
        /// <para>
        /// The total number of records in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TotalRecords { get; set; }

        /// <summary>
        /// Checks to see if the TotalRecords property is set.
        /// </summary>
        internal bool IsSetTotalRecords() => this.TotalRecords.HasValue;
    }
}
