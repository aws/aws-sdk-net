/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the PutLifecycleConfiguration operation.
    /// Enables lifecycle management by creating a new <code>LifecycleConfiguration</code>
    /// object. A <code>LifecycleConfiguration</code> object defines when files in an Amazon
    /// EFS file system are automatically transitioned to the lower-cost EFS Infrequent Access
    /// (IA) storage class. A <code>LifecycleConfiguration</code> applies to all files in
    /// a file system.
    /// 
    ///  
    /// <para>
    /// Each Amazon EFS file system supports one lifecycle configuration, which applies to
    /// all files in the file system. If a <code>LifecycleConfiguration</code> object already
    /// exists for the specified file system, a <code>PutLifecycleConfiguration</code> call
    /// modifies the existing configuration. A <code>PutLifecycleConfiguration</code> call
    /// with an empty <code>LifecyclePolicies</code> array in the request body deletes any
    /// existing <code>LifecycleConfiguration</code> and disables lifecycle management.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can enable lifecycle management only for EFS file systems created after the release
    /// of EFS infrequent access.
    /// </para>
    ///  </note> 
    /// <para>
    /// In the request, specify the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The ID for the file system for which you are creating a lifecycle management configuration.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <code>LifecyclePolicies</code> array of <code>LifecyclePolicy</code> objects that
    /// define when files are moved to the IA storage class. The array can contain only one
    /// <code>"TransitionToIA": "AFTER_30_DAYS"</code> <code>LifecyclePolicy</code> item.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation requires permissions for the <code>elasticfilesystem:PutLifecycleConfiguration</code>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// To apply a <code>LifecycleConfiguration</code> object to an encrypted file system,
    /// you need the same AWS Key Management Service (AWS KMS) permissions as when you created
    /// the encrypted file system. 
    /// </para>
    /// </summary>
    public partial class PutLifecycleConfigurationRequest : AmazonElasticFileSystemRequest
    {
        private string _fileSystemId;
        private List<LifecyclePolicy> _lifecyclePolicies = new List<LifecyclePolicy>();

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the file system for which you are creating the <code>LifecycleConfiguration</code>
        /// object (String).
        /// </para>
        /// </summary>
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property LifecyclePolicies. 
        /// <para>
        /// An array of <code>LifecyclePolicy</code> objects that define the file system's <code>LifecycleConfiguration</code>
        /// object. A <code>LifecycleConfiguration</code> object tells lifecycle management when
        /// to transition files from the Standard storage class to the Infrequent Access storage
        /// class.
        /// </para>
        /// </summary>
        public List<LifecyclePolicy> LifecyclePolicies
        {
            get { return this._lifecyclePolicies; }
            set { this._lifecyclePolicies = value; }
        }

        // Check to see if LifecyclePolicies property is set
        internal bool IsSetLifecyclePolicies()
        {
            return this._lifecyclePolicies != null && this._lifecyclePolicies.Count > 0; 
        }

    }
}