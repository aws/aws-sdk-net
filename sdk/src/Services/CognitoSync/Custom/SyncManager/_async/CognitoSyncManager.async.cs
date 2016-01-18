using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.CognitoSync.SyncManager
{
    public partial class CognitoSyncManager
    {
        /// <summary>
        /// Refreshes dataset metadata. Dataset metadata is pulled from remote
        /// storage and stored in local storage. Their record data isn't pulled down
        /// until you sync each dataset.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DataStorageException">Thrown when fail to fresh dataset metadata</exception>
        public async Task<List<DatasetMetadata>> RefreshDatasetMetadataAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            List<DatasetMetadata> response = await Remote.ListDatasetMetadataAsync(cancellationToken).ConfigureAwait(false);
            Local.UpdateDatasetMetadata(IdentityId, response);
            return response;
        }
    }
}
