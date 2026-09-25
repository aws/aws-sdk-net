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

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// This is the response object from the BatchDisassociateResourcesFromCustomLineItem
    /// operation.
    /// </summary>
    public partial class BatchDisassociateResourcesFromCustomLineItemResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FailedDisassociatedResources. 
        /// <para>
        ///  A list of <c>DisassociateResourceResponseElement</c> for each resource that failed
        /// disassociation from a percentage custom line item. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DisassociateResourceResponseElement> FailedDisassociatedResources { get; set; } = AWSConfigs.InitializeCollections ? new List<DisassociateResourceResponseElement>() : null;

        /// <summary>
        /// Checks to see if the FailedDisassociatedResources property is set.
        /// </summary>
        internal bool IsSetFailedDisassociatedResources() => this.FailedDisassociatedResources != null && (this.FailedDisassociatedResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SuccessfullyDisassociatedResources. 
        /// <para>
        ///  A list of <c>DisassociateResourceResponseElement</c> for each resource that's been
        /// disassociated from a percentage custom line item successfully. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DisassociateResourceResponseElement> SuccessfullyDisassociatedResources { get; set; } = AWSConfigs.InitializeCollections ? new List<DisassociateResourceResponseElement>() : null;

        /// <summary>
        /// Checks to see if the SuccessfullyDisassociatedResources property is set.
        /// </summary>
        internal bool IsSetSuccessfullyDisassociatedResources() => this.SuccessfullyDisassociatedResources != null && (this.SuccessfullyDisassociatedResources.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
