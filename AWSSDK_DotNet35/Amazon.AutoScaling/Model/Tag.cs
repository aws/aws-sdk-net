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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes a tag applied to an Auto Scaling group.
    /// </summary>
    public partial class Tag
    {
        private string _key;
        private bool? _propagateAtLaunch;
        private string _resourceId;
        private string _resourceType;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The tag key.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property PropagateAtLaunch. 
        /// <para>
        /// Specifies whether the tag is applied to instances launched after the tag is created.
        /// The same behavior applies to updates: If you change a tag, it is applied to all instances
        /// launched after you made the change.
        /// </para>
        /// </summary>
        public bool PropagateAtLaunch
        {
            get { return this._propagateAtLaunch.GetValueOrDefault(); }
            set { this._propagateAtLaunch = value; }
        }

        // Check to see if PropagateAtLaunch property is set
        internal bool IsSetPropagateAtLaunch()
        {
            return this._propagateAtLaunch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The name of the group.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The kind of resource to which the tag is applied. Currently, Auto Scaling supports
        /// the <code>auto-scaling-group</code> resource type.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The tag value.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}