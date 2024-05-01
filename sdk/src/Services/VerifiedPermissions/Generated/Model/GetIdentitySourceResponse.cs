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
    /// This is the response object from the GetIdentitySource operation.
    /// </summary>
    public partial class GetIdentitySourceResponse : AmazonWebServiceResponse
    {
        private ConfigurationDetail _configuration;
        private DateTime? _createdDate;
        private IdentitySourceDetails _details;
        private string _identitySourceId;
        private DateTime? _lastUpdatedDate;
        private string _policyStoreId;
        private string _principalEntityType;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Contains configuration information about an identity source.
        /// </para>
        /// </summary>
        public ConfigurationDetail Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time that the identity source was originally created.
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
        /// Gets and sets the property Details. 
        /// <para>
        /// A structure that describes the configuration of the identity source.
        /// </para>
        /// </summary>
        [Obsolete("This attribute has been replaced by configuration.cognitoUserPoolConfiguration")]
        public IdentitySourceDetails Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null;
        }

        /// <summary>
        /// Gets and sets the property IdentitySourceId. 
        /// <para>
        /// The ID of the identity source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string IdentitySourceId
        {
            get { return this._identitySourceId; }
            set { this._identitySourceId = value; }
        }

        // Check to see if IdentitySourceId property is set
        internal bool IsSetIdentitySourceId()
        {
            return this._identitySourceId != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The date and time that the identity source was most recently updated.
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
        /// The ID of the policy store that contains the identity source.
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
        /// Gets and sets the property PrincipalEntityType. 
        /// <para>
        /// The data type of principals generated for identities authenticated by this identity
        /// source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=200)]
        public string PrincipalEntityType
        {
            get { return this._principalEntityType; }
            set { this._principalEntityType = value; }
        }

        // Check to see if PrincipalEntityType property is set
        internal bool IsSetPrincipalEntityType()
        {
            return this._principalEntityType != null;
        }

    }
}