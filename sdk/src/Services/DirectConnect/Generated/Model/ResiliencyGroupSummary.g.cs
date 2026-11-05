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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Summary information about a resiliency group.
    /// </summary>
    public partial class ResiliencyGroupSummary
    {
        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the resiliency group.
        /// </para>
        /// </summary>
        public string OwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccount property is set.
        /// </summary>
        internal bool IsSetOwnerAccount() => this.OwnerAccount != null;

        /// <summary>
        /// Gets and sets the property ResiliencyGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resiliency group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ResiliencyGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the ResiliencyGroupArn property is set.
        /// </summary>
        internal bool IsSetResiliencyGroupArn() => this.ResiliencyGroupArn != null;

        /// <summary>
        /// Gets and sets the property ResiliencyGroupId. 
        /// <para>
        /// The ID of the resiliency group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string ResiliencyGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ResiliencyGroupId property is set.
        /// </summary>
        internal bool IsSetResiliencyGroupId() => this.ResiliencyGroupId != null;

        /// <summary>
        /// Gets and sets the property ResiliencyGroupName. 
        /// <para>
        /// The name of the resiliency group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ResiliencyGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ResiliencyGroupName property is set.
        /// </summary>
        internal bool IsSetResiliencyGroupName() => this.ResiliencyGroupName != null;

        /// <summary>
        /// Gets and sets the property ResiliencyGroupType. 
        /// <para>
        /// The type of the resiliency group. The valid value is <c>Managed</c>.
        /// </para>
        /// </summary>
        public ResiliencyGroupType ResiliencyGroupType { get; set; }

        /// <summary>
        /// Checks to see if the ResiliencyGroupType property is set.
        /// </summary>
        internal bool IsSetResiliencyGroupType() => this.ResiliencyGroupType != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the resiliency group.
        /// </para>
        /// </summary>
        public ResiliencyGroupState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
