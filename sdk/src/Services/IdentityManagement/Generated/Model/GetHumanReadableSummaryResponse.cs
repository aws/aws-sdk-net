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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
        private string _locale;
        private string _summaryContent;
        private SummaryStateType _summaryState;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale that this response was generated for. This maps to the input locale.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=12)]
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property SummaryContent. 
        /// <para>
        /// Summary content in the specified locale. Summary content is non-empty only if the
        /// <c>SummaryState</c> is <c>AVAILABLE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public string SummaryContent
        {
            get { return this._summaryContent; }
            set { this._summaryContent = value; }
        }

        // Check to see if SummaryContent property is set
        internal bool IsSetSummaryContent()
        {
            return this._summaryContent != null;
        }

        /// <summary>
        /// Gets and sets the property SummaryState. 
        /// <para>
        /// State of summary generation. This generation process is asynchronous and this attribute
        /// indicates the state of the generation process.
        /// </para>
        /// </summary>
        public SummaryStateType SummaryState
        {
            get { return this._summaryState; }
            set { this._summaryState = value; }
        }

        // Check to see if SummaryState property is set
        internal bool IsSetSummaryState()
        {
            return this._summaryState != null;
        }

    }
}