/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Linq;
using Amazon.S3.Model;
using Amazon.Util;
using Amazon.Runtime.Internal;
using System.Globalization;


namespace Amazon.S3.Transfer
{
    /// <summary>
    /// Request object for downloading a directory with the TransferUtility.
    /// </summary>
    public class TransferUtilityDownloadDirectoryRequest : BaseTransferRequest
    {
        private string s3Directory;
        private string localDirectory;
        private bool downloadFilesConcurrently = false;
        private bool disableSlashCorrection = false;

        /// <summary>
        /// 	Gets or sets the local directory where objects from Amazon S3 will be downloaded.  
		/// 	If the directory doesn't exist, it will be created.
        /// 	For some platforms like Linux, the file system is case-sensitive. The correct casing to the actual path must be used.
        /// </summary>
        /// <value>
        /// 	The local directory where objects from Amazon S3 will be downloaded.
        /// </value>
        public string LocalDirectory
        {
            get { return this.localDirectory; }
            set { this.localDirectory = value; }
        }

        /// <summary>
        /// 	Gets whether or not the LocalDirectory property is set.
        /// </summary>
        /// <returns>
        /// 	A value of <c>true</c> if LocalDirectory property is set.
        /// 	Otherwise, returns <c>false</c>.
        /// </returns>
        internal bool IsSetLocalDirectory()
        {
            return !System.String.IsNullOrEmpty(this.localDirectory);
        }

        /// <summary>
        /// Gets or sets the Amazon S3 directory to download from.  
        /// This is translated to a key prefix; keys that have this prefix will be
        /// downloaded.
        /// 
        /// The TransferUtility will automatically add a / to the end when listing objects for 
        /// to be downloaded. This treats S3Directory field as a virtual S3 directory. In some use
        /// cases the added / slash can be undesirable. To prevent the TransferUtility from adding 
        /// the / at the end set the DisableSlashCorrection property to true.
        /// </summary>
        public string S3Directory
        {
            get { return this.s3Directory; }
            set { this.s3Directory = value; }
        }


        /// <summary>
        /// 	Gets whether or not the S3Directory property is set.
        /// </summary>
        /// <returns>
        /// 	A value of <c>true</c> if S3Directory property is set.
        /// 	Otherwise, returns <c>false</c>.
        /// </returns>
        internal bool IsSetS3Directory()
        {
            return !System.String.IsNullOrEmpty(this.s3Directory);
        }


        /// <summary>
        /// Gets or sets the DownloadFilesConcurrently property.
        /// Specifies if multiple files will be downloaded concurrently.
        /// The number of concurrent web requests used is controlled 
        /// by the TransferUtilityConfig.ConcurrencyLevel property.
        /// </summary>
#if BCL || NETSTANDARD
        public
#else
        internal
#endif
        bool DownloadFilesConcurrently
        {
            get { return this.downloadFilesConcurrently; }
            set { this.downloadFilesConcurrently = value; }
        }

        /// <summary>
        /// If this is set to true then the TransferUtility will not ensure the S3Directory property has a trailing / for a virtual S3 directory. 
        /// The default value is false.
        /// </summary>
        public bool DisableSlashCorrection
        {
            get { return this.disableSlashCorrection; }
            set { this.disableSlashCorrection = value; }
        }


        /// <summary>
        /// The event for DownloadedDirectoryProgressEvent notifications. All
        /// subscribers will be notified when a new progress
        /// event is raised.
        /// <para>
        /// The DownloadedDirectoryProgressEvent is fired as data
        /// is downloaded from Amazon S3.  The delegates attached to the event 
        /// will be passed information detailing how much data
        /// has been downloaded as well as how much will be downloaded.
        /// </para>
        /// </summary>
        /// <remarks>
        /// Subscribe to this event if you want to receive
        /// DownloadedDirectoryProgressEvent notifications. Here is how:<br />
        /// 1. Define a method with a signature similar to this one:
        /// <code>
        /// private void displayProgress(object sender, DownloadDirectoryProgressArgs args)
        /// {
        ///     Console.WriteLine(args);
        /// }
        /// </code>
        /// 2. Add this method to the DownloadedDirectoryProgressEvent delegate's invocation list
        /// <code>
        /// TransferUtilityDownloadDirectoryRequest request = new TransferUtilityDownloadDirectoryRequest();
        /// request.DownloadedDirectoryProgressEvent += displayProgress;
        /// </code>
        /// </remarks>
        public event EventHandler<DownloadDirectoryProgressArgs> DownloadedDirectoryProgressEvent;


        internal void OnRaiseProgressEvent(DownloadDirectoryProgressArgs downloadDirectoryProgress)
        {
            AWSSDKUtils.InvokeInBackground(DownloadedDirectoryProgressEvent, downloadDirectoryProgress, this);
        }
    }

    /// <summary>
    /// Encapsulates the information needed to provide
    /// transfer progress to subscribers of the <c>DownloadDirectory</c>
    /// event.
    /// </summary>
    public class DownloadDirectoryProgressArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of <c>DownloadDirectoryProgressArgs</c>.
        /// </summary>
        /// <param name="numberOfFilesDownloaded">
        /// The number of files downloaded.
        /// </param>
        /// <param name="totalNumberOfFiles">
        /// The total number of files to download.
        /// </param>
        /// <param name="currentFile">
        /// The current file being downloaded
        /// </param>
        /// <param name="transferredBytesForCurrentFile">
        /// The number of transferred bytes for the current file.
        /// </param>
        /// <param name="totalNumberOfBytesForCurrentFile">
        /// The size of the current file in bytes.
        /// </param>
        public DownloadDirectoryProgressArgs(int numberOfFilesDownloaded, int totalNumberOfFiles,
            string currentFile, long transferredBytesForCurrentFile, long totalNumberOfBytesForCurrentFile)
        {
            this.NumberOfFilesDownloaded = numberOfFilesDownloaded;
            this.TotalNumberOfFiles = totalNumberOfFiles;
            this.CurrentFile = currentFile;
            this.TransferredBytesForCurrentFile = transferredBytesForCurrentFile;
            this.TotalNumberOfBytesForCurrentFile = totalNumberOfBytesForCurrentFile;
        }

