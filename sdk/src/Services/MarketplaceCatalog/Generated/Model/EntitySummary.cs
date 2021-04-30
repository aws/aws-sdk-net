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
    /// This object is a container for common summary information about the entity. The summary
    /// doesn't contain the whole entity structure, but it does contain information common
    /// across all entities.
    /// </summary>
    public partial class EntitySummary
    {
        private string _entityArn;
        private string _entityId;
        private string _entityType;
        private string _lastModifiedDate;
        private string _name;
        private string _visibility;

        /// <summary>
        /// Gets and sets the property EntityArn. 
        /// <para>
        /// The ARN associated with the unique identifier for the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string EntityArn
        {
            get { return this._entityArn; }
            set { this._entityArn = value; }
        }

        // Check to see if EntityArn property is set
        internal bool IsSetEntityArn()
        {
            return this._entityArn != null;
        }

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The unique identifier for the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string EntityType
        {
            get { return this._entityType; }
            set { this._entityType = value; }
        }

        // Check to see if EntityType property is set
        internal bool IsSetEntityType()
        {
            return this._entityType != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The last time the entity was published, using ISO 8601 format (2018-02-27T13:45:22Z).
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
        public string LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the entity. This value is not unique. It is defined by the seller.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility status of the entity to buyers. This value can be <code>Public</code>
        /// (everyone can view the entity), <code>Limited</code> (the entity is visible to limited
        /// accounts only), or <code>Restricted</code> (the entity was published and then unpublished
        /// and only existing buyers can view it). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

    }
}