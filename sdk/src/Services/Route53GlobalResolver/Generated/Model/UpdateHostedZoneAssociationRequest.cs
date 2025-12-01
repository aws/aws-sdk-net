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
 * Do not modify this file. This file is generated from the route53globalresolver-2022-09-27.normal.json service model.
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
namespace Amazon.Route53GlobalResolver.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateHostedZoneAssociation operation.
    /// Updates the configuration of a hosted zone association.
    /// </summary>
    public partial class UpdateHostedZoneAssociationRequest : AmazonRoute53GlobalResolverRequest
    {
        private string _hostedZoneAssociationId;
        private string _name;

        /// <summary>
        /// Gets and sets the property HostedZoneAssociationId. 
        /// <para>
        /// The ID of the private hosted zone association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string HostedZoneAssociationId
        {
            get { return this._hostedZoneAssociationId; }
            set { this._hostedZoneAssociationId = value; }
        }

        // Check to see if HostedZoneAssociationId property is set
        internal bool IsSetHostedZoneAssociationId()
        {
            return this._hostedZoneAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name you want to update the hosted zone association to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}