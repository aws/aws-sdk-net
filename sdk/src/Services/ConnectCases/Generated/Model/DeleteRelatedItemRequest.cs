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
    /// Container for the parameters to the DeleteRelatedItem operation.
    /// Deletes the related item resource under a case.
    /// 
    ///  <note> 
    /// <para>
    /// This API cannot be used on a FILE type related attachment. To delete this type of
    /// file, use the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DeleteAttachedFile.html">DeleteAttachedFile</a>
    /// API
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteRelatedItemRequest : AmazonConnectCasesRequest
    {
        private string _caseId;
        private string _domainId;
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
        /// Gets and sets the property DomainId. 
        /// <para>
        /// A unique identifier of the Cases domain.
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
        /// Gets and sets the property RelatedItemId. 
        /// <para>
        /// A unique identifier of a related item.
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