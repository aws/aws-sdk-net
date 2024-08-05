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
    /// Container for the parameters to the DeleteField operation.
    /// Deletes a field from a cases template. You can delete up to 100 fields per domain.
    /// 
    ///  
    /// <para>
    /// After a field is deleted:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can still retrieve the field by calling <c>BatchGetField</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You cannot update a deleted field by calling <c>UpdateField</c>; it throws a <c>ValidationException</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Deleted fields are not included in the <c>ListFields</c> response.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Calling <c>CreateCase</c> with a deleted field throws a <c>ValidationException</c>
    /// denoting which field IDs in the request have been deleted.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Calling <c>GetCase</c> with a deleted field ID returns the deleted field's value if
    /// one exists.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Calling <c>UpdateCase</c> with a deleted field ID throws a <c>ValidationException</c>
    /// if the case does not already contain a value for the deleted field. Otherwise it succeeds,
    /// allowing you to update or remove (using <c>emptyValue: {}</c>) the field's value from
    /// the case.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>GetTemplate</c> does not return field IDs for deleted fields.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>GetLayout</c> does not return field IDs for deleted fields.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Calling <c>SearchCases</c> with the deleted field ID as a filter returns any cases
    /// that have a value for the deleted field that matches the filter criteria.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Calling <c>SearchCases</c> with a <c>searchTerm</c> value that matches a deleted field's
    /// value on a case returns the case in the response.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Calling <c>BatchPutFieldOptions</c> with a deleted field ID throw a <c>ValidationException</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Calling <c>GetCaseEventConfiguration</c> does not return field IDs for deleted fields.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteFieldRequest : AmazonConnectCasesRequest
    {
        private string _domainId;
        private string _fieldId;

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
        /// Gets and sets the property FieldId. 
        /// <para>
        /// Unique identifier of the field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string FieldId
        {
            get { return this._fieldId; }
            set { this._fieldId = value; }
        }

        // Check to see if FieldId property is set
        internal bool IsSetFieldId()
        {
            return this._fieldId != null;
        }

    }
}