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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
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
        private NLBResource _nlbResource;
        private R53ResourceRecord _r53Resource;

        /// <summary>
        /// Gets and sets the property NLBResource. 
        /// <para>
        /// The Network Load Balancer Resource.
        /// </para>
        /// </summary>
        public NLBResource NLBResource
        {
            get { return this._nlbResource; }
            set { this._nlbResource = value; }
        }

        // Check to see if NLBResource property is set
        internal bool IsSetNLBResource()
        {
            return this._nlbResource != null;
        }

        /// <summary>
        /// Gets and sets the property R53Resource. 
        /// <para>
        /// The Route 53 resource.
        /// </para>
        /// </summary>
        public R53ResourceRecord R53Resource
        {
            get { return this._r53Resource; }
            set { this._r53Resource = value; }
        }

        // Check to see if R53Resource property is set
        internal bool IsSetR53Resource()
        {
            return this._r53Resource != null;
        }

    }
}