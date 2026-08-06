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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The free trial period for a Security Hub feature, and whether the trial is currently
    /// active.
    /// </summary>
    public partial class FreeTrialStatus
    {
        private DateTime? _expiresAt;
        private FreeTrialType _featureType;
        private DateTime? _startedAt;
        private FreeTrialStatusValue _status;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The date and time at which the free trial period ends.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ExpiresAt
        {
            get { return this._expiresAt; }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FeatureType. 
        /// <para>
        /// The feature that the free trial period applies to. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SECURITY_HUB_V2</c> specifies Security Hub.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SECURITY_HUB_V2_MULTI_CLOUD_AZURE</c> specifies Security Hub coverage for Microsoft
        /// Azure resources.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public FreeTrialType FeatureType
        {
            get { return this._featureType; }
            set { this._featureType = value; }
        }

        // Check to see if FeatureType property is set
        internal bool IsSetFeatureType()
        {
            return this._featureType != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time at which the free trial period began.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Whether the free trial period is currently active. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> specifies that the free trial period is ongoing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVE</c> specifies that the free trial period has ended, or that it never
        /// started.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To determine whether a trial has expired, compare <c>ExpiresAt</c> to the current
        /// time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FreeTrialStatusValue Status
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