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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Describes a policy used by lifecycle management that specifies when to transition
    /// files into and out of storage classes. For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/lifecycle-management-efs.html">Managing
    /// file system storage</a>.
    /// 
    ///  <note> 
    /// <para>
    /// When using the <c>put-lifecycle-configuration</c> CLI command or the <c>PutLifecycleConfiguration</c>
    /// API action, Amazon EFS requires that each <c>LifecyclePolicy</c> object have only
    /// a single transition. This means that in a request body, <c>LifecyclePolicies</c> must
    /// be structured as an array of <c>LifecyclePolicy</c> objects, one object for each transition.
    /// For more information, see the request examples in <a>PutLifecycleConfiguration</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class LifecyclePolicy
    {
        /// <summary>
        /// Gets and sets the property TransitionToArchive. 
        /// <para>
        /// The number of days after files were last accessed in primary storage (the Standard
        /// storage class) at which to move them to Archive storage. Metadata operations such
        /// as listing the contents of a directory don't count as file access events.
        /// </para>
        /// </summary>
        public TransitionToArchiveRules TransitionToArchive { get; set; }

        /// <summary>
        /// Checks to see if the TransitionToArchive property is set.
        /// </summary>
        internal bool IsSetTransitionToArchive() => this.TransitionToArchive != null;

        /// <summary>
        /// Gets and sets the property TransitionToIA. 
        /// <para>
        /// The number of days after files were last accessed in primary storage (the Standard
        /// storage class) at which to move them to Infrequent Access (IA) storage. Metadata operations
        /// such as listing the contents of a directory don't count as file access events.
        /// </para>
        /// </summary>
        public TransitionToIARules TransitionToIA { get; set; }

        /// <summary>
        /// Checks to see if the TransitionToIA property is set.
        /// </summary>
        internal bool IsSetTransitionToIA() => this.TransitionToIA != null;

        /// <summary>
        /// Gets and sets the property TransitionToPrimaryStorageClass. 
        /// <para>
        /// Whether to move files back to primary (Standard) storage after they are accessed in
        /// IA or Archive storage. Metadata operations such as listing the contents of a directory
        /// don't count as file access events.
        /// </para>
        /// </summary>
        public TransitionToPrimaryStorageClassRules TransitionToPrimaryStorageClass { get; set; }

        /// <summary>
        /// Checks to see if the TransitionToPrimaryStorageClass property is set.
        /// </summary>
        internal bool IsSetTransitionToPrimaryStorageClass() => this.TransitionToPrimaryStorageClass != null;
    }
}
