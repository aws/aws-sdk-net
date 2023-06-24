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
    /// Container for the parameters to the UpdateOrgEc2DeepInspectionConfiguration operation.
    /// Updates the Amazon Inspector deep inspection custom paths for your organization. You
    /// must be an Amazon Inspector delegated administrator to use this API.
    /// </summary>
    public partial class UpdateOrgEc2DeepInspectionConfigurationRequest : AmazonInspector2Request
    {
        private List<string> _orgPackagePaths = new List<string>();

        /// <summary>
        /// Gets and sets the property OrgPackagePaths. 
        /// <para>
        /// The Amazon Inspector deep inspection custom paths you are adding for your organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=5)]
        public List<string> OrgPackagePaths
        {
            get { return this._orgPackagePaths; }
            set { this._orgPackagePaths = value; }
        }

        // Check to see if OrgPackagePaths property is set
        internal bool IsSetOrgPackagePaths()
        {
            return this._orgPackagePaths != null && this._orgPackagePaths.Count > 0; 
        }

    }
}