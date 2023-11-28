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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using Amazon.S3.Model.Internal;
namespace Amazon.S3.Model
{
    /// <summary>
    /// Contains information about the Bucket
    /// </summary>
    public class BucketInfo
    {
        private DataRedundancy _dataRedundancy;
        private BucketType _type;

        /// <summary>
        /// Gets and sets the property DataRedundancy.
        /// </summary>
        public DataRedundancy DataRedundancy
        {
            get { return this._dataRedundancy; }
            set { this._dataRedundancy = value; }
        }

        // Check to see if DataRedundancy property is set
        internal bool IsSetDataRedundancy()
        {
            return this._dataRedundancy != null;
        }

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        public BucketType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }
    }
}
