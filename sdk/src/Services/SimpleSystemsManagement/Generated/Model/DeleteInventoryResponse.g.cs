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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the DeleteInventory operation.
    /// </summary>
    public partial class DeleteInventoryResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DeletionId. 
        /// <para>
        /// Every <c>DeleteInventory</c> operation is assigned a unique ID. This option returns
        /// a unique ID. You can use this ID to query the status of a delete operation. This option
        /// is useful for ensuring that a delete operation has completed before you begin other
        /// operations. 
        /// </para>
        /// </summary>
        public string DeletionId { get; set; }

        /// <summary>
        /// Checks to see if the DeletionId property is set.
        /// </summary>
        internal bool IsSetDeletionId() => this.DeletionId != null;

        /// <summary>
        /// Gets and sets the property DeletionSummary. 
        /// <para>
        /// A summary of the delete operation. For more information about this summary, see <a
        /// href="https://docs.aws.amazon.com/systems-manager/latest/userguide/inventory-custom.html#delete-custom-inventory-summary">Deleting
        /// custom inventory</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        public InventoryDeletionSummary DeletionSummary { get; set; }

        /// <summary>
        /// Checks to see if the DeletionSummary property is set.
        /// </summary>
        internal bool IsSetDeletionSummary() => this.DeletionSummary != null;

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the inventory data type specified in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;
    }
}
