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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about an external code repository with which you can connect your Amazon
    /// Web Services resources. The connection is established through Amazon Inspector.
    /// </summary>
    public partial class CodeRepositoryDetails
    {
        /// <summary>
        /// Gets and sets the property CodeSecurityIntegrationArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the code security integration associated with the
        /// repository. 
        /// </para>
        /// </summary>
        public string CodeSecurityIntegrationArn { get; set; }

        /// <summary>
        /// Checks to see if the CodeSecurityIntegrationArn property is set.
        /// </summary>
        internal bool IsSetCodeSecurityIntegrationArn() => this.CodeSecurityIntegrationArn != null;

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        ///  The name of the project in the code repository. 
        /// </para>
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// Checks to see if the ProjectName property is set.
        /// </summary>
        internal bool IsSetProjectName() => this.ProjectName != null;

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        ///  The type of repository provider. 
        /// </para>
        /// </summary>
        public string ProviderType { get; set; }

        /// <summary>
        /// Checks to see if the ProviderType property is set.
        /// </summary>
        internal bool IsSetProviderType() => this.ProviderType != null;
    }
}
