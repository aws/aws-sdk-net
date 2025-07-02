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
    /// Container for the parameters to the UpdateCase operation.
    /// <note> 
    /// <para>
    /// If you provide a value for <c>PerformedBy.UserArn</c> you must also have <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DescribeUser.html">connect:DescribeUser</a>
    /// permission on the User ARN resource that you provide
    /// 
    ///  </note> 
    /// <para>
    /// Updates the values of fields on a case. Fields to be updated are received as an array
    /// of id/value pairs identical to the <c>CreateCase</c> input .
    /// </para>
    ///  
    /// <para>
    /// If the action is successful, the service sends back an HTTP 200 response with an empty
    /// HTTP body.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class UpdateCaseRequest : AmazonConnectCasesRequest
    {
        private string _caseId;
        private string _domainId;
        private List<FieldValue> _fields = AWSConfigs.InitializeCollections ? new List<FieldValue>() : null;
        private UserUnion _performedBy;

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
        /// Gets and sets the property Fields. 
        /// <para>
        /// An array of objects with <c>fieldId</c> (matching ListFields/DescribeField) and value
        /// union data, structured identical to <c>CreateCase</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<FieldValue> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && (this._fields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PerformedBy.
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

    }
}