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
    /// Container for the parameters to the StartMergeCases operation. Merges a secondary
    /// case into a primary case. The primary case, which you specify in the request URI,
    /// remains active. Both cases must belong to the same domain. <para> The merge runs asynchronously.
    /// To track its progress, call <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_GetMergeCasesStatus.html">GetMergeCasesStatus</a>.
    /// When the merge finishes, the selected field values and related items from the secondary
    /// case are on the primary case, the two cases are linked, and the secondary case is
    /// closed. Both cases record the merge in their audit history. For more information,
    /// see <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_GetCaseAuditEvents.html">GetCaseAuditEvents</a>.
    /// </para> <para> <b>Important things to know</b> </para> <ul> <li> <para> Both cases
    /// must have the same customer, or at least one of them must have no customer. </para>
    /// </li> <li> <para> While the merge runs, you can't modify the secondary case or its
    /// related items, and you can't delete the primary case. These requests return a <c>ConflictException</c>.
    /// </para> </li> <li> <para> After the merge, the secondary case can be reopened, updated,
    /// and deleted, but it can't be merged again. </para> </li> </ul> <para> The request
    /// fails with a <c>ValidationException</c>, and no merge starts, if: </para> <ul> <li>
    /// <para> The primary case and the secondary case are the same case. </para> </li> <li>
    /// <para> Either case is closed. </para> </li> <li> <para> Both cases have a customer,
    /// and the customers are different. </para> </li> <li> <para> <c>fieldsConfiguration</c>
    /// selects a field that can't be merged, or a field that the secondary case doesn't have.
    /// </para> </li> <li> <para> After the merge, the primary case would have more than 500
    /// field values, or would exceed the maximum case size. </para> </li> </ul> <para> The
    /// request fails with a <c>ServiceQuotaExceededException</c> if, after the merge, either
    /// case would exceed the quota for related items per case. For the primary case, the
    /// count is its existing related items, plus the related items moved from the secondary
    /// case, plus the new case link. See <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#cases-quotas">Connect
    /// Customer Cases quotas</a>. </para> <para> The request fails with a <c>ConflictException</c>
    /// if either case is already part of a merge that is running, or was previously merged
    /// into another case as the secondary case. </para> <para> <b>Endpoints</b>: See <a href="https://docs.aws.amazon.com/general/latest/gr/connect_region.html">Connect
    /// Customer endpoints and quotas</a>. </para>
    /// </summary>
    public partial class StartMergeCasesRequest : AmazonConnectCasesRequest
    {
        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// The unique identifier of the primary case. The primary case remains active and receives
        /// the merged field values and related items. The cases can use different templates,
        /// and the primary case keeps its template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string CaseId { get; set; }

        /// <summary>
        /// Checks to see if the CaseId property is set.
        /// </summary>
        internal bool IsSetCaseId() => this.CaseId != null;

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
        /// Gets and sets the property FieldsConfiguration. 
        /// <para>
        /// The fields whose values to take from the secondary case. You can only merge custom
        /// fields and the following system fields: <c>assigned_queue</c>, <c>assigned_user</c>,
        /// <c>summary</c>, and <c>case_reason</c>. If you select any other system field, the
        /// request fails with a <c>ValidationException</c>.
        /// </para>
        ///  
        /// <para>
        /// For each field that can be merged, the merge works as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you select the field, the primary case gets the secondary case's value. If the
        /// secondary case's value is empty, the primary case's value is cleared.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't select the field and the primary case has a value for it, the primary
        /// case keeps its value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't select the field and the primary case doesn't have the field, or its
        /// value is empty, the primary case gets the secondary case's value. This applies even
        /// when the field isn't on the primary case's template.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Field values are read from both cases when the merge runs, so changes that you make
        /// to the primary case after you start the merge are taken into account.
        /// </para>
        ///  
        /// <para>
        /// Specify at most one entry, and set its <c>sourceCaseId</c> to the secondary case ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FieldsConfiguration> FieldsConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new List<FieldsConfiguration>() : null;

        /// <summary>
        /// Checks to see if the FieldsConfiguration property is set.
        /// </summary>
        internal bool IsSetFieldsConfiguration() => this.FieldsConfiguration != null && (this.FieldsConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PerformedBy. 
        /// <para>
        /// The user who performed the merge. If you provide <c>userArn</c>, you must also have
        /// <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DescribeUser.html">DescribeUser</a>
        /// permission on the ARN of that user.
        /// </para>
        /// </summary>
        public UserUnion PerformedBy { get; set; }

        /// <summary>
        /// Checks to see if the PerformedBy property is set.
        /// </summary>
        internal bool IsSetPerformedBy() => this.PerformedBy != null;

        /// <summary>
        /// Gets and sets the property RelatedItemsConfiguration. 
        /// <para>
        /// The types of related items to move from the secondary case to the primary case. Related
        /// items of a type that you don't select, or set to <c>false</c>, stay on the closed
        /// secondary case. If you omit this parameter, no related items are moved.
        /// </para>
        ///  
        /// <para>
        /// File, SLA, and work plan related items are never moved. They stay on the secondary
        /// case.
        /// </para>
        /// </summary>
        public RelatedItemsConfiguration RelatedItemsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RelatedItemsConfiguration property is set.
        /// </summary>
        internal bool IsSetRelatedItemsConfiguration() => this.RelatedItemsConfiguration != null;

        /// <summary>
        /// Gets and sets the property SecondaryCaseIds. 
        /// <para>
        /// The unique identifier of the secondary case to merge into the primary case. The secondary
        /// case is closed when the merge finishes. Specify exactly one case ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> SecondaryCaseIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecondaryCaseIds property is set.
        /// </summary>
        internal bool IsSetSecondaryCaseIds() => this.SecondaryCaseIds != null && (this.SecondaryCaseIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
