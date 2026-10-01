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
    /// Container for the parameters to the DeleteDataLakeNamespace operation. Enables you
    /// to programmatically delete an Amazon Web Services Supply Chain data lake namespace
    /// and its underling datasets. Developers can delete the existing namespaces for a given
    /// instance ID and namespace name.
    /// </summary>
    public partial class DeleteDataLakeNamespaceRequest : AmazonSupplyChainRequest
    {
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the namespace. Noted you cannot delete pre-defined namespace like <b>asc</b>,
        /// <b>default</b> which are only deleted through instance deletion.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
