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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the Lightsail subdomain of a distribution. The distribution is reachable
    /// at the subdomain's web address, which is the subdomain followed by <c>amazonlightsail.com</c>.
    /// </summary>
    public partial class LightsailDistributionSubdomain
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code that describes why the subdomain is in the <c>Error</c> state.
        /// </para>
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// The details of the error that caused the subdomain to be in the <c>Error</c> state.
        /// </para>
        /// </summary>
        public string ErrorDetails { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetails property is set.
        /// </summary>
        internal bool IsSetErrorDetails() => this.ErrorDetails != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The subdomain (for example, <c>mysite</c>), not its web address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the subdomain for the distribution.
        /// </para>
        ///  
        /// <para>
        /// The following states are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Creating</c> – The subdomain is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Attaching</c> – The subdomain is being associated with the distribution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Attached</c> – The subdomain is associated with the distribution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Error</c> – The subdomain couldn't be created or associated with the distribution.
        /// For more information, see the <c>errorCode</c> and <c>errorDetails</c> parameters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public LightsailDistributionSubdomainStateEnum State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
