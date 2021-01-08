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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the CreateLaunchTemplate operation.
    /// </summary>
    public partial class CreateLaunchTemplateResponse : AmazonWebServiceResponse
    {
        private LaunchTemplate _launchTemplate;
        private ValidationWarning _warning;

        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// Information about the launch template.
        /// </para>
        /// </summary>
        public LaunchTemplate LaunchTemplate
        {
            get { return this._launchTemplate; }
            set { this._launchTemplate = value; }
        }

        // Check to see if LaunchTemplate property is set
        internal bool IsSetLaunchTemplate()
        {
            return this._launchTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property Warning. 
        /// <para>
        /// If the launch template contains parameters or parameter combinations that are not
        /// valid, an error code and an error message are returned for each issue that's found.
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