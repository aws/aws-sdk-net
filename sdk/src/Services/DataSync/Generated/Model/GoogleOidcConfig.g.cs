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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// External identity parameters for Google Cloud Storage.
    /// </summary>
    public partial class GoogleOidcConfig
    {
        /// <summary>
        /// Gets and sets the property IdentityPoolName. 
        /// <para>
        /// Human-readable pool name (e.g. "my-pool").
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 32)]
        public string IdentityPoolName { get; set; }

        /// <summary>
        /// Checks to see if the IdentityPoolName property is set.
        /// </summary>
        internal bool IsSetIdentityPoolName() => this.IdentityPoolName != null;

        /// <summary>
        /// Gets and sets the property IdentityProviderName. 
        /// <para>
        /// Human-readable provider name (e.g. "my-oidc-provider").
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 32)]
        public string IdentityProviderName { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderName property is set.
        /// </summary>
        internal bool IsSetIdentityProviderName() => this.IdentityProviderName != null;

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// Human-readable project name (e.g. "my-project").
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 30)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Checks to see if the ProjectName property is set.
        /// </summary>
        internal bool IsSetProjectName() => this.ProjectName != null;

        /// <summary>
        /// Gets and sets the property ProjectNumber. 
        /// <para>
        /// Numeric project ID as a string (e.g. "123456789").
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string ProjectNumber { get; set; }

        /// <summary>
        /// Checks to see if the ProjectNumber property is set.
        /// </summary>
        internal bool IsSetProjectNumber() => this.ProjectNumber != null;
    }
}
