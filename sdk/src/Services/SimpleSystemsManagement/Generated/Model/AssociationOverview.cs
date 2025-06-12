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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about the association.
    /// </summary>
    public partial class AssociationOverview
    {
        private Dictionary<string, int> _associationStatusAggregatedCount = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;
        private string _detailedStatus;
        private string _status;

        /// <summary>
        /// Gets and sets the property AssociationStatusAggregatedCount. 
        /// <para>
        /// Returns the number of targets for the association status. For example, if you created
        /// an association with two managed nodes, and one of them was successful, this would
        /// return the count of managed nodes by status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> AssociationStatusAggregatedCount
        {
            get { return this._associationStatusAggregatedCount; }
            set { this._associationStatusAggregatedCount = value; }
        }

        // Check to see if AssociationStatusAggregatedCount property is set
        internal bool IsSetAssociationStatusAggregatedCount()
        {
            return this._associationStatusAggregatedCount != null && (this._associationStatusAggregatedCount.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The status of the association. Status can be: Pending, Success, or Failed.
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