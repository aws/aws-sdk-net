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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Translate.Model
{
    /// <summary>
    /// Paginators for the Translate service
    ///</summary>
    public interface ITranslatePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListLanguages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLanguagesPaginator ListLanguages(ListLanguagesRequest request);

        /// <summary>
        /// Paginator for ListParallelData operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListParallelDataPaginator ListParallelData(ListParallelDataRequest request);

        /// <summary>
        /// Paginator for ListTerminologies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTerminologiesPaginator ListTerminologies(ListTerminologiesRequest request);

        /// <summary>
        /// Paginator for ListTextTranslationJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTextTranslationJobsPaginator ListTextTranslationJobs(ListTextTranslationJobsRequest request);
    }
}