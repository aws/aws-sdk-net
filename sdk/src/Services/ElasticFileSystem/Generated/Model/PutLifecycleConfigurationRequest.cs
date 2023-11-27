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

/*
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the PutLifecycleConfiguration operation.
    /// Use this action to manage storage for your file system. A <code>LifecycleConfiguration</code>
    /// consists of one or more <code>LifecyclePolicy</code> objects that define the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <b> <code>TransitionToIA</code> </b> – When to move files in the file system from
    /// primary storage (Standard storage class) into the Infrequent Access (IA) storage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b> <code>TransitionToArchive</code> </b> – When to move files in the file system
    /// from their current storage class (either IA or Standard storage) into the Archive
    /// storage.
    /// </para>
    ///  
    /// <para>
    /// File systems cannot transition into Archive storage before transitioning into IA storage.
    /// Therefore, TransitionToArchive must either not be set or must be later than TransitionToIA.
    /// </para>
    ///  <note> 
    /// <para>
    ///  The Archive storage class is available only for file systems that use the Elastic
    /// Throughput mode and the General Purpose Performance mode. 
    /// </para>
    ///  </note> </li> </ul> <ul> <li> 
    /// <para>
    ///  <b> <code>TransitionToPrimaryStorageClass</code> </b> – Whether to move files in
    /// the file system back to primary storage (Standard storage class) after they are accessed
    /// in IA or Archive storage.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/lifecycle-management-efs.html">
    /// Managing file system storage</a>.
    /// </para>
    ///  
    /// <para>
    /// Each Amazon EFS file system supports one lifecycle configuration, which applies to
    /// all files in the file system. If a <code>LifecycleConfiguration</code> object already
    /// exists for the specified file system, a <code>PutLifecycleConfiguration</code> call
    /// modifies the existing configuration. A <code>PutLifecycleConfiguration</code> call
    /// with an empty <code>LifecyclePolicies</code> array in the request body deletes any
    /// existing <code>LifecycleConfiguration</code>. In the request, specify the following:
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The ID for the file system for which you are enabling, disabling, or modifying Lifecycle
    /// management.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <code>LifecyclePolicies</code> array of <code>LifecyclePolicy</code> objects that
    /// define when to move files to IA storage, to Archive storage, and back to primary storage.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon EFS requires that each <code>LifecyclePolicy</code> object have only have a
    /// single transition, so the <code>LifecyclePolicies</code> array needs to be structured
    /// with separate <code>LifecyclePolicy</code> objects. See the example requests in the
    /// following section for more information.
    /// </para>
    ///  </note> </li> </ul> 
    /// <para>
    /// This operation requires permissions for the <code>elasticfilesystem:PutLifecycleConfiguration</code>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// To apply a <code>LifecycleConfiguration</code> object to an encrypted file system,
    /// you need the same Key Management Service permissions as when you created the encrypted
    /// file system.
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
        [AWSProperty(Required=true, Max=128)]
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
        /// object. A <code>LifecycleConfiguration</code> object informs EFS Lifecycle management
        /// of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>TransitionToIA</code> </b> – When to move files in the file system from
        /// primary storage (Standard storage class) into the Infrequent Access (IA) storage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>TransitionToArchive</code> </b> – When to move files in the file system
        /// from their current storage class (either IA or Standard storage) into the Archive
        /// storage.
        /// </para>
        ///  
        /// <para>
        /// File systems cannot transition into Archive storage before transitioning into IA storage.
        /// Therefore, TransitionToArchive must either not be set or must be later than TransitionToIA.
        /// </para>
        ///  <note> 
        /// <para>
        ///  The Archive storage class is available only for file systems that use the Elastic
        /// Throughput mode and the General Purpose Performance mode. 
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <b> <code>TransitionToPrimaryStorageClass</code> </b> – Whether to move files in
        /// the file system back to primary storage (Standard storage class) after they are accessed
        /// in IA or Archive storage.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// When using the <code>put-lifecycle-configuration</code> CLI command or the <code>PutLifecycleConfiguration</code>
        /// API action, Amazon EFS requires that each <code>LifecyclePolicy</code> object have
        /// only a single transition. This means that in a request body, <code>LifecyclePolicies</code>
        /// must be structured as an array of <code>LifecyclePolicy</code> objects, one object
        /// for each storage transition. See the example requests in the following section for
        /// more information.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Max=3)]
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