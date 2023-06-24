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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Properties of the cloud environment where this Source Server originated from.
    /// </summary>
    public partial class SourceCloudProperties
    {
        private string _originAccountID;
        private string _originAvailabilityZone;
        private string _originRegion;

        /// <summary>
        /// Gets and sets the property OriginAccountID. 
        /// <para>
        /// AWS Account ID for an EC2-originated Source Server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string OriginAccountID
        {
            get { return this._originAccountID; }
            set { this._originAccountID = value; }
        }

        // Check to see if OriginAccountID property is set
        internal bool IsSetOriginAccountID()
        {
            return this._originAccountID != null;
        }

        /// <summary>
        /// Gets and sets the property OriginAvailabilityZone. 
        /// <para>
        /// AWS Availability Zone for an EC2-originated Source Server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string OriginAvailabilityZone
        {
            get { return this._originAvailabilityZone; }
            set { this._originAvailabilityZone = value; }
        }

        // Check to see if OriginAvailabilityZone property is set
        internal bool IsSetOriginAvailabilityZone()
        {
            return this._originAvailabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property OriginRegion. 
        /// <para>
        /// AWS Region for an EC2-originated Source Server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string OriginRegion
        {
            get { return this._originRegion; }
            set { this._originRegion = value; }
        }

        // Check to see if OriginRegion property is set
        internal bool IsSetOriginRegion()
        {
            return this._originRegion != null;
        }

    }
}