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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// This is the response object from the PutS3AccessPolicy operation.
    /// </summary>
    public partial class PutS3AccessPolicyResponse : AmazonWebServiceResponse
    {
        private string _s3AccessPointArn;
        private string _storeId;
        private StoreType _storeType;

        /// <summary>
        /// Gets and sets the property S3AccessPointArn. 
        /// <para>
        /// The S3 access point ARN that now has the access policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string S3AccessPointArn
        {
            get { return this._s3AccessPointArn; }
            set { this._s3AccessPointArn = value; }
        }

        // Check to see if S3AccessPointArn property is set
        internal bool IsSetS3AccessPointArn()
        {
            return this._s3AccessPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property StoreId. 
        /// <para>
        /// The Amazon Web Services-generated Sequence Store or Reference Store ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=36)]
        public string StoreId
        {
            get { return this._storeId; }
            set { this._storeId = value; }
        }

        // Check to see if StoreId property is set
        internal bool IsSetStoreId()
        {
            return this._storeId != null;
        }

        /// <summary>
        /// Gets and sets the property StoreType. 
        /// <para>
        /// The type of store associated with the access point.
        /// </para>
        /// </summary>
        public StoreType StoreType
        {
            get { return this._storeType; }
            set { this._storeType = value; }
        }

        // Check to see if StoreType property is set
        internal bool IsSetStoreType()
        {
            return this._storeType != null;
        }

    }
}