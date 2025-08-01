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
    /// Details about an external code repository with which you can connect your Amazon
    /// Web Services resources. The connection is established through Amazon Inspector.
    /// </summary>
    public partial class CodeRepositoryDetails
    {
        private string _codeSecurityIntegrationArn;
        private string _projectName;
        private string _providerType;

        /// <summary>
        /// Gets and sets the property CodeSecurityIntegrationArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the code security integration associated with the
        /// repository. 
        /// </para>
        /// </summary>
        public string CodeSecurityIntegrationArn
        {
            get { return this._codeSecurityIntegrationArn; }
            set { this._codeSecurityIntegrationArn = value; }
        }

        // Check to see if CodeSecurityIntegrationArn property is set
        internal bool IsSetCodeSecurityIntegrationArn()
        {
            return this._codeSecurityIntegrationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        ///  The name of the project in the code repository. 
        /// </para>
        /// </summary>
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        ///  The type of repository provider. 
        /// </para>
        /// </summary>
        public string ProviderType
        {
            get { return this._providerType; }
            set { this._providerType = value; }
        }

        // Check to see if ProviderType property is set
        internal bool IsSetProviderType()
        {
            return this._providerType != null;
        }

    }
}