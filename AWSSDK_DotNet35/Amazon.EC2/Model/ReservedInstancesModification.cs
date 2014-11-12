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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a Reserved Instance modification.
    /// </summary>
    public partial class ReservedInstancesModification
    {
        private string _clientToken;
        private DateTime? _createDate;
        private DateTime? _effectiveDate;
        private List<ReservedInstancesModificationResult> _modificationResults = new List<ReservedInstancesModificationResult>();
        private List<ReservedInstancesId> _reservedInstancesIds = new List<ReservedInstancesId>();
        private string _reservedInstancesModificationId;
        private string _status;
        private string _statusMessage;
        private DateTime? _updateDate;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive key supplied by the client to ensure that the modification
        /// request is idempotent.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The time when the modification request was created.
        /// </para>
        /// </summary>
        public DateTime CreateDate
        {
            get { return this._createDate.GetValueOrDefault(); }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EffectiveDate. 
        /// <para>
        /// The time for the modification to become effective.
        /// </para>
        /// </summary>
        public DateTime EffectiveDate
        {
            get { return this._effectiveDate.GetValueOrDefault(); }
            set { this._effectiveDate = value; }
        }

        // Check to see if EffectiveDate property is set
        internal bool IsSetEffectiveDate()
        {
            return this._effectiveDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModificationResults. 
        /// <para>
        /// Contains target configurations along with their corresponding new Reserved Instance
        /// IDs.
        /// </para>
        /// </summary>
        public List<ReservedInstancesModificationResult> ModificationResults
        {
            get { return this._modificationResults; }
            set { this._modificationResults = value; }
        }

        // Check to see if ModificationResults property is set
        internal bool IsSetModificationResults()
        {
            return this._modificationResults != null && this._modificationResults.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReservedInstancesIds. 
        /// <para>
        /// The IDs of one or more Reserved Instances.
        /// </para>
        /// </summary>
        public List<ReservedInstancesId> ReservedInstancesIds
        {
            get { return this._reservedInstancesIds; }
            set { this._reservedInstancesIds = value; }
        }

        // Check to see if ReservedInstancesIds property is set
        internal bool IsSetReservedInstancesIds()
        {
            return this._reservedInstancesIds != null && this._reservedInstancesIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReservedInstancesModificationId. 
        /// <para>
        /// A unique ID for the Reserved Instance modification.
        /// </para>
        /// </summary>
        public string ReservedInstancesModificationId
        {
            get { return this._reservedInstancesModificationId; }
            set { this._reservedInstancesModificationId = value; }
        }

        // Check to see if ReservedInstancesModificationId property is set
        internal bool IsSetReservedInstancesModificationId()
        {
            return this._reservedInstancesModificationId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Reserved Instances modification request.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The reason for the status.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateDate. 
        /// <para>
        /// The time when the modification request was last updated.
        /// </para>
        /// </summary>
        public DateTime UpdateDate
        {
            get { return this._updateDate.GetValueOrDefault(); }
            set { this._updateDate = value; }
        }

        // Check to see if UpdateDate property is set
        internal bool IsSetUpdateDate()
        {
            return this._updateDate.HasValue; 
        }

    }
}