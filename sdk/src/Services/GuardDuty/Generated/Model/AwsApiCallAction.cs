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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the API action.
    /// </summary>
    public partial class AwsApiCallAction
    {
        private Dictionary<string, string> _affectedResources = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _api;
        private string _callerType;
        private DomainDetails _domainDetails;
        private string _errorCode;
        private RemoteAccountDetails _remoteAccountDetails;
        private RemoteIpDetails _remoteIpDetails;
        private string _serviceName;
        private string _userAgent;

        /// <summary>
        /// Gets and sets the property AffectedResources. 
        /// <para>
        /// The details of the Amazon Web Services account that made the API call. This field
        /// identifies the resources that were affected by this API call.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AffectedResources
        {
            get { return this._affectedResources; }
            set { this._affectedResources = value; }
        }

        // Check to see if AffectedResources property is set
        internal bool IsSetAffectedResources()
        {
            return this._affectedResources != null && (this._affectedResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Api. 
        /// <para>
        /// The Amazon Web Services API name.
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
        /// The Amazon Web Services API caller type.
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
        /// The domain information for the Amazon Web Services API call.
        /// </para>
        /// </summary>
        public DomainDetails DomainDetails
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
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code of the failed Amazon Web Services API action.
        /// </para>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteAccountDetails. 
        /// <para>
        /// The details of the Amazon Web Services account that made the API call. This field
        /// appears if the call was made from outside your account.
        /// </para>
        /// </summary>
        public RemoteAccountDetails RemoteAccountDetails
        {
            get { return this._remoteAccountDetails; }
            set { this._remoteAccountDetails = value; }
        }

        // Check to see if RemoteAccountDetails property is set
        internal bool IsSetRemoteAccountDetails()
        {
            return this._remoteAccountDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteIpDetails. 
        /// <para>
        /// The remote IP information of the connection that initiated the Amazon Web Services
        /// API call.
        /// </para>
        /// </summary>
        public RemoteIpDetails RemoteIpDetails
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
        /// The Amazon Web Services service name whose API was invoked.
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

        /// <summary>
        /// Gets and sets the property UserAgent. 
        /// <para>
        /// The agent through which the API request was made.
        /// </para>
        /// </summary>
        public string UserAgent
        {
            get { return this._userAgent; }
            set { this._userAgent = value; }
        }

        // Check to see if UserAgent property is set
        internal bool IsSetUserAgent()
        {
            return this._userAgent != null;
        }

    }
}