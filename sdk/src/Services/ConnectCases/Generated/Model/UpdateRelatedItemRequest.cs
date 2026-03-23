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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
    /// Container for the parameters to the UpdateRelatedItem operation.
    /// Updates the content of a related item associated with a case. The following related
    /// item types are supported:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <b>Comment</b> - Update the text content of an existing comment
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Custom</b> - Update the fields of a custom related item. You can add, modify,
    /// and remove fields from a custom related item. There's a quota for the number of fields
    /// allowed in a Custom type related item. See <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#cases-quotas">Amazon
    /// Connect Cases quotas</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Important things to know</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// When updating a Custom related item, all existing and new fields, and their associated
    /// values should be included in the request. Fields not included as part of this request
    /// will be removed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you provide a value for <c>performedBy.userArn</c> you must also have <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DescribeUser.html">DescribeUser</a>
    /// permission on the ARN of the user that you provide.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/adminguide/case-fields.html#system-case-fields">System
    /// case fields</a> cannot be used in a custom related item.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Endpoints</b>: See <a href="https://docs.aws.amazon.com/general/latest/gr/connect_region.html">Amazon
    /// Connect endpoints and quotas</a>.
    /// </para>
    /// </summary>
    public partial class UpdateRelatedItemRequest : AmazonConnectCasesRequest
    {
        private string _caseId;
        private RelatedItemUpdateContent _content;
        private string _domainId;
        private UserUnion _performedBy;
        private string _relatedItemId;

        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// A unique identifier of the case.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
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
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of a related item to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RelatedItemUpdateContent Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The unique identifier of the Cases domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property PerformedBy. 
        /// <para>
        /// Represents the user who performed the update of the related item.
        /// </para>
        /// </summary>
        public UserUnion PerformedBy
        {
            get { return this._performedBy; }
            set { this._performedBy = value; }
        }

        // Check to see if PerformedBy property is set
        internal bool IsSetPerformedBy()
        {
            return this._performedBy != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedItemId. 
        /// <para>
        /// Unique identifier of a related item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string RelatedItemId
        {
            get { return this._relatedItemId; }
            set { this._relatedItemId = value; }
        }

        // Check to see if RelatedItemId property is set
        internal bool IsSetRelatedItemId()
        {
            return this._relatedItemId != null;
        }

    }
}