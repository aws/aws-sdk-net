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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// This is the response object from the GetHumanReadableSummary operation.
    /// </summary>
    public partial class GetHumanReadableSummaryResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale that this response was generated for. This maps to the input locale.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 12)]
        public string Locale { get; set; }

        /// <summary>
        /// Checks to see if the Locale property is set.
        /// </summary>
        internal bool IsSetLocale() => this.Locale != null;

        /// <summary>
        /// Gets and sets the property SummaryContent. 
        /// <para>
        /// Summary content in the specified locale. Summary content is non-empty only if the
        /// <c>SummaryState</c> is <c>AVAILABLE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string SummaryContent { get; set; }

        /// <summary>
        /// Checks to see if the SummaryContent property is set.
        /// </summary>
        internal bool IsSetSummaryContent() => this.SummaryContent != null;

        /// <summary>
        /// Gets and sets the property SummaryState. 
        /// <para>
        /// State of summary generation. This generation process is asynchronous and this attribute
        /// indicates the state of the generation process.
        /// </para>
        /// </summary>
        public SummaryStateType SummaryState { get; set; }

        /// <summary>
        /// Checks to see if the SummaryState property is set.
        /// </summary>
        internal bool IsSetSummaryState() => this.SummaryState != null;
    }
}
