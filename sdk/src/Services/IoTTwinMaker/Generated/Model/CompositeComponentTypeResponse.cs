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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// An object that returns information about the composite component types of a component
    /// type.
    /// </summary>
    public partial class CompositeComponentTypeResponse
    {
        private string _componentTypeId;
        private bool? _isInherited;

        /// <summary>
        /// Gets and sets the property ComponentTypeId. 
        /// <para>
        /// This is the <c>componentTypeId</c> that this <c>compositeComponentType</c> refers
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ComponentTypeId
        {
            get { return this._componentTypeId; }
            set { this._componentTypeId = value; }
        }

        // Check to see if ComponentTypeId property is set
        internal bool IsSetComponentTypeId()
        {
            return this._componentTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property IsInherited. 
        /// <para>
        /// This boolean indicates whether this <c>compositeComponentType</c> is inherited from
        /// its parent.
        /// </para>
        /// </summary>
        public bool? IsInherited
        {
            get { return this._isInherited; }
            set { this._isInherited = value; }
        }

        // Check to see if IsInherited property is set
        internal bool IsSetIsInherited()
        {
            return this._isInherited.HasValue; 
        }

    }
}