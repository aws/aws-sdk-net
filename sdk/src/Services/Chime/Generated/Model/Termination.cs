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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Termination settings enable your SIP hosts to make outbound calls using your Amazon
    /// Chime Voice Connector.
    /// </summary>
    public partial class Termination
    {
        private List<string> _callingRegions = new List<string>();
        private List<string> _cidrAllowedList = new List<string>();
        private int? _cpsLimit;
        private string _defaultPhoneNumber;
        private bool? _disabled;

        /// <summary>
        /// Gets and sets the property CallingRegions. 
        /// <para>
        /// The countries to which calls are allowed, in ISO 3166-1 alpha-2 format. Required.
        /// </para>
        /// </summary>
        public List<string> CallingRegions
        {
            get { return this._callingRegions; }
            set { this._callingRegions = value; }
        }

        // Check to see if CallingRegions property is set
        internal bool IsSetCallingRegions()
        {
            return this._callingRegions != null && this._callingRegions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CidrAllowedList. 
        /// <para>
        /// The IP addresses allowed to make calls, in CIDR format. Required.
        /// </para>
        /// </summary>
        public List<string> CidrAllowedList
        {
            get { return this._cidrAllowedList; }
            set { this._cidrAllowedList = value; }
        }

        // Check to see if CidrAllowedList property is set
        internal bool IsSetCidrAllowedList()
        {
            return this._cidrAllowedList != null && this._cidrAllowedList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CpsLimit. 
        /// <para>
        /// The limit on calls per second. Max value based on account service quota. Default value
        /// of 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int CpsLimit
        {
            get { return this._cpsLimit.GetValueOrDefault(); }
            set { this._cpsLimit = value; }
        }

        // Check to see if CpsLimit property is set
        internal bool IsSetCpsLimit()
        {
            return this._cpsLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultPhoneNumber. 
        /// <para>
        /// The default caller ID phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string DefaultPhoneNumber
        {
            get { return this._defaultPhoneNumber; }
            set { this._defaultPhoneNumber = value; }
        }

        // Check to see if DefaultPhoneNumber property is set
        internal bool IsSetDefaultPhoneNumber()
        {
            return this._defaultPhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// When termination settings are disabled, outbound calls can not be made.
        /// </para>
        /// </summary>
        public bool Disabled
        {
            get { return this._disabled.GetValueOrDefault(); }
            set { this._disabled = value; }
        }

        // Check to see if Disabled property is set
        internal bool IsSetDisabled()
        {
            return this._disabled.HasValue; 
        }

    }
}