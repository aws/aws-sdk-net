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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the RecordHandlerProgress operation. Reports progress
    /// of a resource handler to CloudFormation. <para> Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
    /// CLI</a>. Don't use this API in your code. </para>
    /// </summary>
    public partial class RecordHandlerProgressRequest : AmazonCloudFormationRequest
    {
        /// <summary>
        /// Gets and sets the property BearerToken. 
        /// <para>
        /// Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string BearerToken { get; set; }

        /// <summary>
        /// Checks to see if the BearerToken property is set.
        /// </summary>
        internal bool IsSetBearerToken() => this.BearerToken != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property CurrentOperationStatus. 
        /// <para>
        /// Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>.
        /// </para>
        /// </summary>
        public OperationStatus CurrentOperationStatus { get; set; }

        /// <summary>
        /// Checks to see if the CurrentOperationStatus property is set.
        /// </summary>
        internal bool IsSetCurrentOperationStatus() => this.CurrentOperationStatus != null;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>.
        /// </para>
        /// </summary>
        public HandlerErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property OperationStatus. 
        /// <para>
        /// Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OperationStatus OperationStatus { get; set; }

        /// <summary>
        /// Checks to see if the OperationStatus property is set.
        /// </summary>
        internal bool IsSetOperationStatus() => this.OperationStatus != null;

        /// <summary>
        /// Gets and sets the property ResourceModel. 
        /// <para>
        /// Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 16384)]
        public string ResourceModel { get; set; }

        /// <summary>
        /// Checks to see if the ResourceModel property is set.
        /// </summary>
        internal bool IsSetResourceModel() => this.ResourceModel != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
