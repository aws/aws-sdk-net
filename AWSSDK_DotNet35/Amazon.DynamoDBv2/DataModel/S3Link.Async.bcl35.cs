using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.DynamoDBv2.DataModel
{
    public partial class S3Link
    {
        #region Upload/PutObject

        /// <summary>
        /// Initiates the asynchronous execution of the UploadFrom operation.
        /// </summary>
        /// <param name="sourcePath">Path of the file to be uploaded.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property</param>
        public void BeginUploadFrom(string sourcePath, AsyncCallback callback, object state)
        {
            GetTransferUtility().BeginUpload(sourcePath, this.linker.s3.bucket, this.linker.s3.key, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the UploadFrom operation.
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadFrom.</param>
        public void EndUploadFrom(IAsyncResult asyncResult)
        {
            GetTransferUtility().EndUpload(asyncResult);
        }

        #endregion

        #region Download/GetObject

        /// <summary>
        /// Initiates the asynchronous execution of the DownloadTo operation.
        /// </summary>
        /// <param name="downloadPath">Path to save the file.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property</param>
        public void BeginDownloadTo(string downloadPath, AsyncCallback callback, object state)
        {
            GetTransferUtility().BeginDownload(downloadPath, this.linker.s3.bucket, this.linker.s3.key, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the DownloadTo operation.
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDownloadTo.</param>
        public void EndDownloadTo(IAsyncResult asyncResult)
        {
            GetTransferUtility().EndDownload(asyncResult);
        }

        #endregion
    }
}
