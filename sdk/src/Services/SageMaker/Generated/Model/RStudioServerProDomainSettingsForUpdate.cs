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
    /// A collection of settings that update the current configuration for the <code>RStudioServerPro</code>
    /// Domain-level app.
    /// </summary>
    public partial class RStudioServerProDomainSettingsForUpdate
    {
        private ResourceSpec _defaultResourceSpec;
        private string _domainExecutionRoleArn;
        private string _rStudioConnectUrl;
        private string _rStudioPackageManagerUrl;

        /// <summary>
        /// Gets and sets the property DefaultResourceSpec.
        /// </summary>
        public ResourceSpec DefaultResourceSpec
        {
            get { return this._defaultResourceSpec; }
            set { this._defaultResourceSpec = value; }
        }

        // Check to see if DefaultResourceSpec property is set
        internal bool IsSetDefaultResourceSpec()
        {
            return this._defaultResourceSpec != null;
        }

        /// <summary>
        /// Gets and sets the property DomainExecutionRoleArn. 
        /// <para>
        /// The execution role for the <code>RStudioServerPro</code> Domain-level app.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string DomainExecutionRoleArn
        {
            get { return this._domainExecutionRoleArn; }
            set { this._domainExecutionRoleArn = value; }
        }

        // Check to see if DomainExecutionRoleArn property is set
        internal bool IsSetDomainExecutionRoleArn()
        {
            return this._domainExecutionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RStudioConnectUrl. 
        /// <para>
        /// A URL pointing to an RStudio Connect server.
        /// </para>
        /// </summary>
        public string RStudioConnectUrl
        {
            get { return this._rStudioConnectUrl; }
            set { this._rStudioConnectUrl = value; }
        }

        // Check to see if RStudioConnectUrl property is set
        internal bool IsSetRStudioConnectUrl()
        {
            return this._rStudioConnectUrl != null;
        }

        /// <summary>
        /// Gets and sets the property RStudioPackageManagerUrl. 
        /// <para>
        /// A URL pointing to an RStudio Package Manager server.
        /// </para>
        /// </summary>
        public string RStudioPackageManagerUrl
        {
            get { return this._rStudioPackageManagerUrl; }
            set { this._rStudioPackageManagerUrl = value; }
        }

        // Check to see if RStudioPackageManagerUrl property is set
        internal bool IsSetRStudioPackageManagerUrl()
        {
            return this._rStudioPackageManagerUrl != null;
        }

    }
}