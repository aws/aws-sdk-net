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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeCases operation. Returns a list of cases
    /// that you specify by passing one or more case IDs. You can use the <c>afterTime</c>
    /// and <c>beforeTime</c> parameters to filter the cases by date. You can set values for
    /// the <c>includeResolvedCases</c> and <c>includeCommunications</c> parameters to specify
    /// how much information to return. <para> The response returns the following in JSON
    /// format: </para> <ul> <li> <para> One or more <a href="https://docs.aws.amazon.com/awssupport/latest/APIReference/API_CaseDetails.html">CaseDetails</a>
    /// data types. </para> </li> <li> <para> One or more <c>nextToken</c> values, which specify
    /// where to paginate the returned records represented by the <c>CaseDetails</c> objects.
    /// </para> </li> </ul> <para> Case data is available for 24 months after creation. If
    /// a case was created more than 24 months ago, a request might return an error. </para>
    /// <note> <ul> <li> <para> You must have an Amazon Web Services Business Support+, Amazon
    /// Web Services Enterprise Support, or Amazon Web Services Unified Operations plan to
    /// use the Amazon Web Services Support API. If you're in an Amazon Web Services Region
    /// that doesn't offer one of these Amazon Web Services Support plans, or if you haven't
    /// transitioned to one of these plans, you can use the Amazon Web Services Support API
    /// with a Business, Enterprise On-Ramp, or Enterprise Support plan. </para> </li> <li>
    /// <para> If you call the Amazon Web Services Support API from an account that doesn't
    /// have an Amazon Web Services Business Support+, Amazon Web Services Enterprise Support,
    /// or Amazon Web Services Unified Operations plan, the <c>SubscriptionRequiredException</c>
    /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
    /// Web Services Support</a>. </para> </li> </ul> </note> <important> <para> Each <a>Communication</a>
    /// returned by this operation includes attachment information in two fields: </para>
    /// <ul> <li> <para> <c>attachmentSet</c>: returns only attachments that are 5 MB or smaller.
    /// Attachments larger than 5 MB are not included in this field. </para> </li> <li> <para>
    /// <c>attachments</c>: returns all attachments regardless of size. </para> </li> </ul>
    /// <para> Amazon Web Services recommends that you use the <c>attachments</c> field and
    /// download each attachment with <a>GetAttachmentDownloadLink</a>, which supports attachments
    /// of any size. The <c>attachmentSet</c> field and <a>DescribeAttachment</a> return only
    /// attachments that are 5 MB or smaller. </para> </important>
    /// </summary>
    public partial class DescribeCasesRequest : AmazonAWSSupportRequest
    {
        /// <summary>
        /// Gets and sets the property AfterTime. 
        /// <para>
        /// The start date for a filtered date search on support case communications. Case communications
        /// are available for 24 months after creation.
        /// </para>
        /// </summary>
        public string AfterTime { get; set; }

        /// <summary>
        /// Checks to see if the AfterTime property is set.
        /// </summary>
        internal bool IsSetAfterTime() => this.AfterTime != null;

        /// <summary>
        /// Gets and sets the property BeforeTime. 
        /// <para>
        /// The end date for a filtered date search on support case communications. Case communications
        /// are available for 24 months after creation.
        /// </para>
        /// </summary>
        public string BeforeTime { get; set; }

        /// <summary>
        /// Checks to see if the BeforeTime property is set.
        /// </summary>
        internal bool IsSetBeforeTime() => this.BeforeTime != null;

        /// <summary>
        /// Gets and sets the property CaseIdList. 
        /// <para>
        /// A list of ID numbers of the support cases you want returned. The maximum number of
        /// cases is 100.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> CaseIdList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CaseIdList property is set.
        /// </summary>
        internal bool IsSetCaseIdList() => this.CaseIdList != null && (this.CaseIdList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DisplayId. 
        /// <para>
        /// The ID displayed for a case in the Amazon Web Services Support Center user interface.
        /// </para>
        /// </summary>
        public string DisplayId { get; set; }

        /// <summary>
        /// Checks to see if the DisplayId property is set.
        /// </summary>
        internal bool IsSetDisplayId() => this.DisplayId != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Specifies whether to validate the request without actually returning case data. When
        /// set to <c>true</c>, the request is validated but no cases are returned, and the operation
        /// returns a <c>DryRunOperationException</c>. When omitted or set to <c>false</c>, the
        /// request runs normally.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeCommunications. 
        /// <para>
        /// Specifies whether to include communications in the <c>DescribeCases</c> response.
        /// By default, communications are included.
        /// </para>
        /// </summary>
        public bool? IncludeCommunications { get; set; }

        /// <summary>
        /// Checks to see if the IncludeCommunications property is set.
        /// </summary>
        internal bool IsSetIncludeCommunications() => this.IncludeCommunications.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeResolvedCases. 
        /// <para>
        /// Specifies whether to include resolved support cases in the <c>DescribeCases</c> response.
        /// By default, resolved cases aren't included.
        /// </para>
        /// </summary>
        public bool? IncludeResolvedCases { get; set; }

        /// <summary>
        /// Checks to see if the IncludeResolvedCases property is set.
        /// </summary>
        internal bool IsSetIncludeResolvedCases() => this.IncludeResolvedCases.HasValue;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language in which Amazon Web Services Support handles the case. Amazon Web Services
        /// Support currently supports Chinese (“zh”), English ("en"), Japanese ("ja") , Chinese
        /// ("zh"), Spanish ("es"), Portuguese ("pt"), French ("fr"), Korean (“ko”), and Turkish
        /// ("tr"). You must specify the ISO 639-1 code for the <c>language</c> parameter if you
        /// want support in that language.
        /// </para>
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return before paginating.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A resumption point for pagination.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
