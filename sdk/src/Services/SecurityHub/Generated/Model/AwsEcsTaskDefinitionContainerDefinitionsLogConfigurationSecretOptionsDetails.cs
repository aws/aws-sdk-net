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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A secret to pass to the log configuration.
    /// </summary>
    public partial class AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationSecretOptionsDetails
    {
        private string _name;
        private string _valueFrom;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the secret.
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
        /// Gets and sets the property ValueFrom. 
        /// <para>
        /// The secret to expose to the container.
        /// </para>
        ///  
        /// <para>
        /// The value is either the full ARN of the Secrets Manager secret or the full ARN of
        /// the parameter in the Systems Manager Parameter Store.
        /// </para>
        /// </summary>
        public string ValueFrom
        {
            get { return this._valueFrom; }
            set { this._valueFrom = value; }
        }

        // Check to see if ValueFrom property is set
        internal bool IsSetValueFrom()
        {
            return this._valueFrom != null;
        }

    }
}