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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the BatchDeleteClusterNodes operation.
    /// </summary>
    public partial class BatchDeleteClusterNodesResponse : AmazonWebServiceResponse
    {
        private List<BatchDeleteClusterNodesError> _failed = AWSConfigs.InitializeCollections ? new List<BatchDeleteClusterNodesError>() : null;
        private List<string> _successful = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// A list of errors encountered when deleting the specified nodes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=99)]
        public List<BatchDeleteClusterNodesError> Failed
        {
            get { return this._failed; }
            set { this._failed = value; }
        }

        // Check to see if Failed property is set
        internal bool IsSetFailed()
        {
            return this._failed != null && (this._failed.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Successful. 
        /// <para>
        /// A list of node IDs that were successfully deleted from the specified cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=99)]
        public List<string> Successful
        {
            get { return this._successful; }
            set { this._successful = value; }
        }

        // Check to see if Successful property is set
        internal bool IsSetSuccessful()
        {
            return this._successful != null && (this._successful.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}