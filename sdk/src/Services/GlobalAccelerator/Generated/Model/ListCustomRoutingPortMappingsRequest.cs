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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
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
namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Container for the parameters to the ListCustomRoutingPortMappings operation.
    /// Provides a complete mapping from the public accelerator IP address and port to destination
    /// EC2 instance IP addresses and ports in the virtual public cloud (VPC) subnet endpoint
    /// for a custom routing accelerator. For each subnet endpoint that you add, Global Accelerator
    /// creates a new static port mapping for the accelerator. The port mappings don't change
    /// after Global Accelerator generates them, so you can retrieve and cache the full mapping
    /// on your servers. 
    /// 
    ///  
    /// <para>
    /// If you remove a subnet from your accelerator, Global Accelerator removes (reclaims)
    /// the port mappings. If you add a subnet to your accelerator, Global Accelerator creates
    /// new port mappings (the existing ones don't change). If you add or remove EC2 instances
    /// in your subnet, the port mappings don't change, because the mappings are created when
    /// you add the subnet to Global Accelerator.
    /// </para>
    ///  
    /// <para>
    /// The mappings also include a flag for each destination denoting which destination IP
    /// addresses and ports are allowed or denied traffic.
    /// </para>
    /// </summary>
    public partial class ListCustomRoutingPortMappingsRequest : AmazonGlobalAcceleratorRequest
    {
        private string _acceleratorArn;
        private string _endpointGroupArn;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AcceleratorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the accelerator to list the custom routing port
        /// mappings for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string AcceleratorArn
        {
            get { return this._acceleratorArn; }
            set { this._acceleratorArn = value; }
        }

        // Check to see if AcceleratorArn property is set
        internal bool IsSetAcceleratorArn()
        {
            return this._acceleratorArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint group to list the custom routing port
        /// mappings for.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string EndpointGroupArn
        {
            get { return this._endpointGroupArn; }
            set { this._endpointGroupArn = value; }
        }

        // Check to see if EndpointGroupArn property is set
        internal bool IsSetEndpointGroupArn()
        {
            return this._endpointGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of destination port mappings that you want to return with this call. The
        /// default value is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. You receive this token from a previous call.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}