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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains details required to create a code security integration with a specific repository
    /// provider.
    /// </summary>
    public partial class CreateIntegrationDetail
    {
        private CreateGitLabSelfManagedIntegrationDetail _gitlabSelfManaged;

        /// <summary>
        /// Gets and sets the property GitlabSelfManaged. 
        /// <para>
        /// Details specific to creating an integration with a self-managed GitLab instance.
        /// </para>
        /// </summary>
        public CreateGitLabSelfManagedIntegrationDetail GitlabSelfManaged
        {
            get { return this._gitlabSelfManaged; }
            set { this._gitlabSelfManaged = value; }
        }

        // Check to see if GitlabSelfManaged property is set
        internal bool IsSetGitlabSelfManaged()
        {
            return this._gitlabSelfManaged != null;
        }

    }
}