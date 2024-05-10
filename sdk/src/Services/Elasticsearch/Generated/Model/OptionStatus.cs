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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Provides the current status of the entity.
    /// </summary>
    public partial class OptionStatus
    {
        private DateTime? _creationDate;
        private bool? _pendingDeletion;
        private OptionState _state;
        private DateTime? _updateDate;
        private int? _updateVersion;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// Timestamp which tells the creation date for the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingDeletion. 
        /// <para>
        /// Indicates whether the Elasticsearch domain is being deleted.
        /// </para>
        /// </summary>
        public bool? PendingDeletion
        {
            get { return this._pendingDeletion; }
            set { this._pendingDeletion = value; }
        }

        // Check to see if PendingDeletion property is set
        internal bool IsSetPendingDeletion()
        {
            return this._pendingDeletion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Provides the <c>OptionState</c> for the Elasticsearch domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OptionState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateDate. 
        /// <para>
        /// Timestamp which tells the last updated time for the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdateDate
        {
            get { return this._updateDate; }
            set { this._updateDate = value; }
        }

        // Check to see if UpdateDate property is set
        internal bool IsSetUpdateDate()
        {
            return this._updateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdateVersion. 
        /// <para>
        /// Specifies the latest version for the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? UpdateVersion
        {
            get { return this._updateVersion; }
            set { this._updateVersion = value; }
        }

        // Check to see if UpdateVersion property is set
        internal bool IsSetUpdateVersion()
        {
            return this._updateVersion.HasValue; 
        }

    }
}