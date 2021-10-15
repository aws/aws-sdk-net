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
    /// Describes a policy used by EFS lifecycle management and EFS intelligent tiering that
    /// specifies when to transition files into and out of the file system's Infrequent Access
    /// (IA) storage class. For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/lifecycle-management-efs.html">EFS
    /// Intelligent‐Tiering and EFS Lifecycle Management</a>.
    /// 
    ///  <note> 
    /// <para>
    /// When using the <code>put-lifecycle-configuration</code> CLI command or the <code>PutLifecycleConfiguration</code>
    /// API action, Amazon EFS requires that each <code>LifecyclePolicy</code> object have
    /// only a single transition. This means that in a request body, <code>LifecyclePolicies</code>
    /// needs to be structured as an array of <code>LifecyclePolicy</code> objects, one object
    /// for each transition, <code>TransitionToIA</code>, <code>TransitionToPrimaryStorageClass</code>.
    /// For more information, see the request examples in <a>PutLifecycleConfiguration</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class LifecyclePolicy
    {
        private TransitionToIARules _transitionToIA;
        private TransitionToPrimaryStorageClassRules _transitionToPrimaryStorageClass;

        /// <summary>
        /// Gets and sets the property TransitionToIA. 
        /// <para>
        ///  Describes the period of time that a file is not accessed, after which it transitions
        /// to IA storage. Metadata operations such as listing the contents of a directory don't
        /// count as file access events.
        /// </para>
        /// </summary>
        public TransitionToIARules TransitionToIA
        {
            get { return this._transitionToIA; }
            set { this._transitionToIA = value; }
        }

        // Check to see if TransitionToIA property is set
        internal bool IsSetTransitionToIA()
        {
            return this._transitionToIA != null;
        }

        /// <summary>
        /// Gets and sets the property TransitionToPrimaryStorageClass. 
        /// <para>
        /// Describes when to transition a file from IA storage to primary storage. Metadata operations
        /// such as listing the contents of a directory don't count as file access events.
        /// </para>
        /// </summary>
        public TransitionToPrimaryStorageClassRules TransitionToPrimaryStorageClass
        {
            get { return this._transitionToPrimaryStorageClass; }
            set { this._transitionToPrimaryStorageClass = value; }
        }

        // Check to see if TransitionToPrimaryStorageClass property is set
        internal bool IsSetTransitionToPrimaryStorageClass()
        {
            return this._transitionToPrimaryStorageClass != null;
        }

    }
}