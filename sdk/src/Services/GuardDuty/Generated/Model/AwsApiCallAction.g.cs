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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AffectedResources. 
        /// <para>
        /// The details of the Amazon Web Services account that made the API call. This field
        /// identifies the resources that were affected by this API call.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AffectedResources { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AffectedResources property is set.
        /// </summary>
        internal bool IsSetAffectedResources() => this.AffectedResources != null && (this.AffectedResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Api. 
        /// <para>
        /// The Amazon Web Services API name.
        /// </para>
        /// </summary>
        public string Api { get; set; }

        /// <summary>
        /// Checks to see if the Api property is set.
        /// </summary>
        internal bool IsSetApi() => this.Api != null;

        /// <summary>
        /// Gets and sets the property CallerType. 
        /// <para>
        /// The Amazon Web Services API caller type.
        /// </para>
        /// </summary>
        public string CallerType { get; set; }

        /// <summary>
        /// Checks to see if the CallerType property is set.
        /// </summary>
        internal bool IsSetCallerType() => this.CallerType != null;

        /// <summary>
        /// Gets and sets the property DomainDetails. 
        /// <para>
        /// The domain information for the Amazon Web Services API call.
        /// </para>
        /// </summary>
        public DomainDetails DomainDetails { get; set; }

        /// <summary>
        /// Checks to see if the DomainDetails property is set.
        /// </summary>
        internal bool IsSetDomainDetails() => this.DomainDetails != null;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code of the failed Amazon Web Services API action.
        /// </para>
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property RemoteAccountDetails. 
        /// <para>
        /// The details of the Amazon Web Services account that made the API call. This field
        /// appears if the call was made from outside your account.
        /// </para>
        /// </summary>
        public RemoteAccountDetails RemoteAccountDetails { get; set; }

        /// <summary>
        /// Checks to see if the RemoteAccountDetails property is set.
        /// </summary>
        internal bool IsSetRemoteAccountDetails() => this.RemoteAccountDetails != null;

        /// <summary>
        /// Gets and sets the property RemoteIpDetails. 
        /// <para>
        /// The remote IP information of the connection that initiated the Amazon Web Services
        /// API call.
        /// </para>
        /// </summary>
        public RemoteIpDetails RemoteIpDetails { get; set; }

        /// <summary>
        /// Checks to see if the RemoteIpDetails property is set.
        /// </summary>
        internal bool IsSetRemoteIpDetails() => this.RemoteIpDetails != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The Amazon Web Services service name whose API was invoked.
        /// </para>
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property UserAgent. 
        /// <para>
        /// The agent through which the API request was made.
        /// </para>
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// Checks to see if the UserAgent property is set.
        /// </summary>
        internal bool IsSetUserAgent() => this.UserAgent != null;
    }
}
