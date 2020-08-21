/*
 * Copyright 2012-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

#if NETCOREAPP3_1 || NETSTANDARD20
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;

namespace Amazon.DynamoDBv2.DataModel
{
    public partial class AsyncSearch<T> : IAsyncEnumerable<IList<T>>
    {
        #region IAsyncEnumerable<IList<T>>

        /// <summary>
        /// Gets asynchronous enumerators of results from DynamoDB.
        /// </summary>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>
        /// Asynchronous enumerator of results from DynamoDB.
        /// </returns>
        public IAsyncEnumerator<IList<T>> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            return new AsyncSearchEnumerator<T>(this, cancellationToken);
        }

        #endregion
    }

    internal sealed class AsyncSearchEnumerator<T> : IAsyncEnumerator<IList<T>>
    {
 
        #region Private members

        private readonly AsyncSearch<T> SearchSource;
        private readonly CancellationToken CancellationToken;

        #endregion

        #region Constructor

        public AsyncSearchEnumerator(AsyncSearch<T> searchSource, CancellationToken cancellationToken = default)
        {
            SearchSource = searchSource;
            CancellationToken = cancellationToken;
            Current = default;
        }
 
        #endregion

        #region IAsyncEnumerator<IList<T>>

        public IList<T> Current { get; private set; }

        public ValueTask DisposeAsync() => default;

        public async ValueTask<bool> MoveNextAsync()
        {
            if (SearchSource.IsDone)
            {
                return false;
            }
            Current = await SearchSource.GetNextSetAsync(CancellationToken).ConfigureAwait(false);
            return true;
        }

        #endregion
    }
}
#endif