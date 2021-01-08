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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// An object that contains the <code>ChangeType</code>, <code>Details</code>, and <code>Entity</code>.
    /// </summary>
    public partial class Change
    {
        private string _changeType;
        private string _details;
        private Entity _entity;

        /// <summary>
        /// Gets and sets the property ChangeType. 
        /// <para>
        /// Change types are single string values that describe your intention for the change.
        /// Each change type is unique for each <code>EntityType</code> provided in the change's
        /// scope.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ChangeType
        {
            get { return this._changeType; }
            set { this._changeType = value; }
        }

        // Check to see if ChangeType property is set
        internal bool IsSetChangeType()
        {
            return this._changeType != null;
        }

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// This object contains details specific to the change type of the requested change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=16384)]
        public string Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null;
        }

        /// <summary>
        /// Gets and sets the property Entity. 
        /// <para>
        /// The entity to be changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Entity Entity
        {
            get { return this._entity; }
            set { this._entity = value; }
        }

        // Check to see if Entity property is set
        internal bool IsSetEntity()
        {
            return this._entity != null;
        }

    }
}