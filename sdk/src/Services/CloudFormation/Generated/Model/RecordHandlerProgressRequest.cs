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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the RecordHandlerProgress operation.
    /// Reports progress of a resource handler to CloudFormation.
    /// 
    ///  
    /// <para>
    /// Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
    /// CLI</a>. Don't use this API in your code.
    /// </para>
    /// </summary>
    public partial class RecordHandlerProgressRequest : AmazonCloudFormationRequest
    {
        private string _bearerToken;
        private string _clientRequestToken;
        private OperationStatus _currentOperationStatus;
        private HandlerErrorCode _errorCode;
        private OperationStatus _operationStatus;
        private string _resourceModel;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property BearerToken. 
        /// <para>
        /// Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string BearerToken
        {
            get { return this._bearerToken; }
            set { this._bearerToken = value; }
        }

        // Check to see if BearerToken property is set
        internal bool IsSetBearerToken()
        {
            return this._bearerToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentOperationStatus. 
        /// <para>
        /// Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>.
        /// </para>
        /// </summary>
        public OperationStatus CurrentOperationStatus
        {
            get { return this._currentOperationStatus; }
            set { this._currentOperationStatus = value; }
        }

        // Check to see if CurrentOperationStatus property is set
        internal bool IsSetCurrentOperationStatus()
        {
            return this._currentOperationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>.
        /// </para>
        /// </summary>
        public HandlerErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property OperationStatus. 
        /// <para>
        /// Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OperationStatus OperationStatus
        {
            get { return this._operationStatus; }
            set { this._operationStatus = value; }
        }

        // Check to see if OperationStatus property is set
        internal bool IsSetOperationStatus()
        {
            return this._operationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceModel. 
        /// <para>
        /// Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16384)]
        public string ResourceModel
        {
            get { return this._resourceModel; }
            set { this._resourceModel = value; }
        }

        // Check to see if ResourceModel property is set
        internal bool IsSetResourceModel()
        {
            return this._resourceModel != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}