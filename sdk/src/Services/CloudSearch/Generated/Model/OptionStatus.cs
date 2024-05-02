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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
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
namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// The status of domain configuration option.
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
        /// A timestamp for when this option was created.
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
        /// Indicates that the option will be deleted once processing is complete.
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
        /// The state of processing a change to an option. Possible values:
        /// </para>
        /// <ul> <li><c>RequiresIndexDocuments</c>: the option's latest value will not be deployed
        /// until <a>IndexDocuments</a> has been called and indexing is complete.</li> <li><c>Processing</c>:
        /// the option's latest value is in the process of being activated. </li> <li><c>Active</c>:
        /// the option's latest value is completely deployed.</li> <li><c>FailedToValidate</c>:
        /// the option value is not compatible with the domain's data and cannot be used to index
        /// the data. You must either modify the option value or update or remove the incompatible
        /// documents.</li> </ul>
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
        /// A timestamp for when this option was last updated.
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
        /// A unique integer that indicates when this option was last updated.
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