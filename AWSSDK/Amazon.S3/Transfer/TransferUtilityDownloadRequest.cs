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
using System.Collections.Generic;
using System.Text;

using Amazon.S3.Model;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// Contains all the parameters
    /// that can be set when making a this request with the 
    /// <c>TransferUtility</c> method.
    /// </summary>
    public class TransferUtilityDownloadRequest : BaseDownloadRequest
    {

        string _filePath;

        /// <summary>
        /// 	Sets the bucket name containing the Amazon S3 object to download and returns
        /// 	this object instance, enabling additional method calls to
        /// 	be chained together.
        /// </summary>
        /// <param name="bucketName">
        /// 	The name of the bucket containing the Amazon S3 object to download.
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityDownloadRequest WithBucketName(string bucketName)
        {
            this.BucketName = bucketName;
            return this;
        }


        /// <summary>
        /// 	Sets the key under which the Amazon S3 object is stored and returns
        /// 	this object instance, enabling additional method calls to be chained together.
        /// </summary>
        /// <param name="key">
        /// 	The key under which the Amazon S3 object is stored.
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityDownloadRequest WithKey(string key)
        {
            this.Key = key;
            return this;
        }

        /// <summary>
        /// 	Sets the version ID of the Amazon S3 object to download
        ///  	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// </summary>
        /// <param name="versionId">
        /// 	The version ID of the Amazon S3 object to download.
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityDownloadRequest WithVersionId(string versionId)
        {
            this.VersionId = versionId;
            return this;
        }

        /// <summary>
        /// 	<para>
        /// 	Sets the <c>ModifiedSinceDate</c> property for this request
        ///  	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// 	</para>
        /// 	<para>
        /// 	When this property is set, the Amazon S3 object is returned only if it
        /// 	has been modified since the specified time. Otherwise,
        /// 	this requests returns a 304 error code.
        /// 	</para>
        /// </summary>
        /// <param name="modifiedSinceDate">
        /// 	The <c>ModifiedSinceDate</c> value.
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityDownloadRequest WithModifiedSinceDate(DateTime modifiedSinceDate)
        {
            this.ModifiedSinceDate = modifiedSinceDate;
            return this;
        }

        /// <summary>
        /// 	<para>
        /// 	Sets the <c>UnmodifiedSinceDate</c> property for this request
        ///  	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// 	</para>
        /// 	<para>
        /// 	When this property is set, the Amazon S3 object is returned only if it
        /// 	has not been modified since the specified time. Otherwise,
        /// 	this requests returns a 412 error code.
        /// 	</para>
        /// </summary>
        /// <param name="unmodifiedSinceDate">
        /// 	The <c>UnmodifiedSinceDate</c> value.
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityDownloadRequest WithUnmodifiedSinceDate(DateTime unmodifiedSinceDate)
        {
            this.UnmodifiedSinceDate = unmodifiedSinceDate;
            return this;
        }

        /// <summary>
        /// 	Sets the timeout property in milliseconds. 
        /// 	The value of this property is assigned to the
        /// 	<c>ReadWriteTimeout</c> and <c>Timeout</c> properties of the
        /// 	<c>HTTPWebRequest</c> object used for Amazon S3 GET Object requests.
        /// 	Specify a timeout value only if certain that
        /// 	the file will not be retrieved within the default intervals
        /// 	specified for the <c>HttpWebRequest</c>.
        /// </summary>
        /// <param name="timeout">
        /// 	The timeout property in milliseconds.
        /// </param>
        /// <remarks>
        /// 	A value less than or equal to 0 will be silently ignored.
        /// </remarks>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityDownloadRequest WithTimeout(int timeout)
        {
            this.Timeout = timeout;
            return this;
        }


        /// <summary>
        /// 	Get or sets the file path location of where the
        /// 	downloaded Amazon S3 object will be written to.
        /// </summary>
        /// <value>
        /// 	The file path location of where the downloaded Amazon S3 object will be written to.
        /// </value>
        public string FilePath
        {
            get { return this._filePath; }
            set { this._filePath = value; }
        }

        /// <summary>
        /// Checks if FilePath property is set.
        /// </summary>
        /// <returns>true if FilePath property is set.</returns>
        internal bool IsSetFilePath()
        {
            return !System.String.IsNullOrEmpty(this._filePath);
        }

        /// <summary>
        /// 	Sets the file path location of where the
        /// 	downloaded Amazon S3 object will be written to
        /// 	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// </summary>
        /// <param name="filePath">
        /// 	The file path location of where the
        /// 	downloaded Amazon S3 object will be written to.
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityDownloadRequest WithFilePath(string filePath)
        {
            this._filePath = filePath;
            return this;
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
        /// The handler will be attached to the WriteObjectProgressEvent which is fired as data
        /// is downloaded from S3.  The handler will be passed information detailing how much data
        /// has been downloaded as well as how much will be downloaded.
        /// </summary>
        /// <param name="handler">A method that is called when WriteObjectProgressEvent is fired.</param>
        /// <returns>this instance of the TransferUtilityDownloadRequest</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityDownloadRequest WithSubscriber(EventHandler<WriteObjectProgressArgs> handler)
        {
            this.WriteObjectProgressEvent += handler;
            return this;
        }

        internal EventHandler<WriteObjectProgressArgs> EventHandler
        {
            get
            {
                return this.WriteObjectProgressEvent;
            }
        }
    }
}
