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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Detaches the specified policy from the specified directory inside a <a>BatchWrite</a>
    /// operation. For more information, see <a>DetachPolicy</a> and <a>BatchWriteRequest$Operations</a>.
    /// </summary>
    public partial class BatchDetachPolicy
    {
        private ObjectReference _objectReference;
        private ObjectReference _policyReference;

        /// <summary>
        /// Gets and sets the property ObjectReference. 
        /// <para>
        /// Reference that identifies the object whose policy object will be detached.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ObjectReference ObjectReference
        {
            get { return this._objectReference; }
            set { this._objectReference = value; }
        }

        // Check to see if ObjectReference property is set
        internal bool IsSetObjectReference()
        {
            return this._objectReference != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyReference. 
        /// <para>
        /// Reference that identifies the policy object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ObjectReference PolicyReference
        {
            get { return this._policyReference; }
            set { this._policyReference = value; }
        }

        // Check to see if PolicyReference property is set
        internal bool IsSetPolicyReference()
        {
            return this._policyReference != null;
        }

    }
}