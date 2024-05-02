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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
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
namespace Amazon.Glacier.Model
{
    /// <summary>
    /// The definition for a provisioned capacity unit.
    /// </summary>
    public partial class ProvisionedCapacityDescription
    {
        private string _capacityId;
        private string _expirationDate;
        private string _startDate;

        /// <summary>
        /// Gets and sets the property CapacityId. 
        /// <para>
        /// The ID that identifies the provisioned capacity unit.
        /// </para>
        /// </summary>
        public string CapacityId
        {
            get { return this._capacityId; }
            set { this._capacityId = value; }
        }

        // Check to see if CapacityId property is set
        internal bool IsSetCapacityId()
        {
            return this._capacityId != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The date that the provisioned capacity unit expires, in Universal Coordinated Time
        /// (UTC).
        /// </para>
        /// </summary>
        public string ExpirationDate
        {
            get { return this._expirationDate; }
            set { this._expirationDate = value; }
        }

        // Check to see if ExpirationDate property is set
        internal bool IsSetExpirationDate()
        {
            return this._expirationDate != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date that the provisioned capacity unit was purchased, in Universal Coordinated
        /// Time (UTC).
        /// </para>
        /// </summary>
        public string StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate != null;
        }

    }
}