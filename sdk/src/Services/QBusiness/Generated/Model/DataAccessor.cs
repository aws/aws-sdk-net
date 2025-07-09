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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Provides summary information about a data accessor.
    /// </summary>
    public partial class DataAccessor
    {
        private DataAccessorAuthenticationDetail _authenticationDetail;
        private DateTime? _createdAt;
        private string _dataAccessorArn;
        private string _dataAccessorId;
        private string _displayName;
        private string _idcApplicationArn;
        private string _principal;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AuthenticationDetail. 
        /// <para>
        /// The authentication configuration details for the data accessor. This specifies how
        /// the ISV authenticates when accessing data through this data accessor.
        /// </para>
        /// </summary>
        public DataAccessorAuthenticationDetail AuthenticationDetail
        {
            get { return this._authenticationDetail; }
            set { this._authenticationDetail = value; }
        }

        // Check to see if AuthenticationDetail property is set
        internal bool IsSetAuthenticationDetail()
        {
            return this._authenticationDetail != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the data accessor was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataAccessorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data accessor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1284)]
        public string DataAccessorArn
        {
            get { return this._dataAccessorArn; }
            set { this._dataAccessorArn = value; }
        }

        // Check to see if DataAccessorArn property is set
        internal bool IsSetDataAccessorArn()
        {
            return this._dataAccessorArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataAccessorId. 
        /// <para>
        /// The unique identifier of the data accessor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string DataAccessorId
        {
            get { return this._dataAccessorId; }
            set { this._dataAccessorId = value; }
        }

        // Check to see if DataAccessorId property is set
        internal bool IsSetDataAccessorId()
        {
            return this._dataAccessorId != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The friendly name of the data accessor.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property IdcApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the associated IAM Identity Center application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=1224)]
        public string IdcApplicationArn
        {
            get { return this._idcApplicationArn; }
            set { this._idcApplicationArn = value; }
        }

        // Check to see if IdcApplicationArn property is set
        internal bool IsSetIdcApplicationArn()
        {
            return this._idcApplicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role for the ISV associated with this data
        /// accessor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1284)]
        public string Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the data accessor was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}