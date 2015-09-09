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
 * Do not modify this file. This file is generated from the ec2-2015-04-15.normal.json service model.
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
    /// Describes the configuration of a Spot fleet request.
    /// </summary>
    public partial class SpotFleetRequestConfigData
    {
        private string _clientToken;
        private string _iamFleetRole;
        private List<SpotFleetLaunchSpecification> _launchSpecifications = new List<SpotFleetLaunchSpecification>();
        private string _spotPrice;
        private int? _targetCapacity;
        private bool? _terminateInstancesWithExpiration;
        private DateTime? _validFrom;
        private DateTime? _validUntil;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier you provide to ensure idempotency of your listings.
        /// This helps avoid duplicate listings. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
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
        /// Gets and sets the property IamFleetRole. 
        /// <para>
        /// Grants the Spot fleet service permission to terminate instances on your behalf when
        /// you cancel a Spot fleet request using <a>CancelSpotFleetRequests</a> or when the Spot
        /// fleet request expires, if you set <code>terminateInstancesWithExpiration</code>.
        /// </para>
        /// </summary>
        public string IamFleetRole
        {
            get { return this._iamFleetRole; }
            set { this._iamFleetRole = value; }
        }

        // Check to see if IamFleetRole property is set
        internal bool IsSetIamFleetRole()
        {
            return this._iamFleetRole != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchSpecifications. 
        /// <para>
        /// Information about the launch specifications for the instances.
        /// </para>
        /// </summary>
        public List<SpotFleetLaunchSpecification> LaunchSpecifications
        {
            get { return this._launchSpecifications; }
            set { this._launchSpecifications = value; }
        }

        // Check to see if LaunchSpecifications property is set
        internal bool IsSetLaunchSpecifications()
        {
            return this._launchSpecifications != null && this._launchSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SpotPrice. 
        /// <para>
        /// The bid price per unit hour.
        /// </para>
        /// </summary>
        public string SpotPrice
        {
            get { return this._spotPrice; }
            set { this._spotPrice = value; }
        }

        // Check to see if SpotPrice property is set
        internal bool IsSetSpotPrice()
        {
            return this._spotPrice != null;
        }

        /// <summary>
        /// Gets and sets the property TargetCapacity. 
        /// <para>
        /// The number of units to request. You can choose to set the target capacity in terms
        /// of instances or a performance characteristic that is important to your application
        /// workload, such as vCPUs, memory, or I/O.
        /// </para>
        /// </summary>
        public int TargetCapacity
        {
            get { return this._targetCapacity.GetValueOrDefault(); }
            set { this._targetCapacity = value; }
        }

        // Check to see if TargetCapacity property is set
        internal bool IsSetTargetCapacity()
        {
            return this._targetCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TerminateInstancesWithExpiration. 
        /// <para>
        /// Indicates whether running instances should be terminated when the Spot fleet request
        /// expires.
        /// </para>
        /// </summary>
        public bool TerminateInstancesWithExpiration
        {
            get { return this._terminateInstancesWithExpiration.GetValueOrDefault(); }
            set { this._terminateInstancesWithExpiration = value; }
        }

        // Check to see if TerminateInstancesWithExpiration property is set
        internal bool IsSetTerminateInstancesWithExpiration()
        {
            return this._terminateInstancesWithExpiration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidFrom. 
        /// <para>
        /// The start date and time of the request, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// The default is to start fulfilling the request immediately.
        /// </para>
        /// </summary>
        public DateTime ValidFrom
        {
            get { return this._validFrom.GetValueOrDefault(); }
            set { this._validFrom = value; }
        }

        // Check to see if ValidFrom property is set
        internal bool IsSetValidFrom()
        {
            return this._validFrom.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidUntil. 
        /// <para>
        /// The end date and time of the request, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// At this point, no new Spot Instance requests are placed or enabled to fulfill the
        /// request.
        /// </para>
        /// </summary>
        public DateTime ValidUntil
        {
            get { return this._validUntil.GetValueOrDefault(); }
            set { this._validUntil = value; }
        }

        // Check to see if ValidUntil property is set
        internal bool IsSetValidUntil()
        {
            return this._validUntil.HasValue; 
        }

    }
}