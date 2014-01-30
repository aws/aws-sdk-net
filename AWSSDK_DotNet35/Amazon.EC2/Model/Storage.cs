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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes the storage location for an instance store-backed AMI.</para>
    /// </summary>
    public class Storage
    {
        
        private S3Storage s3;


        /// <summary>
        /// An Amazon S3 storage location.
        ///  
        /// </summary>
        public S3Storage S3
        {
            get { return this.s3; }
            set { this.s3 = value; }
        }

        // Check to see if S3 property is set
        internal bool IsSetS3()
        {
            return this.s3 != null;
        }
    }
}
