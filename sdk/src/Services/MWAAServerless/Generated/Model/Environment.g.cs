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

namespace Amazon.MWAAServerless.Model
{
    /// <summary>
    /// Contains the environment variables that tasks in a workflow use during execution.
    /// </summary>
    public partial class Environment
    {
        /// <summary>
        /// Gets and sets the property Variables. 
        /// <para>
        /// A map of environment variable names to values. Your workflow tasks use these variables
        /// while they run. You can specify up to 50 environment variables. Each name must be
        /// between 1 and 128 characters, start with a letter, and contain only letters, numbers,
        /// and underscores. Each value can be up to 255 characters.
        /// </para>
        ///  
        /// <para>
        /// Names that start with <c>AWS_</c> or <c>AIRFLOW__</c> are reserved. You can use the
        /// following Apache Airflow secrets backend settings, which are exceptions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AIRFLOW__WORKERS__SECRETS_BACKEND</c> – The secrets backend class that workers
        /// use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AIRFLOW__WORKERS__SECRETS_BACKEND_KWARGS</c> – The keyword arguments for the secrets
        /// backend, as a JSON string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AIRFLOW__WORKERS__SECRETS_BACKEND_KWARG__*</c> – Names with this prefix, for additional
        /// secrets backend configuration.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you set <c>EncryptionConfiguration</c> to use a customer managed AWS KMS key, we
        /// encrypt the environment variables with that key. Otherwise, we store them with default
        /// encryption at rest.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Variables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Variables property is set.
        /// </summary>
        internal bool IsSetVariables() => this.Variables != null && (this.Variables.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
