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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// This is the response object from the GetPolicyTemplate operation.
    /// </summary>
    public partial class GetPolicyTemplateResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdDate;
        private string _description;
        private DateTime? _lastUpdatedDate;
        private string _policyStoreId;
        private string _policyTemplateId;
        private string _statement;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time that the policy template was originally created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the policy template.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=150)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The date and time that the policy template was most recently updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedDate
        {
            get { return this._lastUpdatedDate; }
            set { this._lastUpdatedDate = value; }
        }

        // Check to see if LastUpdatedDate property is set
        internal bool IsSetLastUpdatedDate()
        {
            return this._lastUpdatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// The ID of the policy store that contains the policy template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string PolicyStoreId
        {
            get { return this._policyStoreId; }
            set { this._policyStoreId = value; }
        }

        // Check to see if PolicyStoreId property is set
        internal bool IsSetPolicyStoreId()
        {
            return this._policyStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyTemplateId. 
        /// <para>
        /// The ID of the policy template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string PolicyTemplateId
        {
            get { return this._policyTemplateId; }
            set { this._policyTemplateId = value; }
        }

        // Check to see if PolicyTemplateId property is set
        internal bool IsSetPolicyTemplateId()
        {
            return this._policyTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property Statement. 
        /// <para>
        /// The content of the body of the policy template written in the Cedar policy language.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=10000)]
        public string Statement
        {
            get { return this._statement; }
            set { this._statement = value; }
        }

        // Check to see if Statement property is set
        internal bool IsSetStatement()
        {
            return this._statement != null;
        }

    }
}