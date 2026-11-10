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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the CreateLaunchTemplateVersion operation.
    /// </summary>
    public partial class CreateLaunchTemplateVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property LaunchTemplateVersion. 
        /// <para>
        /// Information about the launch template version.
        /// </para>
        /// </summary>
        public LaunchTemplateVersion LaunchTemplateVersion { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplateVersion property is set.
        /// </summary>
        internal bool IsSetLaunchTemplateVersion() => this.LaunchTemplateVersion != null;

        /// <summary>
        /// Gets and sets the property Warning. 
        /// <para>
        /// If the new version of the launch template contains parameters or parameter combinations
        /// that are not valid, an error code and an error message are returned for each issue
        /// that's found.
        /// </para>
        /// </summary>
        public ValidationWarning Warning { get; set; }

        /// <summary>
        /// Checks to see if the Warning property is set.
        /// </summary>
        internal bool IsSetWarning() => this.Warning != null;
    }
}
