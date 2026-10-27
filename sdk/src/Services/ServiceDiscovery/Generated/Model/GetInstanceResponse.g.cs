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

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// This is the response object from the GetInstance operation.
    /// </summary>
    public partial class GetInstanceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Instance. 
        /// <para>
        /// A complex type that contains information about a specified instance.
        /// </para>
        /// </summary>
        public Instance Instance { get; set; }

        /// <summary>
        /// Checks to see if the Instance property is set.
        /// </summary>
        internal bool IsSetInstance() => this.Instance != null;

        /// <summary>
        /// Gets and sets the property ResourceOwner. 
        /// <para>
        /// The ID of the Amazon Web Services account that created the namespace that contains
        /// the service that the instance is associated with. If this isn't your account ID, it's
        /// the ID of the account that shared the namespace with your account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string ResourceOwner { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwner property is set.
        /// </summary>
        internal bool IsSetResourceOwner() => this.ResourceOwner != null;
    }
}
