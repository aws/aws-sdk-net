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

namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// This is the response object from the ListInvoiceUnits operation.
    /// </summary>
    public partial class ListInvoiceUnitsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property InvoiceUnits. 
        /// <para>
        ///  An invoice unit is a set of mutually exclusive accounts that correspond to your business
        /// entity. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InvoiceUnit> InvoiceUnits { get; set; } = AWSConfigs.InitializeCollections ? new List<InvoiceUnit>() : null;

        /// <summary>
        /// Checks to see if the InvoiceUnits property is set.
        /// </summary>
        internal bool IsSetInvoiceUnits() => this.InvoiceUnits != null && (this.InvoiceUnits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next token used to indicate where the returned list should start from. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
