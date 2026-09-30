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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteLayout operation. Deletes a layout from
    /// a cases template. You can delete up to 100 layouts per domain. <para> After a layout
    /// is deleted: </para> <ul> <li> <para> You can still retrieve the layout by calling
    /// <c>GetLayout</c>. </para> </li> <li> <para> You cannot update a deleted layout by
    /// calling <c>UpdateLayout</c>; it throws a <c>ValidationException</c>. </para> </li>
    /// <li> <para> Deleted layouts are not included in the <c>ListLayouts</c> response. </para>
    /// </li> </ul>
    /// </summary>
    public partial class DeleteLayoutRequest : AmazonConnectCasesRequest
    {
        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The unique identifier of the Cases domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property LayoutId. 
        /// <para>
        /// The unique identifier of the layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string LayoutId { get; set; }

        /// <summary>
        /// Checks to see if the LayoutId property is set.
        /// </summary>
        internal bool IsSetLayoutId() => this.LayoutId != null;
    }
}
