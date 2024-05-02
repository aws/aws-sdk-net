/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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


namespace Amazon.S3.Model
{
    /// <summary>
    /// Class for InventoryDestination 
    /// </summary>
    public class InventoryDestination
    {
        private InventoryS3BucketDestination inventoryS3BucketDestination;

        /// <summary>
        /// Contains the bucket name, file format, bucket owner (optional), and prefix (optional) where inventory results are published.
        /// </summary>
        public InventoryS3BucketDestination S3BucketDestination
        {
            get { return this.inventoryS3BucketDestination; }
            set { this.inventoryS3BucketDestination = value; }
        }

        /// <summary>
        /// Check to see if S3BucketDestination property is set
        /// </summary>
        /// <returns></returns>
        public bool isSetS3BucketDestination()
        {
            return this.inventoryS3BucketDestination != null;
        }
    }
}
