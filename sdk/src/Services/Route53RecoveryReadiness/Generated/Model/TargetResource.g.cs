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

namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// The target resource that the Route 53 record points to.
    /// </summary>
    public partial class TargetResource
    {
        /// <summary>
        /// Gets and sets the property NLBResource. 
        /// <para>
        /// The Network Load Balancer Resource.
        /// </para>
        /// </summary>
        public NLBResource NLBResource { get; set; }

        /// <summary>
        /// Checks to see if the NLBResource property is set.
        /// </summary>
        internal bool IsSetNLBResource() => this.NLBResource != null;

        /// <summary>
        /// Gets and sets the property R53Resource. 
        /// <para>
        /// The Route 53 resource.
        /// </para>
        /// </summary>
        public R53ResourceRecord R53Resource { get; set; }

        /// <summary>
        /// Checks to see if the R53Resource property is set.
        /// </summary>
        internal bool IsSetR53Resource() => this.R53Resource != null;
    }
}
