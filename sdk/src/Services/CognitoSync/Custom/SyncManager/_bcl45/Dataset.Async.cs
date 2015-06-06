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
using Amazon.CognitoIdentity;
using Amazon.CognitoSync.SyncManager.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;


namespace Amazon.CognitoSync.SyncManager
{

    public partial class Dataset : IDisposable
    {
        /// <summary>
        /// Synchronize <see cref="Dataset"/> between local storage and remote storage.
        /// </summary>
        public virtual Task SynchronizeAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                FireSyncFailureEvent(new NetworkException("Network connectivity unavailable."));
                return null;
            }

            return AsyncRunner.Run(() => SynchronizeHelper(), cancellationToken);
        }
    }

}

