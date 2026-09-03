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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
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
    /// Container for the parameters to the AddCommunicationToCase operation.
    /// Adds additional customer communication to a Amazon Web Services Support case. Use
    /// the <c>caseId</c> parameter to identify the case to which to add communication. To
    /// list a set of email addresses to copy on the communication, use the <c>ccEmailAddresses</c>
    /// parameter. The <c>communicationBody</c> value contains the text of the communication.
    /// 
    ///  
    /// <para>
    /// To attach files larger than 5 MB to the communication, use the <c>uploadIds</c> parameter.
    /// </para>
    ///  <important> 
    /// <para>
    /// Amazon Web Services Support automatically redacts sensitive information from support
    /// cases to protect your data. The following information is replaced with <c>[REDACTED_BY_Amazon
    /// Web Services]</c> and is not stored:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon Web Services secret keys - The complete key is replaced. Example: <c>[REDACTED_BY_Amazon
    /// Web Services]</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Private keys - The complete key is replaced. Example: <c>[REDACTED_BY_Amazon Web Services]</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Credit card numbers - The number is redacted, but the last 4 digits remain. Example:
    /// <c>[REDACTED_BY_Amazon Web Services]-7016</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This sensitive information is never required by Amazon Web Services Support.
    /// </para>
    ///  </important> <note> <ul> <li> 
    /// <para>
    /// You must have an Amazon Web Services Business Support+, Amazon Web Services Enterprise
    /// Support, or Amazon Web Services Unified Operations plan to use the Amazon Web Services
    /// Support API. If you're in an Amazon Web Services Region that doesn't offer one of
    /// these Amazon Web Services Support plans, or if you haven't transitioned to one of
    /// these plans, you can use the Amazon Web Services Support API with a Business, Enterprise
    /// On-Ramp, or Enterprise Support plan.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you call the Amazon Web Services Support API from an account that doesn't have
    /// an Amazon Web Services Business Support+, Amazon Web Services Enterprise Support,
    /// or Amazon Web Services Unified Operations plan, the <c>SubscriptionRequiredException</c>
    /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
    /// Web Services Support</a>.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class AddCommunicationToCaseRequest : AmazonAWSSupportRequest
    {
        private string _attachmentSetId;
        private string _caseId;
        private List<string> _ccEmailAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _communicationBody;
        private bool? _dryRun;
        private List<string> _uploadIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AttachmentSetId. 
        /// <para>
        /// The ID of a set of one or more attachments for the communication to add to the case.
        /// Create the set by calling <a>AddAttachmentsToSet</a>. Each attachment in the set must
        /// be 5 MB or smaller. To attach files larger than 5 MB, use <c>uploadIds</c>.
        /// </para>
        /// </summary>
        public string AttachmentSetId
        {
            get { return this._attachmentSetId; }
            set { this._attachmentSetId = value; }
        }

        // Check to see if AttachmentSetId property is set
        internal bool IsSetAttachmentSetId()
        {
            return this._attachmentSetId != null;
        }

        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// The support case ID requested or returned in the call. The case ID is an alphanumeric
        /// string formatted as shown in this example: case-<i>12345678910-exen-2025-c4c1d2bf33c5cf47</i>
        /// 
        /// </para>
        /// </summary>
        public string CaseId
        {
            get { return this._caseId; }
            set { this._caseId = value; }
        }

        // Check to see if CaseId property is set
        internal bool IsSetCaseId()
        {
            return this._caseId != null;
        }

        /// <summary>
        /// Gets and sets the property CcEmailAddresses. 
        /// <para>
        /// The email addresses in the CC line of an email to be added to the support case.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> CcEmailAddresses
        {
            get { return this._ccEmailAddresses; }
            set { this._ccEmailAddresses = value; }
        }

        // Check to see if CcEmailAddresses property is set
        internal bool IsSetCcEmailAddresses()
        {
            return this._ccEmailAddresses != null && (this._ccEmailAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CommunicationBody. 
        /// <para>
        /// The body of an email communication to add to the support case.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8000)]
        public string CommunicationBody
        {
            get { return this._communicationBody; }
            set { this._communicationBody = value; }
        }

        // Check to see if CommunicationBody property is set
        internal bool IsSetCommunicationBody()
        {
            return this._communicationBody != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Specifies whether to validate the request without actually adding the communication
        /// to the case. When set to <c>true</c>, the request is validated but the communication
        /// isn't added, and the operation returns a <c>DryRunOperationException</c>. When omitted
        /// or set to <c>false</c>, the request runs normally.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UploadIds. 
        /// <para>
        /// A list of upload IDs that identify attachments to add to the case. Each <c>uploadId</c>
        /// is returned by the <a>GetAttachmentUploadLinks</a> operation. The upload must reach
        /// the <c>attachment-ready</c> state by calling <a>CompleteAttachmentUpload</a> before
        /// it can be passed here. Use <c>uploadIds</c> to attach files of any supported size,
        /// including files larger than 5 MB.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> UploadIds
        {
            get { return this._uploadIds; }
            set { this._uploadIds = value; }
        }

        // Check to see if UploadIds property is set
        internal bool IsSetUploadIds()
        {
            return this._uploadIds != null && (this._uploadIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}