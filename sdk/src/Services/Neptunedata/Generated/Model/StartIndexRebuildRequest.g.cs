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
    /// Container for the parameters to the StartIndexRebuild operation. Initiates an index
    /// rebuild operation to optimize storage and improve query performance. The rebuild operation
    /// reorganizes index to reclaim space and improve efficiency. <para> When invoking this
    /// operation in a Neptune cluster that has IAM authentication enabled, the IAM user or
    /// role making the request must have a policy attached that allows the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startindexrebuild">neptune-db:StartIndexRebuild</a>
    /// IAM action in that cluster. </para>
    /// </summary>
    public partial class StartIndexRebuildRequest : AmazonNeptunedataRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you don't specify a client token, the SDK automatically generates
        /// one.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Concurrency. 
        /// <para>
        /// The number of concurrent indexes to rebuild in parallel. If not specified, defaults
        /// to <c>1</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values are between <c>1</c> and the number of vCPUs available on the writer
        /// instance. If the value exceeds the available vCPUs, it is capped at the maximum instead
        /// of returning an <c>InvalidParameterException</c>. The effective (capped) value is
        /// returned in the response.
        /// </para>
        ///  
        /// <para>
        /// Higher concurrency can shorten the overall rebuild, but also increases CPU and I/O
        /// load during the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Concurrency { get; set; }

        /// <summary>
        /// Checks to see if the Concurrency property is set.
        /// </summary>
        internal bool IsSetConcurrency() => this.Concurrency.HasValue;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies the scope of the rebuild operation. Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL</c> - Rebuild all (quads and dictionaries). This is the default if not specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>QUADS</c> - Rebuild only the quad indexes. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DICTIONARIES</c> - Rebuild only the dictionaries.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Scope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property WriteBufferSize. 
        /// <para>
        /// Controls the buffer size used for tracking concurrent write operations during the
        /// index rebuild. If your database has high write traffic during the rebuild, a larger
        /// buffer prevents the operation from failing due to buffer overflow. Possible values
        /// are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LOW</c> - Suitable for databases with light to moderate write activity. This is
        /// the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MEDIUM</c> - Recommended for databases with sustained write traffic or bulk loading.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HIGH</c> - Use when rebuilding indexes during heavy write workloads or continuous
        /// bulk data ingestion.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If your rebuild fails and you are actively writing data to the database, retry with
        /// a higher <c>writeBufferSize</c> value. For bulk load operations, consider using <c>HIGH</c>.
        /// </para>
        /// </summary>
        public WriteBufferSize WriteBufferSize { get; set; }

        /// <summary>
        /// Checks to see if the WriteBufferSize property is set.
        /// </summary>
        internal bool IsSetWriteBufferSize() => this.WriteBufferSize != null;
    }
}
