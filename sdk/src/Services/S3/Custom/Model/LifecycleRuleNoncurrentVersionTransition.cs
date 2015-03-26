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

namespace Amazon.S3.Model
{
    /// <summary>
    /// LifecycleTransition defines when and how objects transition.
    /// </summary>
    public class LifecycleRuleNoncurrentVersionTransition
    {
        private int? noncurrentDays;
        private S3StorageClass storageClass;

        /// <summary>
        /// Indicates the lifetime, in days, of the objects that are subject to the rule. The value must be a non-zero positive integer.
        ///  
        /// </summary>
        public int NoncurrentDays
        {
            get { return this.noncurrentDays ?? default(int); }
            set { this.noncurrentDays = value; }
        }

        // Check to see if Days property is set
        internal bool IsSetNoncurrentDays()
        {
            return this.noncurrentDays.HasValue;
        }

        /// <summary>
        /// The class of storage used to store the object.
        ///  
        /// </summary>
        public S3StorageClass StorageClass
        {
            get { return this.storageClass; }
            set { this.storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this.storageClass != null;
        }
    }
}
