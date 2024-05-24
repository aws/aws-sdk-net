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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
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
        private string _authorizedSessionTagValue;
        private string _queryEngineRoleArn;
        private SecureNamespaceInfo _secureNamespaceInfo;

        /// <summary>
        /// Gets and sets the property AuthorizedSessionTagValue. 
        /// <para>
        /// The session tag to authorize Amazon EMR on EKS for API calls to Lake Formation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string AuthorizedSessionTagValue
        {
            get { return this._authorizedSessionTagValue; }
            set { this._authorizedSessionTagValue = value; }
        }

        // Check to see if AuthorizedSessionTagValue property is set
        internal bool IsSetAuthorizedSessionTagValue()
        {
            return this._authorizedSessionTagValue != null;
        }

        /// <summary>
        /// Gets and sets the property QueryEngineRoleArn. 
        /// <para>
        /// The query engine IAM role ARN that is tied to the secure Spark job. The <c>QueryEngine</c>
        /// role assumes the <c>JobExecutionRole</c> to execute all the Lake Formation calls.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string QueryEngineRoleArn
        {
            get { return this._queryEngineRoleArn; }
            set { this._queryEngineRoleArn = value; }
        }

        // Check to see if QueryEngineRoleArn property is set
        internal bool IsSetQueryEngineRoleArn()
        {
            return this._queryEngineRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecureNamespaceInfo. 
        /// <para>
        /// The namespace input of the system job.
        /// </para>
        /// </summary>
        public SecureNamespaceInfo SecureNamespaceInfo
        {
            get { return this._secureNamespaceInfo; }
            set { this._secureNamespaceInfo = value; }
        }

        // Check to see if SecureNamespaceInfo property is set
        internal bool IsSetSecureNamespaceInfo()
        {
            return this._secureNamespaceInfo != null;
        }

    }
}