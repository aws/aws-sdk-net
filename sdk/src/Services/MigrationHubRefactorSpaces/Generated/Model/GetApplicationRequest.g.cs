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

namespace Amazon.MigrationHubRefactorSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the GetApplication operation. Gets an Amazon Web Services
    /// Migration Hub Refactor Spaces application.
    /// </summary>
    public partial class GetApplicationRequest : AmazonMigrationHubRefactorSpacesRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationIdentifier. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 14, Max = 14)]
        public string ApplicationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationIdentifier property is set.
        /// </summary>
        internal bool IsSetApplicationIdentifier() => this.ApplicationIdentifier != null;

        /// <summary>
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        /// The ID of the environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 14, Max = 14)]
        public string EnvironmentIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentIdentifier property is set.
        /// </summary>
        internal bool IsSetEnvironmentIdentifier() => this.EnvironmentIdentifier != null;
    }
}
