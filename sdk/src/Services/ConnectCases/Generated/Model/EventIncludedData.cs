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
    /// Details of what case and related item data is published through the case event stream.
    /// </summary>
    public partial class EventIncludedData
    {
        private CaseEventIncludedData _caseData;
        private RelatedItemEventIncludedData _relatedItemData;

        /// <summary>
        /// Gets and sets the property CaseData. 
        /// <para>
        /// Details of what case data is published through the case event stream.
        /// </para>
        /// </summary>
        public CaseEventIncludedData CaseData
        {
            get { return this._caseData; }
            set { this._caseData = value; }
        }

        // Check to see if CaseData property is set
        internal bool IsSetCaseData()
        {
            return this._caseData != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedItemData. 
        /// <para>
        /// Details of what related item data is published through the case event stream.
        /// </para>
        /// </summary>
        public RelatedItemEventIncludedData RelatedItemData
        {
            get { return this._relatedItemData; }
            set { this._relatedItemData = value; }
        }

        // Check to see if RelatedItemData property is set
        internal bool IsSetRelatedItemData()
        {
            return this._relatedItemData != null;
        }

    }
}