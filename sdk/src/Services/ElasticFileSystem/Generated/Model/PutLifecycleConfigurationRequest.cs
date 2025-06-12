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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the PutLifecycleConfiguration operation.
    /// Use this action to manage storage for your file system. A <c>LifecycleConfiguration</c>
    /// consists of one or more <c>LifecyclePolicy</c> objects that define the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <b> <c>TransitionToIA</c> </b> – When to move files in the file system from primary
    /// storage (Standard storage class) into the Infrequent Access (IA) storage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b> <c>TransitionToArchive</c> </b> – When to move files in the file system from
    /// their current storage class (either IA or Standard storage) into the Archive storage.
    /// </para>
    ///  
    /// <para>
    /// File systems cannot transition into Archive storage before transitioning into IA storage.
    /// Therefore, TransitionToArchive must either not be set or must be later than TransitionToIA.
    /// </para>
    ///  <note> 
    /// <para>
    ///  The Archive storage class is available only for file systems that use the Elastic
    /// throughput mode and the General Purpose performance mode. 
    /// </para>
    ///  </note> </li> </ul> <ul> <li> 
    /// <para>
    ///  <b> <c>TransitionToPrimaryStorageClass</c> </b> – Whether to move files in the file
    /// system back to primary storage (Standard storage class) after they are accessed in
    /// IA or Archive storage.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/lifecycle-management-efs.html">
    /// Managing file system storage</a>.
    /// </para>
    ///  
    /// <para>
    /// Each Amazon EFS file system supports one lifecycle configuration, which applies to
    /// all files in the file system. If a <c>LifecycleConfiguration</c> object already exists
    /// for the specified file system, a <c>PutLifecycleConfiguration</c> call modifies the
    /// existing configuration. A <c>PutLifecycleConfiguration</c> call with an empty <c>LifecyclePolicies</c>
    /// array in the request body deletes any existing <c>LifecycleConfiguration</c>. In the
    /// request, specify the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The ID for the file system for which you are enabling, disabling, or modifying lifecycle
    /// management.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <c>LifecyclePolicies</c> array of <c>LifecyclePolicy</c> objects that define when
    /// to move files to IA storage, to Archive storage, and back to primary storage.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon EFS requires that each <c>LifecyclePolicy</c> object have only have a single
    /// transition, so the <c>LifecyclePolicies</c> array needs to be structured with separate
    /// <c>LifecyclePolicy</c> objects. See the example requests in the following section
    /// for more information.
    /// </para>
    ///  </note> </li> </ul> 
    /// <para>
    /// This operation requires permissions for the <c>elasticfilesystem:PutLifecycleConfiguration</c>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// To apply a <c>LifecycleConfiguration</c> object to an encrypted file system, you need
    /// the same Key Management Service permissions as when you created the encrypted file
    /// system.
    /// </para>
    /// </summary>
    public partial class PutLifecycleConfigurationRequest : AmazonElasticFileSystemRequest
    {
        private string _fileSystemId;
        private List<LifecyclePolicy> _lifecyclePolicies = AWSConfigs.InitializeCollections ? new List<LifecyclePolicy>() : null;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the file system for which you are creating the <c>LifecycleConfiguration</c>
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
        /// An array of <c>LifecyclePolicy</c> objects that define the file system's <c>LifecycleConfiguration</c>
        /// object. A <c>LifecycleConfiguration</c> object informs lifecycle management of the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>TransitionToIA</c> </b> – When to move files in the file system from primary
        /// storage (Standard storage class) into the Infrequent Access (IA) storage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>TransitionToArchive</c> </b> – When to move files in the file system from
        /// their current storage class (either IA or Standard storage) into the Archive storage.
        /// </para>
        ///  
        /// <para>
        /// File systems cannot transition into Archive storage before transitioning into IA storage.
        /// Therefore, TransitionToArchive must either not be set or must be later than TransitionToIA.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Archive storage class is available only for file systems that use the Elastic
        /// throughput mode and the General Purpose performance mode. 
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <b> <c>TransitionToPrimaryStorageClass</c> </b> – Whether to move files in the file
        /// system back to primary storage (Standard storage class) after they are accessed in
        /// IA or Archive storage.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// When using the <c>put-lifecycle-configuration</c> CLI command or the <c>PutLifecycleConfiguration</c>
        /// API action, Amazon EFS requires that each <c>LifecyclePolicy</c> object have only
        /// a single transition. This means that in a request body, <c>LifecyclePolicies</c> must
        /// be structured as an array of <c>LifecyclePolicy</c> objects, one object for each storage
        /// transition. See the example requests in the following section for more information.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._lifecyclePolicies != null && (this._lifecyclePolicies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}