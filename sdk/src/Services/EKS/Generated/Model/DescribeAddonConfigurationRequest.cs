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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAddonConfiguration operation.
    /// Returns configuration options.
    /// </summary>
    public partial class DescribeAddonConfigurationRequest : AmazonEKSRequest
    {
        private string _addonName;
        private string _addonVersion;

        /// <summary>
        /// Gets and sets the property AddonName. 
        /// <para>
        /// The name of the add-on. The name must match one of the names that <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_DescribeAddonVersions.html">
        /// <code>DescribeAddonVersions</code> </a> returns.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AddonName
        {
            get { return this._addonName; }
            set { this._addonName = value; }
        }

        // Check to see if AddonName property is set
        internal bool IsSetAddonName()
        {
            return this._addonName != null;
        }

        /// <summary>
        /// Gets and sets the property AddonVersion. 
        /// <para>
        /// The version of the add-on. The version must match one of the versions returned by
        /// <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_DescribeAddonVersions.html">
        /// <code>DescribeAddonVersions</code> </a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AddonVersion
        {
            get { return this._addonVersion; }
            set { this._addonVersion = value; }
        }

        // Check to see if AddonVersion property is set
        internal bool IsSetAddonVersion()
        {
            return this._addonVersion != null;
        }

    }
}