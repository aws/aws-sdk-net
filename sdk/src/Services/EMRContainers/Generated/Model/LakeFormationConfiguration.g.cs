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

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Lake Formation related configuration inputs for the security configuration.
    /// </summary>
    public partial class LakeFormationConfiguration
    {
        /// <summary>
        /// Gets and sets the property AuthorizedSessionTagValue. 
        /// <para>
        /// The session tag to authorize Amazon EMR on EKS for API calls to Lake Formation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string AuthorizedSessionTagValue { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizedSessionTagValue property is set.
        /// </summary>
        internal bool IsSetAuthorizedSessionTagValue() => this.AuthorizedSessionTagValue != null;

        /// <summary>
        /// Gets and sets the property QueryEngineRoleArn. 
        /// <para>
        /// The query engine IAM role ARN that is tied to the secure Spark job. The <c>QueryEngine</c>
        /// role assumes the <c>JobExecutionRole</c> to execute all the Lake Formation calls.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string QueryEngineRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the QueryEngineRoleArn property is set.
        /// </summary>
        internal bool IsSetQueryEngineRoleArn() => this.QueryEngineRoleArn != null;

        /// <summary>
        /// Gets and sets the property SecureNamespaceInfo. 
        /// <para>
        /// The namespace input of the system job.
        /// </para>
        /// </summary>
        public SecureNamespaceInfo SecureNamespaceInfo { get; set; }

        /// <summary>
        /// Checks to see if the SecureNamespaceInfo property is set.
        /// </summary>
        internal bool IsSetSecureNamespaceInfo() => this.SecureNamespaceInfo != null;
    }
}
