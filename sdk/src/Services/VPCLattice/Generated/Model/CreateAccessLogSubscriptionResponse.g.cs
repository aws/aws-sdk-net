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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// This is the response object from the CreateAccessLogSubscription operation.
    /// </summary>
    public partial class CreateAccessLogSubscriptionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the access log subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the log destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string DestinationArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationArn property is set.
        /// </summary>
        internal bool IsSetDestinationArn() => this.DestinationArn != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the access log subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 21, Max = 21)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service network or service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 200)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the service network or service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 50)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ServiceNetworkLogType. 
        /// <para>
        /// The type of log that monitors your Amazon VPC Lattice service networks.
        /// </para>
        /// </summary>
        public ServiceNetworkLogType ServiceNetworkLogType { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNetworkLogType property is set.
        /// </summary>
        internal bool IsSetServiceNetworkLogType() => this.ServiceNetworkLogType != null;
    }
}
