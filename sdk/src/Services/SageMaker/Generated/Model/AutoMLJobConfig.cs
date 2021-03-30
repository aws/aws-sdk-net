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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A collection of settings used for an AutoML job.
    /// </summary>
    public partial class AutoMLJobConfig
    {
        private AutoMLJobCompletionCriteria _completionCriteria;
        private AutoMLSecurityConfig _securityConfig;

        /// <summary>
        /// Gets and sets the property CompletionCriteria. 
        /// <para>
        /// How long an AutoML job is allowed to run, or how many candidates a job is allowed
        /// to generate.
        /// </para>
        /// </summary>
        public AutoMLJobCompletionCriteria CompletionCriteria
        {
            get { return this._completionCriteria; }
            set { this._completionCriteria = value; }
        }

        // Check to see if CompletionCriteria property is set
        internal bool IsSetCompletionCriteria()
        {
            return this._completionCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityConfig. 
        /// <para>
        /// Security configuration for traffic encryption or Amazon VPC settings.
        /// </para>
        /// </summary>
        public AutoMLSecurityConfig SecurityConfig
        {
            get { return this._securityConfig; }
            set { this._securityConfig = value; }
        }

        // Check to see if SecurityConfig property is set
        internal bool IsSetSecurityConfig()
        {
            return this._securityConfig != null;
        }

    }
}