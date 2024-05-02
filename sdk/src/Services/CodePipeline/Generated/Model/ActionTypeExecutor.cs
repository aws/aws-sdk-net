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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// The action engine, or executor, for an action type created for a provider, where the
    /// action is to be used by customers of the provider. The action engine is associated
    /// with the model used to create and update the action, such as the Lambda integration
    /// model.
    /// </summary>
    public partial class ActionTypeExecutor
    {
        private ExecutorConfiguration _configuration;
        private int? _jobTimeout;
        private string _policyStatementsTemplate;
        private ExecutorType _type;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The action configuration properties for the action type. These properties are specified
        /// in the action definition when the action type is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExecutorConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property JobTimeout. 
        /// <para>
        /// The timeout in seconds for the job. An action execution can have multiple jobs. This
        /// is the timeout for a single job, not the entire action execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=43200)]
        public int? JobTimeout
        {
            get { return this._jobTimeout; }
            set { this._jobTimeout = value; }
        }

        // Check to see if JobTimeout property is set
        internal bool IsSetJobTimeout()
        {
            return this._jobTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyStatementsTemplate. 
        /// <para>
        /// The policy statement that specifies the permissions in the CodePipeline customer account
        /// that are needed to successfully run an action.
        /// </para>
        ///  
        /// <para>
        /// To grant permission to another account, specify the account ID as the Principal, a
        /// domain-style identifier defined by the service, for example <c>codepipeline.amazonaws.com</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The size of the passed JSON policy document cannot exceed 2048 characters.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string PolicyStatementsTemplate
        {
            get { return this._policyStatementsTemplate; }
            set { this._policyStatementsTemplate = value; }
        }

        // Check to see if PolicyStatementsTemplate property is set
        internal bool IsSetPolicyStatementsTemplate()
        {
            return this._policyStatementsTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The integration model used to create and update the action type, <c>Lambda</c> or
        /// <c>JobWorker</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExecutorType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}