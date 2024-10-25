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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
    /// Container for the parameters to the UpdateInstance operation.
    /// Enables you to programmatically update an Amazon Web Services Supply Chain instance
    /// description by providing all the relevant information such as account ID, instance
    /// ID and so on without using the AWS console.
    /// </summary>
    public partial class UpdateInstanceRequest : AmazonSupplyChainRequest
    {
        private string _instanceDescription;
        private string _instanceId;
        private string _instanceName;

        /// <summary>
        /// Gets and sets the property InstanceDescription. 
        /// <para>
        /// The AWS Supply Chain instance description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=501)]
        public string InstanceDescription
        {
            get { return this._instanceDescription; }
            set { this._instanceDescription = value; }
        }

        // Check to see if InstanceDescription property is set
        internal bool IsSetInstanceDescription()
        {
            return this._instanceDescription != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The AWS Supply Chain instance identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The AWS Supply Chain instance name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

    }
}