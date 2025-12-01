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
    /// Container for the parameters to the UpdateGlobalResolver operation.
    /// Updates the configuration of a Route 53 Global Resolver instance. You can modify the
    /// name, description, and observability region.
    /// </summary>
    public partial class UpdateGlobalResolverRequest : AmazonRoute53GlobalResolverRequest
    {
        private string _description;
        private string _globalResolverId;
        private string _name;
        private string _observabilityRegion;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the Global Resolver.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalResolverId. 
        /// <para>
        /// The ID of the Global Resolver.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string GlobalResolverId
        {
            get { return this._globalResolverId; }
            set { this._globalResolverId = value; }
        }

        // Check to see if GlobalResolverId property is set
        internal bool IsSetGlobalResolverId()
        {
            return this._globalResolverId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Global Resolver.
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

        /// <summary>
        /// Gets and sets the property ObservabilityRegion. 
        /// <para>
        /// The AWS Regions in which the users' Global Resolver query resolution logs will be
        /// propagated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public string ObservabilityRegion
        {
            get { return this._observabilityRegion; }
            set { this._observabilityRegion = value; }
        }

        // Check to see if ObservabilityRegion property is set
        internal bool IsSetObservabilityRegion()
        {
            return this._observabilityRegion != null;
        }

    }
}