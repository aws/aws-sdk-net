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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PipelineOutputConfig
    {
        
        private string bucket;
        private string storageClass;
        private List<Permission> permissions = new List<Permission>();

        /// <summary>
        /// 
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^(\w|\.|-){1,255}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Bucket
        {
            get { return this.bucket; }
            set { this.bucket = value; }
        }

        /// <summary>
        /// Sets the Bucket property
        /// </summary>
        /// <param name="bucket">The value to set for the Bucket property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PipelineOutputConfig WithBucket(string bucket)
        {
            this.bucket = bucket;
            return this;
        }
            

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this.bucket != null;
        }

        /// <summary>
        /// 
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^ReducedRedundancy$)|(^Standard$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StorageClass
        {
            get { return this.storageClass; }
            set { this.storageClass = value; }
        }

        /// <summary>
        /// Sets the StorageClass property
        /// </summary>
        /// <param name="storageClass">The value to set for the StorageClass property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PipelineOutputConfig WithStorageClass(string storageClass)
        {
            this.storageClass = storageClass;
            return this;
        }
            

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this.storageClass != null;
        }

        /// <summary>
        /// 
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 30</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<Permission> Permissions
        {
            get { return this.permissions; }
            set { this.permissions = value; }
        }
        /// <summary>
        /// Adds elements to the Permissions collection
        /// </summary>
        /// <param name="permissions">The values to add to the Permissions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PipelineOutputConfig WithPermissions(params Permission[] permissions)
        {
            foreach (Permission element in permissions)
            {
                this.permissions.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Permissions collection
        /// </summary>
        /// <param name="permissions">The values to add to the Permissions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PipelineOutputConfig WithPermissions(IEnumerable<Permission> permissions)
        {
            foreach (Permission element in permissions)
            {
                this.permissions.Add(element);
            }

            return this;
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this.permissions.Count > 0;
        }
    }
}
