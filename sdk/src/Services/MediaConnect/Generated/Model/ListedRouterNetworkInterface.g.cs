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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// A summary of a router network interface, including its name, type, ARN, ID, associated
    /// input/output counts, state, and other key details. This structure is used in the response
    /// of the ListRouterNetworkInterfaces operation.
    /// </summary>
    public partial class ListedRouterNetworkInterface
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the router network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssociatedInputCount. 
        /// <para>
        /// The number of router inputs associated with the network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? AssociatedInputCount { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedInputCount property is set.
        /// </summary>
        internal bool IsSetAssociatedInputCount() => this.AssociatedInputCount.HasValue;

        /// <summary>
        /// Gets and sets the property AssociatedOutputCount. 
        /// <para>
        /// The number of router outputs associated with the network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? AssociatedOutputCount { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedOutputCount property is set.
        /// </summary>
        internal bool IsSetAssociatedOutputCount() => this.AssociatedOutputCount.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the network interface was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the router network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the router network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceType. 
        /// <para>
        /// The type of the router network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouterNetworkInterfaceType NetworkInterfaceType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceType property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceType() => this.NetworkInterfaceType != null;

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The Amazon Web Services Region where the router network interface is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegionName { get; set; }

        /// <summary>
        /// Checks to see if the RegionName property is set.
        /// </summary>
        internal bool IsSetRegionName() => this.RegionName != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the router network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouterNetworkInterfaceState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the router network interface was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
