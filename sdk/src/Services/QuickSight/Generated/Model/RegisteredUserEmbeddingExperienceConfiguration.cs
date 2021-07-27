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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The type of experience you want to embed. For registered users, you can embed an Amazon
    /// QuickSight dashboard or the Amazon QuickSight console.
    /// 
    ///  <note> 
    /// <para>
    /// Exactly one of the experience configurations is required. You can choose <code>Dashboard</code>
    /// or <code>QuickSightConsole</code>. You cannot choose more than one experience configuraton.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RegisteredUserEmbeddingExperienceConfiguration
    {
        private RegisteredUserDashboardEmbeddingConfiguration _dashboard;
        private RegisteredUserQuickSightConsoleEmbeddingConfiguration _quickSightConsole;

        /// <summary>
        /// Gets and sets the property Dashboard. 
        /// <para>
        /// The configuration details for providing a dashboard embedding experience.
        /// </para>
        /// </summary>
        public RegisteredUserDashboardEmbeddingConfiguration Dashboard
        {
            get { return this._dashboard; }
            set { this._dashboard = value; }
        }

        // Check to see if Dashboard property is set
        internal bool IsSetDashboard()
        {
            return this._dashboard != null;
        }

        /// <summary>
        /// Gets and sets the property QuickSightConsole. 
        /// <para>
        /// The configuration details for providing an Amazon QuickSight console embedding experience.
        /// This can be used along with custom permissions to restrict access to certain features.
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/customizing-permissions-to-the-quicksight-console.html">Customizing
        /// Access to the Amazon QuickSight Console</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Use <code>GenerateEmbedUrlForRegisteredUser</code> where you want to provide an authoring
        /// portal that allows users to create data sources, datasets, analyses, and dashboards.
        /// The users who accesses an embedded Amazon QuickSight console needs to belong to the
        /// author or admin security cohort. If you want to restrict permissions to some of these
        /// features, add a custom permissions profile to the user with the <code> <a>UpdateUser</a>
        /// </code> API operation. Use <code> <a>RegisterUser</a> </code> API operation to add
        /// a new user with a custom permission profile attached. For more information, see the
        /// following sections in the <i>Amazon QuickSight User Guide</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/quicksight/latest/user/embedded-analytics-full-console-for-authenticated-users.html">Embedding
        /// the Full Functionality of the Amazon QuickSight Console for Authenticated Users</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/quicksight/latest/user/customizing-permissions-to-the-quicksight-console.html">Customizing
        /// Access to the Amazon QuickSight Console</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about the high-level steps for embedding and for an interactive
        /// demo of the ways you can customize embedding, visit the <a href="https://docs.aws.amazon.com/quicksight/latest/user/quicksight-dev-portal.html">Amazon
        /// QuickSight Developer Portal</a>.
        /// </para>
        /// </summary>
        public RegisteredUserQuickSightConsoleEmbeddingConfiguration QuickSightConsole
        {
            get { return this._quickSightConsole; }
            set { this._quickSightConsole = value; }
        }

        // Check to see if QuickSightConsole property is set
        internal bool IsSetQuickSightConsole()
        {
            return this._quickSightConsole != null;
        }

    }
}