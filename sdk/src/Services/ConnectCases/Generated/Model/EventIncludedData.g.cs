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
    /// Details of what case and related item data is published through the case event stream.
    /// </summary>
    public partial class EventIncludedData
    {
        /// <summary>
        /// Gets and sets the property CaseData. 
        /// <para>
        /// Details of what case data is published through the case event stream.
        /// </para>
        /// </summary>
        public CaseEventIncludedData CaseData { get; set; }

        /// <summary>
        /// Checks to see if the CaseData property is set.
        /// </summary>
        internal bool IsSetCaseData() => this.CaseData != null;

        /// <summary>
        /// Gets and sets the property RelatedItemData. 
        /// <para>
        /// Details of what related item data is published through the case event stream.
        /// </para>
        /// </summary>
        public RelatedItemEventIncludedData RelatedItemData { get; set; }

        /// <summary>
        /// Checks to see if the RelatedItemData property is set.
        /// </summary>
        internal bool IsSetRelatedItemData() => this.RelatedItemData != null;
    }
}
