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

namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Configures private DNS name settings for WorkSpace Instance.
    /// </summary>
    public partial class PrivateDnsNameOptionsRequest
    {
        /// <summary>
        /// Gets and sets the property EnableResourceNameDnsAAAARecord. 
        /// <para>
        /// Enables DNS AAAA record for resource name resolution.
        /// </para>
        /// </summary>
        public bool? EnableResourceNameDnsAAAARecord { get; set; }

        /// <summary>
        /// Checks to see if the EnableResourceNameDnsAAAARecord property is set.
        /// </summary>
        internal bool IsSetEnableResourceNameDnsAAAARecord() => this.EnableResourceNameDnsAAAARecord.HasValue;

        /// <summary>
        /// Gets and sets the property EnableResourceNameDnsARecord. 
        /// <para>
        /// Enables DNS A record for resource name resolution.
        /// </para>
        /// </summary>
        public bool? EnableResourceNameDnsARecord { get; set; }

        /// <summary>
        /// Checks to see if the EnableResourceNameDnsARecord property is set.
        /// </summary>
        internal bool IsSetEnableResourceNameDnsARecord() => this.EnableResourceNameDnsARecord.HasValue;

        /// <summary>
        /// Gets and sets the property HostnameType. 
        /// <para>
        /// Specifies the type of hostname configuration.
        /// </para>
        /// </summary>
        public HostnameTypeEnum HostnameType { get; set; }

        /// <summary>
        /// Checks to see if the HostnameType property is set.
        /// </summary>
        internal bool IsSetHostnameType() => this.HostnameType != null;
    }
}
