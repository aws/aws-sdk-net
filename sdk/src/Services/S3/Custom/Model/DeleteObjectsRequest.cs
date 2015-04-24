/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteObjects operation.
    /// <para>This operation enables you to delete multiple objects from a bucket using a single HTTP request. You may specify up to 1000
    /// keys.</para>
    /// </summary>
    public partial class DeleteObjectsRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private List<KeyVersion> objects = new List<KeyVersion>();
        private bool? quiet;
        private MfaCodes mfaCodes;

        /// <summary>
        /// The name of the bucket containing the objects to be deleted.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// List of object keys to delete.
        /// </summary>
        public List<KeyVersion> Objects
        {
            get 
            {
                if (this.objects == null)
                    this.objects = new List<KeyVersion>();

                return this.objects; 
            }
            set { this.objects = value; }
        }

        // Check to see if Objects property is set
        internal bool IsSetObjects()
        {
            return this.objects.Count > 0;
        }

        /// <summary>
        /// Toggles between Quiet and Verbose mode for the operation.
        /// If set to true (Quiet mode), the response includes only those keys for objects on which
        /// the delete operation failed.
        /// </summary>
        /// <remarks>
        /// By default this property is false and keys for both successful deletes
        /// and failures are returned in the response.
        /// </remarks>
        public bool Quiet
        {
            get { return this.quiet ?? default(bool); }
            set { this.quiet = value; }
        }

        // Check to see if Quiet property is set
        internal bool IsSetQuiet()
        {
            return this.quiet.HasValue;
        }

        /// <summary>
        /// The MfaCodes Tuple associates the Serial Number and the current Token/Code displayed on the
        /// Multi-Factor Authentication device associated with your AWS Account. 
        /// </summary>
        /// <remarks>
        /// This is a required property for this request if:<br />
        /// 1. EnableMfaDelete was configured on the bucket
        /// containing this object's version.<br />
        /// 2. You are deleting an object's version
        /// </remarks>
        [XmlIgnore]
        public MfaCodes MfaCodes
        {
            get { return this.mfaCodes; }
            set { this.mfaCodes = value; }
        }

        /// <summary>
        /// Checks if the MfaCodes property is set.
        /// </summary>
        /// <returns>true if the MfaCodes property is set.</returns>
        internal bool IsSetMfaCodes()
        {
            return (this.mfaCodes != null) &&
                (!System.String.IsNullOrEmpty(MfaCodes.SerialNumber)) &&
                (!System.String.IsNullOrEmpty(MfaCodes.AuthenticationValue));
        }

    }
}
    
