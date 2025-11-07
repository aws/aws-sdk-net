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
using System.Collections.Generic;
using System.Text;

using Amazon.S3.Model;
using Amazon.Util;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// Contains all the parameters
    /// that can be set when making a this request with the 
    /// <c>TransferUtility</c> method.
    /// </summary>
    public partial class TransferUtilityDownloadRequest : BaseDownloadRequest
    {
        /// <summary>
        /// 	Get or sets the file path location of where the
        /// 	downloaded Amazon S3 object will be written to.
        /// </summary>
        /// <value>
        /// 	The file path location of where the downloaded Amazon S3 object will be written to.
        /// </value>
        public string FilePath { get; set; }

        /// <summary>
        /// Checks if FilePath property is set.
        /// </summary>
        /// <returns>True if FilePath property is set.</returns>
        internal bool IsSetFilePath()
        {
            return !System.String.IsNullOrEmpty(this.FilePath);
        }

        /// <summary>
        /// The event for WriteObjectProgressEvent notifications. All
        /// subscribers will be notified when a new progress
        /// event is raised.
        /// <para>
        /// The WriteObjectProgressEvent is fired as data
        /// is downloaded from S3.  The delegates attached to the event 
        /// will be passed information detailing how much data
        /// has been downloaded as well as how much will be downloaded.
        /// </para>
        /// </summary>
        /// <remarks>
        /// Subscribe to this event if you want to receive
        /// WriteObjectProgressEvent notifications. Here is how:<br />
        /// 1. Define a method with a signature similar to this one:
        /// <code>
        /// private void displayProgress(object sender, WriteObjectProgressArgs args)
        /// {
        ///     Console.WriteLine(args);
        /// }
        /// </code>
        /// 2. Add this method to the WriteObjectProgressEvent delegate's invocation list
        /// <code>
        /// TransferUtilityDownloadRequest request = new TransferUtilityDownloadRequest();
        /// request.WriteObjectProgressEvent += displayProgress;
        /// </code>
        /// </remarks>
        public event EventHandler<WriteObjectProgressArgs> WriteObjectProgressEvent;

        /// <summary>
        /// Causes the WriteObjectProgressEvent event to be fired.
        /// </summary>
        /// <param name="progressArgs">Progress data for the stream being written to file.</param>        
        internal void OnRaiseProgressEvent(WriteObjectProgressArgs progressArgs)
        {
            AWSSDKUtils.InvokeInBackground(WriteObjectProgressEvent, progressArgs, this);
        }

        /// <summary>
        /// The event for DownloadInitiatedEvent notifications. All
        /// subscribers will be notified when a download transfer operation
        /// starts.
        /// <para>
        /// The DownloadInitiatedEvent is fired exactly once when 
        /// a download transfer operation begins. The delegates attached to the event 
        /// will be passed information about the download request and 
        /// file path, but no progress information.
        /// </para>
        /// </summary>
        /// <remarks>
        /// Subscribe to this event if you want to receive
        /// DownloadInitiatedEvent notifications. Here is how:<br />
        /// 1. Define a method with a signature similar to this one:
        /// <code>
        /// private void downloadStarted(object sender, DownloadInitiatedEventArgs args)
        /// {
        ///     Console.WriteLine($"Download started: {args.FilePath}");
        ///     Console.WriteLine($"Bucket: {args.Request.BucketName}");
        ///     Console.WriteLine($"Key: {args.Request.Key}");
        /// }
        /// </code>
        /// 2. Add this method to the DownloadInitiatedEvent delegate's invocation list
        /// <code>
        /// TransferUtilityDownloadRequest request = new TransferUtilityDownloadRequest();
        /// request.DownloadInitiatedEvent += downloadStarted;
        /// </code>
        /// </remarks>
        public event EventHandler<DownloadInitiatedEventArgs> DownloadInitiatedEvent;

        /// <summary>
        /// The event for DownloadCompletedEvent notifications. All
        /// subscribers will be notified when a download transfer operation
        /// completes successfully.
        /// <para>
        /// The DownloadCompletedEvent is fired exactly once when 
        /// a download transfer operation completes successfully. The delegates attached to the event 
        /// will be passed information about the completed download including
        /// the final response from S3 with ETag, VersionId, and other metadata.
        /// </para>
        /// </summary>
        /// <remarks>
        /// Subscribe to this event if you want to receive
        /// DownloadCompletedEvent notifications. Here is how:<br />
        /// 1. Define a method with a signature similar to this one:
        /// <code>
        /// private void downloadCompleted(object sender, DownloadCompletedEventArgs args)
        /// {
        ///     Console.WriteLine($"Download completed: {args.FilePath}");
        ///     Console.WriteLine($"Transferred: {args.TransferredBytes} bytes");
        ///     Console.WriteLine($"ETag: {args.Response.ETag}");
        ///     Console.WriteLine($"S3 Key: {args.Response.Key}");
        ///     Console.WriteLine($"Version ID: {args.Response.VersionId}");
        /// }
        /// </code>
        /// 2. Add this method to the DownloadCompletedEvent delegate's invocation list
        /// <code>
        /// TransferUtilityDownloadRequest request = new TransferUtilityDownloadRequest();
        /// request.DownloadCompletedEvent += downloadCompleted;
        /// </code>
        /// </remarks>
        public event EventHandler<DownloadCompletedEventArgs> DownloadCompletedEvent;

        /// <summary>
        /// The event for DownloadFailedEvent notifications. All
        /// subscribers will be notified when a download transfer operation
        /// fails.
        /// <para>
        /// The DownloadFailedEvent is fired exactly once when 
        /// a download transfer operation fails. The delegates attached to the event 
        /// will be passed information about the failed download including
        /// partial progress information, but no response data since the download failed.
        /// </para>
        /// </summary>
        /// <remarks>
        /// Subscribe to this event if you want to receive
        /// DownloadFailedEvent notifications. Here is how:<br />
        /// 1. Define a method with a signature similar to this one:
        /// <code>
        /// private void downloadFailed(object sender, DownloadFailedEventArgs args)
        /// {
        ///     Console.WriteLine($"Download failed: {args.FilePath}");
        ///     Console.WriteLine($"Partial progress: {args.TransferredBytes} bytes");
        ///     Console.WriteLine($"Bucket: {args.Request.BucketName}");
        ///     Console.WriteLine($"Key: {args.Request.Key}");
        /// }
        /// </code>
        /// 2. Add this method to the DownloadFailedEvent delegate's invocation list
        /// <code>
        /// TransferUtilityDownloadRequest request = new TransferUtilityDownloadRequest();
        /// request.DownloadFailedEvent += downloadFailed;
        /// </code>
        /// </remarks>
        public event EventHandler<DownloadFailedEventArgs> DownloadFailedEvent;

        /// <summary>
        /// Causes the DownloadInitiatedEvent event to be fired.
        /// </summary>
        /// <param name="args">DownloadInitiatedEventArgs args</param>
        internal void OnRaiseTransferInitiatedEvent(DownloadInitiatedEventArgs args)
        {
            AWSSDKUtils.InvokeInBackground(DownloadInitiatedEvent, args, this);
        }

        /// <summary>
        /// Causes the DownloadCompletedEvent event to be fired.
        /// </summary>
        /// <param name="args">DownloadCompletedEventArgs args</param>
        internal void OnRaiseTransferCompletedEvent(DownloadCompletedEventArgs args)
        {
            AWSSDKUtils.InvokeInBackground(DownloadCompletedEvent, args, this);
        }

        /// <summary>
        /// Causes the DownloadFailedEvent event to be fired.
        /// </summary>
        /// <param name="args">DownloadFailedEventArgs args</param>
        internal void OnRaiseTransferFailedEvent(DownloadFailedEventArgs args)
        {
            AWSSDKUtils.InvokeInBackground(DownloadFailedEvent, args, this);
        }
    }

    /// <summary>
    /// Encapsulates the information needed when a download transfer operation is initiated.
    /// Provides access to the original request without progress or total byte information.
    /// </summary>
    public class DownloadInitiatedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the DownloadInitiatedEventArgs class.
        /// </summary>
        /// <param name="request">The original TransferUtilityDownloadRequest created by the user</param>
        /// <param name="filePath">The file being downloaded</param>
        internal DownloadInitiatedEventArgs(TransferUtilityDownloadRequest request, string filePath)
        {
            Request = request;
            FilePath = filePath;
        }

        /// <summary>
        /// The original TransferUtilityDownloadRequest created by the user.
        /// Contains all the download parameters and configuration.
        /// </summary>
        public TransferUtilityDownloadRequest Request { get; private set; }

        /// <summary>
        /// Gets the file being downloaded.
        /// </summary>
        public string FilePath { get; private set; }
    }

    /// <summary>
    /// Encapsulates the information needed when a download transfer operation completes successfully.
    /// Provides access to the original request, final response, and completion details.
    /// </summary>
    public class DownloadCompletedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the DownloadCompletedEventArgs class.
        /// </summary>
        /// <param name="request">The original TransferUtilityDownloadRequest created by the user</param>
        /// <param name="response">The unified response from Transfer Utility</param>
        /// <param name="filePath">The file being downloaded</param>
        /// <param name="transferredBytes">The total number of bytes transferred</param>
        /// <param name="totalBytes">The total number of bytes for the complete file</param>
        internal DownloadCompletedEventArgs(TransferUtilityDownloadRequest request, TransferUtilityDownloadResponse response, string filePath, long transferredBytes, long totalBytes)
        {
            Request = request;
            Response = response; 
            FilePath = filePath;
            TransferredBytes = transferredBytes;
            TotalBytes = totalBytes;
        }

        /// <summary>
        /// The original TransferUtilityDownloadRequest created by the user.
        /// Contains all the download parameters and configuration.
        /// </summary>
        public TransferUtilityDownloadRequest Request { get; private set; }

        /// <summary>
        /// The unified response from Transfer Utility after successful download completion.
        /// Contains mapped fields from GetObjectResponse.
        /// </summary>
        public TransferUtilityDownloadResponse Response { get; private set; }

        /// <summary>
        /// Gets the file being downloaded.
        /// </summary>
        public string FilePath { get; private set; }

        /// <summary>
        /// Gets the total number of bytes that were successfully transferred.
        /// </summary>
        public long TransferredBytes { get; private set; }

        /// <summary>
        /// Gets the total number of bytes for the complete file.
        /// </summary>
        public long TotalBytes { get; private set; }
    }

    /// <summary>
    /// Encapsulates the information needed when a download transfer operation fails.
    /// Provides access to the original request and partial progress information.
    /// </summary>
    public class DownloadFailedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the DownloadFailedEventArgs class.
        /// </summary>
        /// <param name="request">The original TransferUtilityDownloadRequest created by the user</param>
        /// <param name="filePath">The file being downloaded</param>
        /// <param name="transferredBytes">The number of bytes transferred before failure</param>
        /// <param name="totalBytes">The total number of bytes for the complete file, or -1 if unknown</param>
        internal DownloadFailedEventArgs(TransferUtilityDownloadRequest request, string filePath, long transferredBytes, long totalBytes)
        {
            Request = request;
            FilePath = filePath;
            TransferredBytes = transferredBytes;
            TotalBytes = totalBytes;
        }

        /// <summary>
        /// The original TransferUtilityDownloadRequest created by the user.
        /// Contains all the download parameters and configuration.
        /// </summary>
        public TransferUtilityDownloadRequest Request { get; private set; }

        /// <summary>
        /// Gets the file being downloaded.
        /// </summary>
        public string FilePath { get; private set; }

        /// <summary>
        /// Gets the number of bytes that were transferred before the failure occurred.
        /// </summary>
        public long TransferredBytes { get; private set; }

        /// <summary>
        /// Gets the total number of bytes for the complete file, or -1 if unknown.
        /// This will be -1 for failures that occur before receiving the GetObjectResponse 
        /// (e.g., authentication errors, non-existent objects), and will contain the actual 
        /// file size for failures that occur after receiving response headers (e.g., disk full).
        /// </summary>
        public long TotalBytes { get; private set; }
    }
}