        /// <summary>
        /// Constructs a new instance of <c>DownloadDirectoryProgressArgs</c>.
        /// </summary>
        /// <param name="numberOfFilesDownloaded">
        /// The number of files downloaded.
        /// </param>
        /// <param name="totalNumberOfFiles">
        /// The total number of files to download.
        /// </param>
        /// <param name="transferredBytes">
        /// The bytes transferred across all files being downloaded.
        /// </param>
        /// <param name="totalBytes">
        /// The total number of bytes across all files being downloaded.
        /// </param>
        /// <param name="currentFile">
        /// The current file being downloaded.
        /// </param>
        /// <param name="transferredBytesForCurrentFile">
        /// The number of transferred bytes for the current file.
        /// </param>
        /// <param name="totalNumberOfBytesForCurrentFile">
        /// The size of the current file in bytes.
        /// </param>
        public DownloadDirectoryProgressArgs(int numberOfFilesDownloaded, int totalNumberOfFiles, long transferredBytes, long totalBytes,
            string currentFile, long transferredBytesForCurrentFile, long totalNumberOfBytesForCurrentFile)
        {
            this.NumberOfFilesDownloaded = numberOfFilesDownloaded;
            this.TotalNumberOfFiles = totalNumberOfFiles;
            this.TransferredBytes = transferredBytes;
            this.TotalBytes = totalBytes;
            this.CurrentFile = currentFile;
            this.TransferredBytesForCurrentFile = transferredBytesForCurrentFile;
            this.TotalNumberOfBytesForCurrentFile = totalNumberOfBytesForCurrentFile;
        }

        /// <summary>
        /// Gets or sets the total number of files.
        /// </summary>
        /// <value>The total number of files.</value>
        public int TotalNumberOfFiles { get; set; }

        /// <summary>
        /// Gets or sets the number of files downloaded so far.
        /// </summary>
        /// <value>The number of files downloaded.</value>
        public int NumberOfFilesDownloaded { get; set; }

        /// <summary>
        /// Gets or sets the total number of bytes across all files being downloaded.
        /// </summary>
        /// <value>The total number of bytes across all files being downloaded.</value>
        public long TotalBytes { get; set; }

        /// <summary>
        /// Gets or sets the bytes transferred across all files being downloaded.
        /// </summary>
        /// <value>The bytes transferred across all files being downloaded.</value>
        public long TransferredBytes { get; set; }


#if BCL
        /// <summary>
        /// Gets or sets the current file being downloaded.
        /// </summary>
        /// <remarks>
        /// This property is only valid if DownloadDirectory is used without enabling concurrent file downloads (by default concurrent download is disabled).
        /// If concurrent file downloads are enabled by setting TransferUtilityDownloadDirectoryRequest.DownloadFilesConcurrently to true, this property
        /// will return null.
        /// </remarks>
        /// <value>The current file being downloaded.</value>
#else
        /// <summary>
        /// Gets or sets the current file being downloaded.
        /// </summary>
        /// <value>The current file being downloaded.</value>
#endif
        public string CurrentFile { get; set; }

#if BCL
        /// <summary>
        /// Gets or sets the transferred bytes for the current file.
        /// </summary>
        /// <remarks>
        /// This property is only valid if DownloadDirectory is used without enabling concurrent file downloads (by default concurrent download is disabled).
        /// If concurrent file downloads are enabled by setting TransferUtilityDownloadDirectoryRequest.DownloadFilesConcurrently to true, this property
        /// will return 0.
        /// </remarks>
        /// <value>The transferred bytes for the current file.</value>
#else
        /// <summary>
        /// Gets or sets the transferred bytes for the current file.
        /// </summary>       
        /// <value>The transferred bytes for the current file.</value>
#endif
        public long TransferredBytesForCurrentFile { get; set; }

#if BCL
        /// <summary>
        /// Gets or sets the total number of bytes for the current file.
        /// </summary>
        /// <remarks>
        /// This property is only valid if DownloadDirectory is used without enabling concurrent file downloads (by default concurrent download is disabled).
        /// If concurrent file downloads are enabled by setting TransferUtilityDownloadDirectoryRequest.DownloadFilesConcurrently to true, this property
        /// will return 0.
        /// </remarks>
        /// <value>The total number of bytes for the current file.</value>
#else
        /// <summary>
        /// Gets or sets the total number of bytes for the current file.
        /// </summary>      
        /// <value>The total number of bytes for the current file.</value>
#endif
        public long TotalNumberOfBytesForCurrentFile { get; set; }

        /// <summary>
        /// The string representation of this instance of DownloadDirectoryProgressArgs.
        /// </summary>
        /// <returns>The string representation of this instance of DownloadDirectoryProgressArgs.</returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "Total Files: {0}, Downloaded Files {1}, Total Bytes: {2}, Transferred Bytes: {3}",
                this.TotalNumberOfFiles, this.NumberOfFilesDownloaded, this.TotalBytes, this.TransferredBytes);
        }
    }
}
