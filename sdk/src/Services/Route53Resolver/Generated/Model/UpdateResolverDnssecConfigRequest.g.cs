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

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResolverDnssecConfig operation. Updates
    /// an existing DNSSEC validation configuration. If there is no existing DNSSEC validation
    /// configuration, one is created.
    /// </summary>
    public partial class UpdateResolverDnssecConfigRequest : AmazonRoute53ResolverRequest
    {
        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the virtual private cloud (VPC) that you're updating the DNSSEC validation
        /// status for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property Validation. 
        /// <para>
        /// The new value that you are specifying for DNSSEC validation for the VPC. The value
        /// can be <c>ENABLE</c> or <c>DISABLE</c>. Be aware that it can take time for a validation
        /// status change to be completed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Validation Validation { get; set; }

        /// <summary>
        /// Checks to see if the Validation property is set.
        /// </summary>
        internal bool IsSetValidation() => this.Validation != null;
    }
}
