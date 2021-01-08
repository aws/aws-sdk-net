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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateThingGroup operation.
    /// Create a thing group.
    /// 
    ///  <note> 
    /// <para>
    /// This is a control plane operation. See <a href="https://docs.aws.amazon.com/iot/latest/developerguide/iot-authorization.html">Authorization</a>
    /// for information about authorizing control plane actions.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateThingGroupRequest : AmazonIoTRequest
    {
        private string _parentGroupName;
        private List<Tag> _tags = new List<Tag>();
        private string _thingGroupName;
        private ThingGroupProperties _thingGroupProperties;

        /// <summary>
        /// Gets and sets the property ParentGroupName. 
        /// <para>
        /// The name of the parent thing group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ParentGroupName
        {
            get { return this._parentGroupName; }
            set { this._parentGroupName = value; }
        }

        // Check to see if ParentGroupName property is set
        internal bool IsSetParentGroupName()
        {
            return this._parentGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata which can be used to manage the thing group.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ThingGroupName. 
        /// <para>
        /// The thing group name to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ThingGroupName
        {
            get { return this._thingGroupName; }
            set { this._thingGroupName = value; }
        }

        // Check to see if ThingGroupName property is set
        internal bool IsSetThingGroupName()
        {
            return this._thingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ThingGroupProperties. 
        /// <para>
        /// The thing group properties.
        /// </para>
        /// </summary>
        public ThingGroupProperties ThingGroupProperties
        {
            get { return this._thingGroupProperties; }
            set { this._thingGroupProperties = value; }
        }

        // Check to see if ThingGroupProperties property is set
        internal bool IsSetThingGroupProperties()
        {
            return this._thingGroupProperties != null;
        }

    }
}