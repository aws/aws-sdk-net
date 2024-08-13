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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
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
namespace Amazon.Detective.Model
{
    /// <summary>
    /// Details tactics, techniques, and procedures (TTPs) used in a potential security event.
    /// Tactics are based on <a href="https://attack.mitre.org/matrices/enterprise/">MITRE
    /// ATT&amp;CK Matrix for Enterprise</a>.
    /// </summary>
    public partial class TTPsObservedDetail
    {
        private long? _apiFailureCount;
        private string _apiName;
        private long? _apiSuccessCount;
        private string _ipAddress;
        private string _procedure;
        private string _tactic;
        private string _technique;

        /// <summary>
        /// Gets and sets the property APIFailureCount. 
        /// <para>
        /// The total number of failed API requests.
        /// </para>
        /// </summary>
        public long? APIFailureCount
        {
            get { return this._apiFailureCount; }
            set { this._apiFailureCount = value; }
        }

        // Check to see if APIFailureCount property is set
        internal bool IsSetAPIFailureCount()
        {
            return this._apiFailureCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property APIName. 
        /// <para>
        /// The name of the API where the tactics, techniques, and procedure (TTP) was observed.
        /// </para>
        /// </summary>
        public string APIName
        {
            get { return this._apiName; }
            set { this._apiName = value; }
        }

        // Check to see if APIName property is set
        internal bool IsSetAPIName()
        {
            return this._apiName != null;
        }

        /// <summary>
        /// Gets and sets the property APISuccessCount. 
        /// <para>
        /// The total number of successful API requests.
        /// </para>
        /// </summary>
        public long? APISuccessCount
        {
            get { return this._apiSuccessCount; }
            set { this._apiSuccessCount = value; }
        }

        // Check to see if APISuccessCount property is set
        internal bool IsSetAPISuccessCount()
        {
            return this._apiSuccessCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address where the tactics, techniques, and procedure (TTP) was observed.
        /// </para>
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Procedure. 
        /// <para>
        /// The procedure used, identified by the investigation.
        /// </para>
        /// </summary>
        public string Procedure
        {
            get { return this._procedure; }
            set { this._procedure = value; }
        }

        // Check to see if Procedure property is set
        internal bool IsSetProcedure()
        {
            return this._procedure != null;
        }

        /// <summary>
        /// Gets and sets the property Tactic. 
        /// <para>
        /// The tactic used, identified by the investigation.
        /// </para>
        /// </summary>
        public string Tactic
        {
            get { return this._tactic; }
            set { this._tactic = value; }
        }

        // Check to see if Tactic property is set
        internal bool IsSetTactic()
        {
            return this._tactic != null;
        }

        /// <summary>
        /// Gets and sets the property Technique. 
        /// <para>
        /// The technique used, identified by the investigation. 
        /// </para>
        /// </summary>
        public string Technique
        {
            get { return this._technique; }
            set { this._technique = value; }
        }

        // Check to see if Technique property is set
        internal bool IsSetTechnique()
        {
            return this._technique != null;
        }

    }
}