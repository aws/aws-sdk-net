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
    /// Container for the parameters to the CreateRelatedItem operation.
    /// Creates a related item (comments, tasks, and contacts) and associates it with a case.
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    /// A Related Item is a resource that is associated with a case. It may or may not have
    /// an external identifier linking it to an external resource (for example, a <c>contactArn</c>).
    /// All Related Items have their own internal identifier, the <c>relatedItemArn</c>. Examples
    /// of related items include <c>comments</c> and <c>contacts</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you provide a value for <c>performedBy.userArn</c> you must also have <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DescribeUser.html">DescribeUser</a>
    /// permission on the ARN of the user that you provide.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>type</c> field is reserved for internal use only.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class CreateRelatedItemRequest : AmazonConnectCasesRequest
    {
        private string _caseId;
        private RelatedItemInputContent _content;
        private string _domainId;
        private UserUnion _performedBy;
        private RelatedItemType _type;

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
        /// The content of a related item to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RelatedItemInputContent Content
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
        /// Represents the creator of the related item.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of a related item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RelatedItemType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}