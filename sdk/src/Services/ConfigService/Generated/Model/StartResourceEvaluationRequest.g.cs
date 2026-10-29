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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the StartResourceEvaluation operation. Runs an on-demand
    /// evaluation for the specified resource to determine whether the resource details will
    /// comply with configured Config rules. You can also use it for evaluation purposes.
    /// Config recommends using an evaluation context. It runs an execution against the resource
    /// details with all of the Config rules in your account that match with the specified
    /// proactive mode and resource type. <note> <para> Ensure you have the <c>cloudformation:DescribeType</c>
    /// role setup to validate the resource type schema. </para> <para> You can find the <a
    /// href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-schema.html">Resource
    /// type schema</a> in "<i>Amazon Web Services public extensions</i>" within the CloudFormation
    /// registry or with the following CLI commmand: <c>aws cloudformation describe-type --type-name
    /// "AWS::S3::Bucket" --type RESOURCE</c>. </para> <para> For more information, see <a
    /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry.html#registry-view">Managing
    /// extensions through the CloudFormation registry</a> and <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Amazon
    /// Web Services resource and property types reference</a> in the CloudFormation User
    /// Guide. </para> </note>
    /// </summary>
    public partial class StartResourceEvaluationRequest : AmazonConfigServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A client token is a unique, case-sensitive string of up to 64 ASCII characters. To
        /// make an idempotent API request using one of these actions, specify a client token
        /// in the request.
        /// </para>
        ///  <note> 
        /// <para>
        /// Avoid reusing the same client token for other API requests. If you retry a request
        /// that completed successfully using the same client token and the same parameters, the
        /// retry succeeds without performing any further actions. If you retry a successful request
        /// using the same client token, but one or more of the parameters are different, other
        /// than the Region or Availability Zone, the retry fails with an IdempotentParameterMismatch
        /// error.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 64, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EvaluationContext. 
        /// <para>
        /// Returns an <c>EvaluationContext</c> object.
        /// </para>
        /// </summary>
        public EvaluationContext EvaluationContext { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationContext property is set.
        /// </summary>
        internal bool IsSetEvaluationContext() => this.EvaluationContext != null;

        /// <summary>
        /// Gets and sets the property EvaluationMode. 
        /// <para>
        /// The mode of an evaluation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The only valid value for this API is <c>PROACTIVE</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationMode EvaluationMode { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationMode property is set.
        /// </summary>
        internal bool IsSetEvaluationMode() => this.EvaluationMode != null;

        /// <summary>
        /// Gets and sets the property EvaluationTimeout. 
        /// <para>
        /// The timeout for an evaluation. The default is 900 seconds. You cannot specify a number
        /// greater than 3600. If you specify 0, Config uses the default.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3600)]
        public int? EvaluationTimeout { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationTimeout property is set.
        /// </summary>
        internal bool IsSetEvaluationTimeout() => this.EvaluationTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceDetails. 
        /// <para>
        /// Returns a <c>ResourceDetails</c> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceDetails ResourceDetails { get; set; }

        /// <summary>
        /// Checks to see if the ResourceDetails property is set.
        /// </summary>
        internal bool IsSetResourceDetails() => this.ResourceDetails != null;
    }
}
