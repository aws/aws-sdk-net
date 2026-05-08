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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// This is the response object from the CreateABTest operation.
    /// </summary>
    public partial class CreateABTestResponse : AmazonWebServiceResponse
    {
        private string _abTestArn;
        private string _abTestId;
        private DateTime? _createdAt;
        private ABTestExecutionStatus _executionStatus;
        private string _name;
        private ABTestStatus _status;

        /// <summary>
        /// Gets and sets the property AbTestArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the created A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AbTestArn
        {
            get { return this._abTestArn; }
            set { this._abTestArn = value; }
        }

        // Check to see if AbTestArn property is set
        internal bool IsSetAbTestArn()
        {
            return this._abTestArn != null;
        }

        /// <summary>
        /// Gets and sets the property AbTestId. 
        /// <para>
        /// The unique identifier of the created A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AbTestId
        {
            get { return this._abTestId; }
            set { this._abTestId = value; }
        }

        // Check to see if AbTestId property is set
        internal bool IsSetAbTestId()
        {
            return this._abTestId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the A/B test was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// The execution status indicating whether the A/B test is currently running.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ABTestExecutionStatus ExecutionStatus
        {
            get { return this._executionStatus; }
            set { this._executionStatus = value; }
        }

        // Check to see if ExecutionStatus property is set
        internal bool IsSetExecutionStatus()
        {
            return this._executionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the A/B test.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ABTestStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}