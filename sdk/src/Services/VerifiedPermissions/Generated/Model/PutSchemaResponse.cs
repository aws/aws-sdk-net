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

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// This is the response object from the PutSchema operation.
    /// </summary>
    public partial class PutSchemaResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdDate;
        private DateTime? _lastUpdatedDate;
        private List<string> _namespaces = new List<string>();
        private string _policyStoreId;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time that the schema was originally created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The date and time that the schema was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastUpdatedDate
        {
            get { return this._lastUpdatedDate.GetValueOrDefault(); }
            set { this._lastUpdatedDate = value; }
        }

        // Check to see if LastUpdatedDate property is set
        internal bool IsSetLastUpdatedDate()
        {
            return this._lastUpdatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Namespaces. 
        /// <para>
        /// Identifies the namespaces of the entities referenced by this schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Namespaces
        {
            get { return this._namespaces; }
            set { this._namespaces = value; }
        }

        // Check to see if Namespaces property is set
        internal bool IsSetNamespaces()
        {
            return this._namespaces != null && this._namespaces.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// The unique ID of the policy store that contains the schema.
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

    }
}