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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about the AWS_API_CALL action described in this finding.
    /// </summary>
    public partial class AwsApiCallAction
    {
        private string _api;
        private string _callerType;
        private DomainDetails _domainDetails;
        private RemoteIpDetails _remoteIpDetails;
        private string _serviceName;

        /// <summary>
        /// Gets and sets the property Api. AWS API name.
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
        /// Gets and sets the property CallerType. AWS API caller type.
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
        /// Gets and sets the property DomainDetails. Domain information for the AWS API call.
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
        /// Gets and sets the property RemoteIpDetails. Remote IP information of the connection.
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
        /// Gets and sets the property ServiceName. AWS service name whose API was invoked.
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