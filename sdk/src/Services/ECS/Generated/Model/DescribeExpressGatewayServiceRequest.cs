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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeExpressGatewayService operation.
    /// Retrieves detailed information about an Express service, including current status,
    /// configuration, managed infrastructure, and service revisions.
    /// 
    ///  
    /// <para>
    /// Returns comprehensive service details, active service revisions, ingress paths with
    /// endpoints, and managed Amazon Web Services resource status including load balancers
    /// and auto-scaling policies.
    /// </para>
    ///  
    /// <para>
    /// Use the <c>include</c> parameter to retrieve additional information such as resource
    /// tags.
    /// </para>
    /// </summary>
    public partial class DescribeExpressGatewayServiceRequest : AmazonECSRequest
    {
        private List<string> _include = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _serviceArn;

        /// <summary>
        /// Gets and sets the property Include. 
        /// <para>
        /// Specifies additional information to include in the response. Valid values are <c>TAGS</c>
        /// to include resource tags associated with the Express service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Include
        {
            get { return this._include; }
            set { this._include = value; }
        }

        // Check to see if Include property is set
        internal bool IsSetInclude()
        {
            return this._include != null && (this._include.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Express service to describe. The ARN uniquely
        /// identifies the service within your Amazon Web Services account and region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

    }
}