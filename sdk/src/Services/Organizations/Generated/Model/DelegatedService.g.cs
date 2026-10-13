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

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Contains information about the Amazon Web Services service for which the account is
    /// a delegated administrator.
    /// </summary>
    public partial class DelegatedService
    {
        /// <summary>
        /// Gets and sets the property DelegationEnabledDate. 
        /// <para>
        /// The date that the account became a delegated administrator for this service. 
        /// </para>
        /// </summary>
        public DateTime? DelegationEnabledDate { get; set; }

        /// <summary>
        /// Checks to see if the DelegationEnabledDate property is set.
        /// </summary>
        internal bool IsSetDelegationEnabledDate() => this.DelegationEnabledDate.HasValue;

        /// <summary>
        /// Gets and sets the property ServicePrincipal. 
        /// <para>
        /// The name of an Amazon Web Services service that can request an operation for the specified
        /// service. This is typically in the form of a URL, such as: <c> <i>servicename</i>.amazonaws.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ServicePrincipal { get; set; }

        /// <summary>
        /// Checks to see if the ServicePrincipal property is set.
        /// </summary>
        internal bool IsSetServicePrincipal() => this.ServicePrincipal != null;
    }
}
