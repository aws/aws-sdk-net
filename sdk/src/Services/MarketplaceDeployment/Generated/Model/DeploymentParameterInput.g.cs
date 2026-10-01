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

namespace Amazon.MarketplaceDeployment.Model
{
    /// <summary>
    /// The shape containing the requested deployment parameter name and secretString.
    /// 
    ///  <note> 
    /// <para>
    /// To support AWS CloudFormation dynamic references to this resource using Quick Launch,
    /// this value must match a parameter defined in the CloudFormation templated provided
    /// to buyers.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeploymentParameterInput
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The desired name of the deployment parameter. This is the identifier on which deployment
        /// parameters are keyed for a given buyer and product. If this name matches an existing
        /// deployment parameter, this request will update the existing resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 400)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SecretString. 
        /// <para>
        /// The text to encrypt and store in the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 15000)]
        public string SecretString { get; set; }

        /// <summary>
        /// Checks to see if the SecretString property is set.
        /// </summary>
        internal bool IsSetSecretString() => this.SecretString != null;
    }
}
