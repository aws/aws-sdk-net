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

namespace Amazon.CodeStarconnections.Model
{
    /// <summary>
    /// This is the response object from the GetHost operation.
    /// </summary>
    public partial class GetHostResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the requested host.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProviderEndpoint. 
        /// <para>
        /// The endpoint of the infrastructure represented by the requested host.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ProviderEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ProviderEndpoint property is set.
        /// </summary>
        internal bool IsSetProviderEndpoint() => this.ProviderEndpoint != null;

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The provider type of the requested host, such as GitHub Enterprise Server.
        /// </para>
        /// </summary>
        public ProviderType ProviderType { get; set; }

        /// <summary>
        /// Checks to see if the ProviderType property is set.
        /// </summary>
        internal bool IsSetProviderType() => this.ProviderType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the requested host.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// The VPC configuration of the requested host.
        /// </para>
        /// </summary>
        public VpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcConfiguration() => this.VpcConfiguration != null;
    }
}
