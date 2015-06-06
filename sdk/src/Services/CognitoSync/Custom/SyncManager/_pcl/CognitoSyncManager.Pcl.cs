//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CognitoSync.SyncManager.Internal;
using Amazon.CognitoIdentity;
using Amazon.Runtime.Internal.Util;
using Amazon.Util.Internal;
using System.Threading.Tasks;
using Amazon.Runtime.Internal;
using System.Threading;

namespace Amazon.CognitoSync.SyncManager
{
    public partial class CognitoSyncManager : IDisposable
    {
        /// <summary>
        /// Refreshes dataset metadata. Dataset metadata is pulled from remote
        /// storage and stored in local storage. Their record data isn't pulled down
        /// until you sync each dataset.
        /// </summary>
        /// <param name="callback">Callback once the refresh is complete</param>
        /// <param name="options">Options for asynchronous execution</param>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DataStorageException">Thrown when fail to fresh dataset metadata</exception>
        public Task<List<DatasetMetadata>> RefreshDatasetMetadataAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return AsyncRunner.Run(() => RefreshDatasetMetadataHelper(), cancellationToken);
        }
    }
}
