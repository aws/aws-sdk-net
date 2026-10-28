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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// The supportability score for a single instance type and Availability Zone combination.
    /// </summary>
    public partial class CapacityManagerSupportabilityScore
    {
        private string _availabilityZoneId;
        private string _instanceType;
        private SupportabilityScore _score;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        ///  The ID of the Availability Zone. 
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        ///  The instance type. 
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        ///  How well the combination can support the requested capacity right now. <c>high</c>
        /// means that the combination holds several times the requested amount. <c>medium</c>
        /// means that it can cover the request with little to spare. <c>low</c> means that it
        /// holds less than the requested amount. 
        /// </para>
        /// </summary>
        public SupportabilityScore Score
        {
            get { return this._score; }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score != null;
        }

    }
}