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
    /// The type of experience you want to embed. For anonymous users, you can embed an Amazon
    /// QuickSight dashboard.
    /// </summary>
    public partial class AnonymousUserEmbeddingExperienceConfiguration
    {
        private AnonymousUserDashboardEmbeddingConfiguration _dashboard;

        /// <summary>
        /// Gets and sets the property Dashboard. 
        /// <para>
        /// The type of embedding experience. In this case, an Amazon QuickSight dashboard.
        /// </para>
        /// </summary>
        public AnonymousUserDashboardEmbeddingConfiguration Dashboard
        {
            get { return this._dashboard; }
            set { this._dashboard = value; }
        }

        // Check to see if Dashboard property is set
        internal bool IsSetDashboard()
        {
            return this._dashboard != null;
        }

    }
}