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
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Represents the output of an <code>AttachObject</code> operation.
    /// </summary>
    public partial class BatchAttachObject
    {
        private ObjectReference _childReference;
        private string _linkName;
        private ObjectReference _parentReference;

        /// <summary>
        /// Gets and sets the property ChildReference. 
        /// <para>
        /// The child object reference that is to be attached to the object.
        /// </para>
        /// </summary>
        public ObjectReference ChildReference
        {
            get { return this._childReference; }
            set { this._childReference = value; }
        }

        // Check to see if ChildReference property is set
        internal bool IsSetChildReference()
        {
            return this._childReference != null;
        }

        /// <summary>
        /// Gets and sets the property LinkName. 
        /// <para>
        /// The name of the link.
        /// </para>
        /// </summary>
        public string LinkName
        {
            get { return this._linkName; }
            set { this._linkName = value; }
        }

        // Check to see if LinkName property is set
        internal bool IsSetLinkName()
        {
            return this._linkName != null;
        }

        /// <summary>
        /// Gets and sets the property ParentReference. 
        /// <para>
        /// The parent object reference.
        /// </para>
        /// </summary>
        public ObjectReference ParentReference
        {
            get { return this._parentReference; }
            set { this._parentReference = value; }
        }

        // Check to see if ParentReference property is set
        internal bool IsSetParentReference()
        {
            return this._parentReference != null;
        }

    }
}