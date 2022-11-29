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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the StartResourceEvaluation operation.
    /// Runs an on-demand evaluation for the specified resource to determine whether the resource
    /// details will comply with configured Config rules. You can also use it for evaluation
    /// purposes. Config recommends using an evaluation context. It runs an execution against
    /// the resource details with all of the Config rules in your account that match with
    /// the specified proactive mode and resource type.
    /// 
    ///  <note> 
    /// <para>
    /// Ensure you have the <code>cloudformation:DescribeType</code> role setup to validate
    /// the resource type schema. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StartResourceEvaluationRequest : AmazonConfigServiceRequest
    {
        private string _clientToken;
        private EvaluationContext _evaluationContext;
        private EvaluationMode _evaluationMode;
        private int? _evaluationTimeout;
        private ResourceDetails _resourceDetails;

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
        [AWSProperty(Min=64, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationContext. 
        /// <para>
        /// Returns an <code>EvaluationContext</code> object.
        /// </para>
        /// </summary>
        public EvaluationContext EvaluationContext
        {
            get { return this._evaluationContext; }
            set { this._evaluationContext = value; }
        }

        // Check to see if EvaluationContext property is set
        internal bool IsSetEvaluationContext()
        {
            return this._evaluationContext != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationMode. 
        /// <para>
        /// The mode of an evaluation. The valid value for this API is <code>Proactive</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationMode EvaluationMode
        {
            get { return this._evaluationMode; }
            set { this._evaluationMode = value; }
        }

        // Check to see if EvaluationMode property is set
        internal bool IsSetEvaluationMode()
        {
            return this._evaluationMode != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationTimeout. 
        /// <para>
        /// The timeout for an evaluation. The default is 900 seconds. You cannot specify a number
        /// greater than 3600. If you specify 0, Config uses the default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3600)]
        public int EvaluationTimeout
        {
            get { return this._evaluationTimeout.GetValueOrDefault(); }
            set { this._evaluationTimeout = value; }
        }

        // Check to see if EvaluationTimeout property is set
        internal bool IsSetEvaluationTimeout()
        {
            return this._evaluationTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceDetails. 
        /// <para>
        /// Returns a <code>ResourceDetails</code> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceDetails ResourceDetails
        {
            get { return this._resourceDetails; }
            set { this._resourceDetails = value; }
        }

        // Check to see if ResourceDetails property is set
        internal bool IsSetResourceDetails()
        {
            return this._resourceDetails != null;
        }

    }
}