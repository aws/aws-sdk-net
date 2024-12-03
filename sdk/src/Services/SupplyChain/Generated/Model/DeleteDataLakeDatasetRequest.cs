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
    /// Container for the parameters to the DeleteDataLakeDataset operation.
    /// Enables you to programmatically delete an Amazon Web Services Supply Chain data lake
    /// dataset. Developers can delete the existing datasets for a given instance ID, namespace,
    /// and instance name.
    /// </summary>
    public partial class DeleteDataLakeDatasetRequest : AmazonSupplyChainRequest
    {
        private string _instanceId;
        private string _name;
        private string _awsNamespace;

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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the dataset. If the namespace is <i>asc</i>, the name must be one of the
        /// supported <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/data-model-asc.html">data
        /// entities </a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=75)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the dataset. The available values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// asc: for <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/data-model-asc.html">
        /// AWS Supply Chain supported datasets </a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// default: for datasets with custom user-defined schemas.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

    }
}