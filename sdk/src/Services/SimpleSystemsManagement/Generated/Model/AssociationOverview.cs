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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about the association.
    /// </summary>
    public partial class AssociationOverview
    {
        private Dictionary<string, int> _associationStatusAggregatedCount = new Dictionary<string, int>();
        private string _detailedStatus;
        private string _status;

        /// <summary>
        /// Gets and sets the property AssociationStatusAggregatedCount. 
        /// <para>
        /// Returns the number of targets for the association status. For example, if you created
        /// an association with two instances, and one of them was successful, this would return
        /// the count of instances by status.
        /// </para>
        /// </summary>
        public Dictionary<string, int> AssociationStatusAggregatedCount
        {
            get { return this._associationStatusAggregatedCount; }
            set { this._associationStatusAggregatedCount = value; }
        }

        // Check to see if AssociationStatusAggregatedCount property is set
        internal bool IsSetAssociationStatusAggregatedCount()
        {
            return this._associationStatusAggregatedCount != null && this._associationStatusAggregatedCount.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DetailedStatus. 
        /// <para>
        /// A detailed status of the association.
        /// </para>
        /// </summary>
        public string DetailedStatus
        {
            get { return this._detailedStatus; }
            set { this._detailedStatus = value; }
        }

        // Check to see if DetailedStatus property is set
        internal bool IsSetDetailedStatus()
        {
            return this._detailedStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the association. Status can be: <code>Pending</code>, <code>Success</code>,
        /// or <code>Failed</code>.
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

    }
}