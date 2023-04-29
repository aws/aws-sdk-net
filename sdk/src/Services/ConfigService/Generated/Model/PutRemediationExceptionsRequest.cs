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
    /// Container for the parameters to the PutRemediationExceptions operation.
    /// A remediation exception is when a specified resource is no longer considered for auto-remediation.
    /// This API adds a new exception or updates an existing exception for a specified resource
    /// with a specified Config rule. 
    /// 
    ///  <note> 
    /// <para>
    /// Config generates a remediation exception when a problem occurs running a remediation
    /// action for a specified resource. Remediation exceptions blocks auto-remediation until
    /// the exception is cleared.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// When placing an exception on an Amazon Web Services resource, it is recommended that
    /// remediation is set as manual remediation until the given Config rule for the specified
    /// resource evaluates the resource as <code>NON_COMPLIANT</code>. Once the resource has
    /// been evaluated as <code>NON_COMPLIANT</code>, you can add remediation exceptions and
    /// change the remediation type back from Manual to Auto if you want to use auto-remediation.
    /// Otherwise, using auto-remediation before a <code>NON_COMPLIANT</code> evaluation result
    /// can delete resources before the exception is applied.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// Placing an exception can only be performed on resources that are <code>NON_COMPLIANT</code>.
    /// If you use this API for <code>COMPLIANT</code> resources or resources that are <code>NOT_APPLICABLE</code>,
    /// a remediation exception will not be generated. For more information on the conditions
    /// that initiate the possible Config evaluation results, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/config-concepts.html#aws-config-rules">Concepts
    /// | Config Rules</a> in the Config Developer Guide.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutRemediationExceptionsRequest : AmazonConfigServiceRequest
    {
        private string _configRuleName;
        private DateTime? _expirationTime;
        private string _message;
        private List<RemediationExceptionResourceKey> _resourceKeys = new List<RemediationExceptionResourceKey>();

        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// The name of the Config rule for which you want to create remediation exception.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ConfigRuleName
        {
            get { return this._configRuleName; }
            set { this._configRuleName = value; }
        }

        // Check to see if ConfigRuleName property is set
        internal bool IsSetConfigRuleName()
        {
            return this._configRuleName != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The exception is automatically deleted after the expiration date.
        /// </para>
        /// </summary>
        public DateTime ExpirationTime
        {
            get { return this._expirationTime.GetValueOrDefault(); }
            set { this._expirationTime = value; }
        }

        // Check to see if ExpirationTime property is set
        internal bool IsSetExpirationTime()
        {
            return this._expirationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message contains an explanation of the exception.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceKeys. 
        /// <para>
        /// An exception list of resource exception keys to be processed with the current request.
        /// Config adds exception for each resource key. For example, Config adds 3 exceptions
        /// for 3 resource keys. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<RemediationExceptionResourceKey> ResourceKeys
        {
            get { return this._resourceKeys; }
            set { this._resourceKeys = value; }
        }

        // Check to see if ResourceKeys property is set
        internal bool IsSetResourceKeys()
        {
            return this._resourceKeys != null && this._resourceKeys.Count > 0; 
        }

    }
}