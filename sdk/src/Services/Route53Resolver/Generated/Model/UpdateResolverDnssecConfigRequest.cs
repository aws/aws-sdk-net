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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResolverDnssecConfig operation.
    /// Updates an existing DNSSEC validation configuration. If there is no existing DNSSEC
    /// validation configuration, one is created.
    /// </summary>
    public partial class UpdateResolverDnssecConfigRequest : AmazonRoute53ResolverRequest
    {
        private string _resourceId;
        private Validation _validation;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the virtual private cloud (VPC) that you're updating the DNSSEC validation
        /// status for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Validation. 
        /// <para>
        /// The new value that you are specifying for DNSSEC validation for the VPC. The value
        /// can be <code>ENABLE</code> or <code>DISABLE</code>. Be aware that it can take time
        /// for a validation status change to be completed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Validation Validation
        {
            get { return this._validation; }
            set { this._validation = value; }
        }

        // Check to see if Validation property is set
        internal bool IsSetValidation()
        {
            return this._validation != null;
        }

    }
}