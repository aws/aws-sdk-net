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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Detailed data of the sync blocker.
    /// </summary>
    public partial class SyncBlocker
    {
        private List<SyncBlockerContext> _contexts = new List<SyncBlockerContext>();
        private DateTime? _createdAt;
        private string _createdReason;
        private string _id;
        private DateTime? _resolvedAt;
        private string _resolvedReason;
        private BlockerStatus _status;
        private BlockerType _type;

        /// <summary>
        /// Gets and sets the property Contexts. 
        /// <para>
        /// The contexts for the sync blocker.
        /// </para>
        /// </summary>
        public List<SyncBlockerContext> Contexts
        {
            get { return this._contexts; }
            set { this._contexts = value; }
        }

        // Check to see if Contexts property is set
        internal bool IsSetContexts()
        {
            return this._contexts != null && this._contexts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the sync blocker was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedReason. 
        /// <para>
        /// The reason why the sync blocker was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreatedReason
        {
            get { return this._createdReason; }
            set { this._createdReason = value; }
        }

        // Check to see if CreatedReason property is set
        internal bool IsSetCreatedReason()
        {
            return this._createdReason != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the sync blocker.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property ResolvedAt. 
        /// <para>
        /// The time the sync blocker was resolved.
        /// </para>
        /// </summary>
        public DateTime ResolvedAt
        {
            get { return this._resolvedAt.GetValueOrDefault(); }
            set { this._resolvedAt = value; }
        }

        // Check to see if ResolvedAt property is set
        internal bool IsSetResolvedAt()
        {
            return this._resolvedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResolvedReason. 
        /// <para>
        /// The reason the sync blocker was resolved.
        /// </para>
        /// </summary>
        public string ResolvedReason
        {
            get { return this._resolvedReason; }
            set { this._resolvedReason = value; }
        }

        // Check to see if ResolvedReason property is set
        internal bool IsSetResolvedReason()
        {
            return this._resolvedReason != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the sync blocker.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BlockerStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the sync blocker.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BlockerType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}