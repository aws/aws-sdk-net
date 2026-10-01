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

namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateInstance operation. Enables you to programmatically
    /// update an Amazon Web Services Supply Chain instance description by providing all the
    /// relevant information such as account ID, instance ID and so on without using the AWS
    /// console.
    /// </summary>
    public partial class UpdateInstanceRequest : AmazonSupplyChainRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceDescription. 
        /// <para>
        /// The AWS Supply Chain instance description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 501)]
        public string InstanceDescription { get; set; }

        /// <summary>
        /// Checks to see if the InstanceDescription property is set.
        /// </summary>
        internal bool IsSetInstanceDescription() => this.InstanceDescription != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The AWS Supply Chain instance identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The AWS Supply Chain instance name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceName property is set.
        /// </summary>
        internal bool IsSetInstanceName() => this.InstanceName != null;
    }
}
