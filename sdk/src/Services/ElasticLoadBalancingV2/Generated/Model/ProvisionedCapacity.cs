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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ProvisionedCapacity
    {
        private int? _decreasesRemaining;
        private DateTime? _lastModifiedTime;
        private int? _minimumLBCapacityUnits;
        private ProvisionedCapacityStatus _status;

        /// <summary>
        /// Gets and sets the property DecreasesRemaining.
        /// </summary>
        public int DecreasesRemaining
        {
            get { return this._decreasesRemaining.GetValueOrDefault(); }
            set { this._decreasesRemaining = value; }
        }

        // Check to see if DecreasesRemaining property is set
        internal bool IsSetDecreasesRemaining()
        {
            return this._decreasesRemaining.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime.
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumLBCapacityUnits.
        /// </summary>
        public int MinimumLBCapacityUnits
        {
            get { return this._minimumLBCapacityUnits.GetValueOrDefault(); }
            set { this._minimumLBCapacityUnits = value; }
        }

        // Check to see if MinimumLBCapacityUnits property is set
        internal bool IsSetMinimumLBCapacityUnits()
        {
            return this._minimumLBCapacityUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        public ProvisionedCapacityStatus Status
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