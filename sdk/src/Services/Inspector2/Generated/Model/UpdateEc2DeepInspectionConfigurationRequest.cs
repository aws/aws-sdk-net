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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEc2DeepInspectionConfiguration operation.
    /// Activates, deactivates Amazon Inspector deep inspection, or updates custom paths for
    /// your account.
    /// </summary>
    public partial class UpdateEc2DeepInspectionConfigurationRequest : AmazonInspector2Request
    {
        private bool? _activateDeepInspection;
        private List<string> _packagePaths = new List<string>();

        /// <summary>
        /// Gets and sets the property ActivateDeepInspection. 
        /// <para>
        /// Specify <code>TRUE</code> to activate Amazon Inspector deep inspection in your account,
        /// or <code>FALSE</code> to deactivate. Member accounts in an organization cannot deactivate
        /// deep inspection, instead the delegated administrator for the organization can deactivate
        /// a member account using <a href="https://docs.aws.amazon.com/inspector/v2/APIReference/API_BatchUpdateMemberEc2DeepInspectionStatus.html">BatchUpdateMemberEc2DeepInspectionStatus</a>.
        /// </para>
        /// </summary>
        public bool ActivateDeepInspection
        {
            get { return this._activateDeepInspection.GetValueOrDefault(); }
            set { this._activateDeepInspection = value; }
        }

        // Check to see if ActivateDeepInspection property is set
        internal bool IsSetActivateDeepInspection()
        {
            return this._activateDeepInspection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PackagePaths. 
        /// <para>
        /// The Amazon Inspector deep inspection custom paths you are adding for your account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> PackagePaths
        {
            get { return this._packagePaths; }
            set { this._packagePaths = value; }
        }

        // Check to see if PackagePaths property is set
        internal bool IsSetPackagePaths()
        {
            return this._packagePaths != null && this._packagePaths.Count > 0; 
        }

    }
}