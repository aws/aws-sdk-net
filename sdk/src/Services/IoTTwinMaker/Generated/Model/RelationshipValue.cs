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
    /// A value that associates a component and an entity.
    /// </summary>
    public partial class RelationshipValue
    {
        private string _targetComponentName;
        private string _targetEntityId;

        /// <summary>
        /// Gets and sets the property TargetComponentName. 
        /// <para>
        /// The name of the target component associated with the relationship value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string TargetComponentName
        {
            get { return this._targetComponentName; }
            set { this._targetComponentName = value; }
        }

        // Check to see if TargetComponentName property is set
        internal bool IsSetTargetComponentName()
        {
            return this._targetComponentName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetEntityId. 
        /// <para>
        /// The ID of the target entity associated with this relationship value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string TargetEntityId
        {
            get { return this._targetEntityId; }
            set { this._targetEntityId = value; }
        }

        // Check to see if TargetEntityId property is set
        internal bool IsSetTargetEntityId()
        {
            return this._targetEntityId != null;
        }

    }
}