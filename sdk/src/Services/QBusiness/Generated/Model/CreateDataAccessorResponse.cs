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
    /// This is the response object from the CreateDataAccessor operation.
    /// </summary>
    public partial class CreateDataAccessorResponse : AmazonWebServiceResponse
    {
        private string _dataAccessorArn;
        private string _dataAccessorId;
        private string _idcApplicationArn;

        /// <summary>
        /// Gets and sets the property DataAccessorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the created data accessor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1284)]
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
        /// The unique identifier of the created data accessor.
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

        /// <summary>
        /// Gets and sets the property IdcApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Identity Center application created for
        /// this data accessor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=1224)]
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

    }
}