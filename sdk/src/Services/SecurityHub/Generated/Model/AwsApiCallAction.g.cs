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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provided if <c>ActionType</c> is <c>AWS_API_CALL</c>. It provides details about the
    /// API call that was detected.
    /// </summary>
    public partial class AwsApiCallAction
    {
        /// <summary>
        /// Gets and sets the property AffectedResources. 
        /// <para>
        /// Identifies the resources that were affected by the API call.
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
        /// The name of the API method that was issued.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: 128.
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
        /// Indicates whether the API call originated from a remote IP address (<c>remoteip</c>)
        /// or from a DNS domain (<c>domain</c>).
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
        /// Provided if <c>CallerType</c> is <c>domain</c>. Provides information about the DNS
        /// domain that the API call originated from.
        /// </para>
        /// </summary>
        public AwsApiCallActionDomainDetails DomainDetails { get; set; }

        /// <summary>
        /// Checks to see if the DomainDetails property is set.
        /// </summary>
        internal bool IsSetDomainDetails() => this.DomainDetails != null;

        /// <summary>
        /// Gets and sets the property FirstSeen. 
        /// <para>
        /// A timestamp that indicates when the API call was first observed.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string FirstSeen { get; set; }

        /// <summary>
        /// Checks to see if the FirstSeen property is set.
        /// </summary>
        internal bool IsSetFirstSeen() => this.FirstSeen != null;

        /// <summary>
        /// Gets and sets the property LastSeen. 
        /// <para>
        /// A timestamp that indicates when the API call was most recently observed.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string LastSeen { get; set; }

        /// <summary>
        /// Checks to see if the LastSeen property is set.
        /// </summary>
        internal bool IsSetLastSeen() => this.LastSeen != null;

        /// <summary>
        /// Gets and sets the property RemoteIpDetails. 
        /// <para>
        /// Provided if <c>CallerType</c> is <c>remoteip</c>. Provides information about the remote
        /// IP address that the API call originated from.
        /// </para>
        /// </summary>
        public ActionRemoteIpDetails RemoteIpDetails { get; set; }

        /// <summary>
        /// Checks to see if the RemoteIpDetails property is set.
        /// </summary>
        internal bool IsSetRemoteIpDetails() => this.RemoteIpDetails != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the Amazon Web Services service that the API method belongs to.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: 128.
        /// </para>
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;
    }
}
