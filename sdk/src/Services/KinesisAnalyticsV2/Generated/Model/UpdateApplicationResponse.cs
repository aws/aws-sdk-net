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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// This is the response object from the UpdateApplication operation.
    /// </summary>
    public partial class UpdateApplicationResponse : AmazonWebServiceResponse
    {
        private ApplicationDetail _applicationDetail;
        private string _operationId;

        /// <summary>
        /// Gets and sets the property ApplicationDetail. 
        /// <para>
        /// Describes application updates.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApplicationDetail ApplicationDetail
        {
            get { return this._applicationDetail; }
            set { this._applicationDetail = value; }
        }

        // Check to see if ApplicationDetail property is set
        internal bool IsSetApplicationDetail()
        {
            return this._applicationDetail != null;
        }

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The operation ID that can be used to track the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string OperationId
        {
            get { return this._operationId; }
            set { this._operationId = value; }
        }

        // Check to see if OperationId property is set
        internal bool IsSetOperationId()
        {
            return this._operationId != null;
        }

    }
}