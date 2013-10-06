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

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// Contains all the parameters
    /// that can be set when making a this request with the 
    /// <c>TransferUtility</c> method.
    /// </summary>
    public class TransferUtilityOpenStreamRequest : BaseDownloadRequest
    {

        /// <summary>
        ///	Sets the name of the bucket 
        ///   	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// </summary>
        /// <param name="bucketName">
        /// 	The name of the bucket.
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityOpenStreamRequest WithBucketName(string bucketName)
        {
            this.BucketName = bucketName;
            return this;
        }


        /// <summary>
        /// 	Sets the key under which the Amazon S3 object is stored 
        /// 	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// </summary>
        /// <param name="key">The value that Key is set to</param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityOpenStreamRequest WithKey(string key)
        {
            this.Key = key;
            return this;
        }

        /// <summary>
        /// 	Sets the version ID of the Amazon S3 object
        /// 	and returns this object instance, 
        /// 	enabling additional method calls to be chained together. 
        /// </summary>
        /// <param name="versionId">
        /// 	The version ID of the Amazon S3 object.
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityOpenStreamRequest WithVersionId(string versionId)
        {
            this.VersionId = versionId;
            return this;
        }

        /// <summary>
        /// 	Sets the <c>ModifiedSinceDate</c> property for this request
        /// 	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// 	When this is set, the Amazon S3 object is downloaded only if it
        /// 	has been modified since the specified time. 
        /// 	Otherwise, Amazon S3 returns a 304 error code.
        /// </summary>
        /// <param name="modifiedSinceDate">
        /// 	The value to set the <c>ModifiedSinceDate</c> property. 
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityOpenStreamRequest WithModifiedSinceDate(DateTime modifiedSinceDate)
        {
            this.ModifiedSinceDate = modifiedSinceDate;
            return this;
        }

        /// <summary>
        /// 	Sets the <c>UnmodifiedSinceDate</c> property for this request
        /// 	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// 	When this is set, the Amazon S3 object is downloaded only if it
        /// 	has been modified since the specified time. 
        /// 	Otherwise, Amazon S3 returns a 412 error code.
        /// </summary>
        /// <param name="unmodifiedSinceDate">
        /// 	The value to set the <c>UnmodifiedSinceDate</c> property. 
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityOpenStreamRequest WithUnmodifiedSinceDate(DateTime unmodifiedSinceDate)
        {
            this.UnmodifiedSinceDate = unmodifiedSinceDate;
            return this;
        }

        /// <summary>
        /// 	Sets the timeout property in milliseconds
        /// 	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// 	The value of this property is assigned to the
        /// 	<c>ReadWriteTimeout</c> and <c>Timeout</c> properties of the
        /// 	<c>HTTPWebRequest</c> object used for Amazon S3 GET Object requests.
        ///    Set the timeout only if certain that
        /// 	the file will not be transferred within the default intervals
        /// 	for an HttpWebRequest.
        /// </summary>
        /// <param name="timeout">
        /// 	The value of the timeout property in milliseconds.
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
        public TransferUtilityOpenStreamRequest WithTimeout(int timeout)
        {
            this.Timeout = timeout;
            return this;
        }
    }
}
