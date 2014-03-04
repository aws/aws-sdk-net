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

using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to request deletion of the lifecycle configuration on a bucket. 
    /// </summary>
    /// <remarks>
    /// <para>
    /// Amazon S3 removes all the lifecycle configuration rules in the lifecycle subresource associated with the bucket. 
    /// Your objects never expire, and Amazon S3 no longer automatically deletes any objects on the basis of rules contained 
    /// in the deleted lifecycle configuration.
    /// </para>
    /// <para>
    /// To use this operation, you must have permission to perform the s3:PutLifecycleConfiguration action. By default, the 
    /// bucket owner has this permission and the bucket owner can grant this permission to others.
    /// </para>
    /// <para>
    /// There is usually some time lag before lifecycle configuration deletion is fully propagated to all the Amazon S3 systems.
    /// </para>
    /// </remarks>
    public class DeleteLifecycleConfigurationRequest : S3Request
    {
        #region Private Members

        private string bucketName;

        #endregion

        #region BucketName

        /// <summary>
        /// The name of the bucket on which the lifecycle configuration is to be deleted.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket on which the lifecycle configuration is to be deleted.
        /// </summary>
        /// <param name="bucketName">The bucket name</param>
        /// <returns>the request with the BucketName set</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteLifecycleConfigurationRequest WithBucketName(string bucketName)
        {
            this.bucketName = bucketName;
            return this;
        }

        /// <summary>
        /// Checks if BucketName property is set.
        /// </summary>
        /// <returns>true if BucketName property is set.</returns>
        internal bool IsSetBucketName()
        {
            return !System.String.IsNullOrEmpty(this.bucketName);
        }
        #endregion
    }
}
