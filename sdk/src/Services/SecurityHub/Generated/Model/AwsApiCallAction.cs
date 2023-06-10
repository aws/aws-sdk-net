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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provided if <code>ActionType</code> is <code>AWS_API_CALL</code>. It provides details
    /// about the API call that was detected.
    /// </summary>
    public partial class AwsApiCallAction
    {
        private Dictionary<string, string> _affectedResources = new Dictionary<string, string>();
        private string _api;
        private string _callerType;
        private AwsApiCallActionDomainDetails _domainDetails;
        private string _firstSeen;
        private string _lastSeen;
        private ActionRemoteIpDetails _remoteIpDetails;
        private string _serviceName;

        /// <summary>
        /// Gets and sets the property AffectedResources. 
        /// <para>
        /// Identifies the resources that were affected by the API call.
        /// </para>
        /// </summary>
        public Dictionary<string, string> AffectedResources
        {
            get { return this._affectedResources; }
            set { this._affectedResources = value; }
        }

        // Check to see if AffectedResources property is set
        internal bool IsSetAffectedResources()
        {
            return this._affectedResources != null && this._affectedResources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Api. 
        /// <para>
        /// The name of the API method that was issued.
        /// </para>
        /// </summary>
        public string Api
        {
            get { return this._api; }
            set { this._api = value; }
        }

        // Check to see if Api property is set
        internal bool IsSetApi()
        {
            return this._api != null;
        }

        /// <summary>
        /// Gets and sets the property CallerType. 
        /// <para>
        /// Indicates whether the API call originated from a remote IP address (<code>remoteip</code>)
        /// or from a DNS domain (<code>domain</code>).
        /// </para>
        /// </summary>
        public string CallerType
        {
            get { return this._callerType; }
            set { this._callerType = value; }
        }

        // Check to see if CallerType property is set
        internal bool IsSetCallerType()
        {
            return this._callerType != null;
        }

        /// <summary>
        /// Gets and sets the property DomainDetails. 
        /// <para>
        /// Provided if <code>CallerType</code> is <code>domain</code>. Provides information about
        /// the DNS domain that the API call originated from.
        /// </para>
        /// </summary>
        public AwsApiCallActionDomainDetails DomainDetails
        {
            get { return this._domainDetails; }
            set { this._domainDetails = value; }
        }

        // Check to see if DomainDetails property is set
        internal bool IsSetDomainDetails()
        {
            return this._domainDetails != null;
        }

        /// <summary>
        /// Gets and sets the property FirstSeen. 
        /// <para>
        /// An ISO8601-formatted timestamp that indicates when the API call was first observed.
        /// </para>
        ///  
        /// <para>
        /// A correctly formatted example is <code>2020-05-21T20:16:34.724Z</code>. The value
        /// cannot contain spaces, and date and time should be separated by <code>T</code>. For
        /// more information, see <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>.
        /// </para>
        /// </summary>
        public string FirstSeen
        {
            get { return this._firstSeen; }
            set { this._firstSeen = value; }
        }

        // Check to see if FirstSeen property is set
        internal bool IsSetFirstSeen()
        {
            return this._firstSeen != null;
        }

        /// <summary>
        /// Gets and sets the property LastSeen. 
        /// <para>
        /// An ISO8601-formatted timestamp that indicates when the API call was most recently
        /// observed.
        /// </para>
        ///  
        /// <para>
        /// A correctly formatted example is <code>2020-05-21T20:16:34.724Z</code>. The value
        /// cannot contain spaces, and date and time should be separated by <code>T</code>. For
        /// more information, see <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>.
        /// </para>
        /// </summary>
        public string LastSeen
        {
            get { return this._lastSeen; }
            set { this._lastSeen = value; }
        }

        // Check to see if LastSeen property is set
        internal bool IsSetLastSeen()
        {
            return this._lastSeen != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteIpDetails. 
        /// <para>
        /// Provided if <code>CallerType</code> is <code>remoteIp</code>. Provides information
        /// about the remote IP address that the API call originated from.
        /// </para>
        /// </summary>
        public ActionRemoteIpDetails RemoteIpDetails
        {
            get { return this._remoteIpDetails; }
            set { this._remoteIpDetails = value; }
        }

        // Check to see if RemoteIpDetails property is set
        internal bool IsSetRemoteIpDetails()
        {
            return this._remoteIpDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the Amazon Web Services service that the API method belongs to.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

    }
}