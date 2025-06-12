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
    /// The resource element of a resource set.
    /// </summary>
    public partial class Resource
    {
        private string _componentId;
        private DNSTargetResource _dnsTargetResource;
        private List<string> _readinessScopes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ComponentId. 
        /// <para>
        /// The component identifier of the resource, generated when DNS target resource is used.
        /// </para>
        /// </summary>
        public string ComponentId
        {
            get { return this._componentId; }
            set { this._componentId = value; }
        }

        // Check to see if ComponentId property is set
        internal bool IsSetComponentId()
        {
            return this._componentId != null;
        }

        /// <summary>
        /// Gets and sets the property DnsTargetResource. 
        /// <para>
        /// The DNS target resource.
        /// </para>
        /// </summary>
        public DNSTargetResource DnsTargetResource
        {
            get { return this._dnsTargetResource; }
            set { this._dnsTargetResource = value; }
        }

        // Check to see if DnsTargetResource property is set
        internal bool IsSetDnsTargetResource()
        {
            return this._dnsTargetResource != null;
        }

        /// <summary>
        /// Gets and sets the property ReadinessScopes. 
        /// <para>
        /// A list of recovery group Amazon Resource Names (ARNs) and cell ARNs that this resource
        /// is contained within.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReadinessScopes
        {
            get { return this._readinessScopes; }
            set { this._readinessScopes = value; }
        }

        // Check to see if ReadinessScopes property is set
        internal bool IsSetReadinessScopes()
        {
            return this._readinessScopes != null && (this._readinessScopes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services resource.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}