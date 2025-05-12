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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.QLDB.Model
{
    /// <summary>
    /// Paginators for the QLDB service
    ///</summary>
    public interface IQLDBPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListJournalKinesisStreamsForLedger operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListJournalKinesisStreamsForLedgerPaginator ListJournalKinesisStreamsForLedger(ListJournalKinesisStreamsForLedgerRequest request);

        /// <summary>
        /// Paginator for ListJournalS3Exports operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListJournalS3ExportsPaginator ListJournalS3Exports(ListJournalS3ExportsRequest request);

        /// <summary>
        /// Paginator for ListJournalS3ExportsForLedger operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListJournalS3ExportsForLedgerPaginator ListJournalS3ExportsForLedger(ListJournalS3ExportsForLedgerRequest request);

        /// <summary>
        /// Paginator for ListLedgers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLedgersPaginator ListLedgers(ListLedgersRequest request);
    }
}