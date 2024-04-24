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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the CreateLaunchTemplateVersion operation.
    /// </summary>
    public partial class CreateLaunchTemplateVersionResponse : AmazonWebServiceResponse
    {
        private LaunchTemplateVersion _launchTemplateVersion;
        private ValidationWarning _warning;

        /// <summary>
        /// Gets and sets the property LaunchTemplateVersion. 
        /// <para>
        /// Information about the launch template version.
        /// </para>
        /// </summary>
        public LaunchTemplateVersion LaunchTemplateVersion
        {
            get { return this._launchTemplateVersion; }
            set { this._launchTemplateVersion = value; }
        }

        // Check to see if LaunchTemplateVersion property is set
        internal bool IsSetLaunchTemplateVersion()
        {
            return this._launchTemplateVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Warning. 
        /// <para>
        /// If the new version of the launch template contains parameters or parameter combinations
        /// that are not valid, an error code and an error message are returned for each issue
        /// that's found.
        /// </para>
        /// </summary>
        public ValidationWarning Warning
        {
            get { return this._warning; }
            set { this._warning = value; }
        }

        // Check to see if Warning property is set
        internal bool IsSetWarning()
        {
            return this._warning != null;
        }

    }
}