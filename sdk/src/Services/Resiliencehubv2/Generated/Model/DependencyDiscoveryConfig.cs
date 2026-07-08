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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Configuration for dependency discovery on a service.
    /// </summary>
    public partial class DependencyDiscoveryConfig
    {
        private int? _eligibleResourceCount;
        private string _message;
        private DependencyDiscoveryStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property EligibleResourceCount. 
        /// <para>
        /// The count of resources eligible for dependency attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? EligibleResourceCount
        {
            get { return this._eligibleResourceCount; }
            set { this._eligibleResourceCount = value; }
        }

        // Check to see if EligibleResourceCount property is set
        internal bool IsSetEligibleResourceCount()
        {
            return this._eligibleResourceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A status message for dependency discovery, displayed during the initialization state.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of dependency discovery.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DependencyDiscoveryStatus Status
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when dependency discovery was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}