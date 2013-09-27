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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para>A specification of a location in Amazon S3.</para>
    /// </summary>
    public class S3Location  
    {
        
        private string s3Bucket;
        private string s3Key;

        /// <summary>
        /// The Amazon S3 bucket where the data is located.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string S3Bucket
        {
            get { return this.s3Bucket; }
            set { this.s3Bucket = value; }
        }

        /// <summary>
        /// Sets the S3Bucket property
        /// </summary>
        /// <param name="s3Bucket">The value to set for the S3Bucket property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public S3Location WithS3Bucket(string s3Bucket)
        {
            this.s3Bucket = s3Bucket;
            return this;
        }
            

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this.s3Bucket != null;       
        }

        /// <summary>
        /// The Amazon S3 key where the data is located.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string S3Key
        {
            get { return this.s3Key; }
            set { this.s3Key = value; }
        }

        /// <summary>
        /// Sets the S3Key property
        /// </summary>
        /// <param name="s3Key">The value to set for the S3Key property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public S3Location WithS3Key(string s3Key)
        {
            this.s3Key = s3Key;
            return this;
        }
            

        // Check to see if S3Key property is set
        internal bool IsSetS3Key()
        {
            return this.s3Key != null;       
        }
    }
}
