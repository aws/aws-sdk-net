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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the CreateComputationModel operation.
    /// </summary>
    public partial class CreateComputationModelResponse : AmazonWebServiceResponse
    {
        private string _computationModelArn;
        private string _computationModelId;
        private ComputationModelStatus _computationModelStatus;

        /// <summary>
        /// Gets and sets the property ComputationModelArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the computation model, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:${Partition}:iotsitewise:${Region}:${Account}:computation-model/${ComputationModelId}</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string ComputationModelArn
        {
            get { return this._computationModelArn; }
            set { this._computationModelArn = value; }
        }

        // Check to see if ComputationModelArn property is set
        internal bool IsSetComputationModelArn()
        {
            return this._computationModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ComputationModelId. 
        /// <para>
        /// The ID of the computation model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ComputationModelId
        {
            get { return this._computationModelId; }
            set { this._computationModelId = value; }
        }

        // Check to see if ComputationModelId property is set
        internal bool IsSetComputationModelId()
        {
            return this._computationModelId != null;
        }

        /// <summary>
        /// Gets and sets the property ComputationModelStatus. 
        /// <para>
        /// The status of the computation model, containing a state (CREATING after successfully
        /// calling this operation) and any error messages.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComputationModelStatus ComputationModelStatus
        {
            get { return this._computationModelStatus; }
            set { this._computationModelStatus = value; }
        }

        // Check to see if ComputationModelStatus property is set
        internal bool IsSetComputationModelStatus()
        {
            return this._computationModelStatus != null;
        }

    }
}