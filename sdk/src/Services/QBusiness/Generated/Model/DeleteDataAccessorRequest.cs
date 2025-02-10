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
    /// Container for the parameters to the DeleteDataAccessor operation.
    /// Deletes a specified data accessor. This operation permanently removes the data accessor
    /// and its associated IAM Identity Center application. Any access granted to the ISV
    /// through this data accessor will be revoked.
    /// </summary>
    public partial class DeleteDataAccessorRequest : AmazonQBusinessRequest
    {
        private string _applicationId;
        private string _dataAccessorId;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property DataAccessorId. 
        /// <para>
        /// The unique identifier of the data accessor to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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

    }
}