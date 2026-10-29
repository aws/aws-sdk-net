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
    /// Container for the parameters to the DisassociateOpsItemRelatedItem operation. Deletes
    /// the association between an OpsItem and a related item. For example, this API operation
    /// can delete an Incident Manager incident from an OpsItem. Incident Manager is a tool
    /// in Amazon Web Services Systems Manager.
    /// </summary>
    public partial class DisassociateOpsItemRelatedItemRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the association for which you want to delete an association between the
        /// OpsItem and a related item.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property OpsItemId. 
        /// <para>
        /// The ID of the OpsItem for which you want to delete an association between the OpsItem
        /// and a related item.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OpsItemId { get; set; }

        /// <summary>
        /// Checks to see if the OpsItemId property is set.
        /// </summary>
        internal bool IsSetOpsItemId() => this.OpsItemId != null;
    }
}
