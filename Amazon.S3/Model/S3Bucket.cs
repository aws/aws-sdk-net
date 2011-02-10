/*******************************************************************************
 *  Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Globalization;
using System.Xml.Serialization;

using Amazon.Util;
using Amazon.S3.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Represents an S3 Bucket. 
    /// Contains a Bucket Name which is the name of the S3 Bucket. 
    /// And a Creation Date which is the date that the S3 Bucket was created.
    /// </summary>
    [Serializable()]
    public class S3Bucket
    {
        #region Private Members

        private string bucketName;
        private DateTime? creationDate;

        #endregion

        #region BucketName

        /// <summary>
        /// Gets and sets the BucketName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Checks if BucketName property is set
        /// </summary>
        /// <returns>true if BucketName property is set</returns>
        internal bool IsSetBucketName()
        {
            return !System.String.IsNullOrEmpty(this.bucketName);
        }

        #endregion

        #region CreationDate

        /// <summary>
        /// Gets and sets the CreationDate property.
        /// The date conforms to the ISO8601 date format.
        /// </summary>
        [XmlElementAttribute(ElementName = "CreationDate")]
        public string CreationDate
        {
            get
            {
                return this.creationDate.GetValueOrDefault().ToString(
                    AWSSDKUtils.GMTDateFormat
                    );
            }
            set
            {
                this.creationDate = DateTime.ParseExact(
                    value,
                    AWSSDKUtils.ISO8601DateFormat,
                    CultureInfo.InvariantCulture
                    );
            }
        }

        /// <summary>
        /// Checks if CreationDate property is set
        /// </summary>
        /// <returns>true if CreationDate property is set</returns>
        internal bool IsSetCreationDate()
        {
            return this.creationDate.HasValue;
        }

        #endregion
    }
}