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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about the build badge for the build project.
    /// </summary>
    public partial class ProjectBadge
    {
        private bool? _badgeEnabled;
        private string _badgeRequestUrl;

        /// <summary>
        /// Gets and sets the property BadgeEnabled. 
        /// <para>
        /// Set this to true to generate a publicly accessible URL for your project's build badge.
        /// </para>
        /// </summary>
        public bool? BadgeEnabled
        {
            get { return this._badgeEnabled; }
            set { this._badgeEnabled = value; }
        }

        // Check to see if BadgeEnabled property is set
        internal bool IsSetBadgeEnabled()
        {
            return this._badgeEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BadgeRequestUrl. 
        /// <para>
        /// The publicly-accessible URL through which you can access the build badge for your
        /// project. 
        /// </para>
        /// </summary>
        public string BadgeRequestUrl
        {
            get { return this._badgeRequestUrl; }
            set { this._badgeRequestUrl = value; }
        }

        // Check to see if BadgeRequestUrl property is set
        internal bool IsSetBadgeRequestUrl()
        {
            return this._badgeRequestUrl != null;
        }

    }
}