/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.S3.Model;
using Amazon.Util;
using System.Globalization;

namespace Amazon.S3.Transfer
{
    public class TransferUtilityDownloadDirectoryRequest
    {
        private string bucketName;
        private string s3Directory;
        private string localDirectory;
        private DateTime? modifiedSinceDate;
        private DateTime? unmodifiedSinceDate;

        /// <summary>
        /// 	Gets or sets the name of the bucket.
        /// </summary>
        /// <value>
        /// 	The name of the bucket.
        /// </value>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Gets whether or not the bucket name is set.
        /// </summary>
        /// <returns>
        /// 	A value of <c>true</c> if the bucket name is set.
        ///    Otherwise, returns <c>false</c>.
        /// </returns>
        internal bool IsSetBucketName()
        {
            return !System.String.IsNullOrEmpty(this.bucketName);
        }


        /// <summary>
        /// 	Gets or sets the local directory where objects from Amazon S3 will be downloaded.  
		/// 	If the directory doesn't exist, it will be created.
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
        /// Gets and sets the Amazon S3 directory to download from.  
				/// This is translated to a key prefix; keys that have this prefix will be
        /// downloaded.
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
        /// 	Gets or sets the <c>ModifiedSinceDate</c> property.  
				/// 	Only objects that have been modified since this date will be
        /// 	downloaded.
        /// </summary>
        /// <value>
        /// 	The <c>ModifiedSinceDate</c> property. 
        /// </value>
        public DateTime ModifiedSinceDate
        {
            get { return this.modifiedSinceDate.GetValueOrDefault(); }
            set { this.modifiedSinceDate = value; }
        }

        /// <summary>
        /// Checks if ModifiedSinceDate property is set.
        /// </summary>
        /// <returns>A value of <c>true</c> if ModifiedSinceDate property is set.
        /// 	Otherwise, returns <c>false</c>.</returns>
        internal bool IsSetModifiedSinceDate()
        {
            return modifiedSinceDate.HasValue;
        }


        /// <summary>
        /// 	Gets or sets the <c>UnmodifiedSinceDate</c> property.  
				/// 	Only objects that have not been modified since this date will be downloaded.
        /// </summary>
        /// <value>
        /// 	The <c>UnmodifiedSinceDate</c> property.
        /// </value>
        public DateTime UnmodifiedSinceDate
        {
            get { return this.unmodifiedSinceDate.GetValueOrDefault(); }
            set { this.unmodifiedSinceDate = value; }
        }

        /// <summary>
        /// Checks if UnmodifiedSinceDate property is set.
        /// </summary>
        /// <returns>true if UnmodifiedSinceDate property is set.</returns>
        internal bool IsSetUnmodifiedSinceDate()
        {
            return unmodifiedSinceDate.HasValue;
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


        internal void OnRaiseProgressEvent(int numberOfFilesUploaded, int totalNumberOfFiles,
            string currentFile, long transferredBytesForCurrentFile, long totalNumberOfBytesForCurrentFile)
        {
            AWSSDKUtils.InvokeInBackground(DownloadedDirectoryProgressEvent, new DownloadDirectoryProgressArgs(numberOfFilesUploaded, totalNumberOfFiles, currentFile,
                        transferredBytesForCurrentFile, totalNumberOfBytesForCurrentFile), this);
        }
    }

    /// <summary>
    /// Encapsulates the information needed to provide
    /// transfer progress to subscribers of the <c>DownloadDirectory</c>
    /// event.
    /// </summary>
    public class DownloadDirectoryProgressArgs : EventArgs
    {
        int _totalNumberOfFiles;
        int _numberOfFilesDownloaded;
        string _currentFile;
        long _transferredBytesForCurrentFile;
        long _totalNumberOfBytesForCurrentFile;

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
            this._numberOfFilesDownloaded = numberOfFilesDownloaded;
            this._totalNumberOfFiles = totalNumberOfFiles;
            this._currentFile = currentFile;
            this._transferredBytesForCurrentFile = transferredBytesForCurrentFile;
            this._totalNumberOfBytesForCurrentFile = totalNumberOfBytesForCurrentFile;
        }

        /// <summary>
        /// Gets or sets the total number of files.
        /// </summary>
        /// <value>The total number of files.</value>
        public int TotalNumberOfFiles
        {
            get { return this._totalNumberOfFiles; }
            set { this._totalNumberOfFiles = value; }
        }

        /// <summary>
        /// Gets or sets the number of files downloaded so far.
        /// </summary>
        /// <value>The number of files downloaded.</value>
        public int NumberOfFilesDownloaded
        {
            get { return this._numberOfFilesDownloaded; }
            set { this._numberOfFilesDownloaded = value; }
        }

        /// <summary>
        /// Gets or sets the current file being downloaded.
        /// </summary>
        /// <value>The current file being downloaded.</value>
        public string CurrentFile
        {
            get { return this._currentFile; }
            set { this._currentFile = value; }
        }

        /// <summary>
        /// Gets or sets the transferred bytes for the current file.
        /// </summary>
        /// <value>The transferred bytes for the current file.</value>
        public long TransferredBytesForCurrentFile
        {
            get { return this._transferredBytesForCurrentFile; }
            set { this._transferredBytesForCurrentFile = value; }
        }

        /// <summary>
        /// Gets or sets the total number of bytes for the current file.
        /// </summary>
        /// <value>The total number of bytes for the current file.</value>
        public long TotalNumberOfBytesForCurrentFile
        {
            get { return this._totalNumberOfBytesForCurrentFile; }
            set { this._totalNumberOfBytesForCurrentFile = value; }
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "Total Files: {0}, Downloaded Files {1}, Total Bytes: {2}, Transferred Bytes: {3}", this.TotalNumberOfFiles, this.NumberOfFilesDownloaded, this.TotalNumberOfBytesForCurrentFile, this.TransferredBytesForCurrentFile);
        }
    }
}
