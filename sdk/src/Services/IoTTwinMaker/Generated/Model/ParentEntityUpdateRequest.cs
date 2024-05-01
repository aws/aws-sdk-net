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
    /// The parent entity update request.
    /// </summary>
    public partial class ParentEntityUpdateRequest
    {
        private string _parentEntityId;
        private ParentEntityUpdateType _updateType;

        /// <summary>
        /// Gets and sets the property ParentEntityId. 
        /// <para>
        /// The ID of the parent entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ParentEntityId
        {
            get { return this._parentEntityId; }
            set { this._parentEntityId = value; }
        }

        // Check to see if ParentEntityId property is set
        internal bool IsSetParentEntityId()
        {
            return this._parentEntityId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateType. 
        /// <para>
        /// The type of the update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ParentEntityUpdateType UpdateType
        {
            get { return this._updateType; }
            set { this._updateType = value; }
        }

        // Check to see if UpdateType property is set
        internal bool IsSetUpdateType()
        {
            return this._updateType != null;
        }

    }
}