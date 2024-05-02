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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// This is the response object from the CreateTapePool operation.
    /// </summary>
    public partial class CreateTapePoolResponse : AmazonWebServiceResponse
    {
        private string _poolARN;

        /// <summary>
        /// Gets and sets the property PoolARN. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) that represents the custom tape pool. Use the
        /// <a>ListTapePools</a> operation to return a list of tape pools for your account and
        /// Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string PoolARN
        {
            get { return this._poolARN; }
            set { this._poolARN = value; }
        }

        // Check to see if PoolARN property is set
        internal bool IsSetPoolARN()
        {
            return this._poolARN != null;
        }

    }
}