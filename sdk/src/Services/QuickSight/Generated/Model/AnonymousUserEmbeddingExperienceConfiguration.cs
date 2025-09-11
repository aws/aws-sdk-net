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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The type of experience you want to embed. For anonymous users, you can embed QuickSight
    /// dashboards.
    /// </summary>
    public partial class AnonymousUserEmbeddingExperienceConfiguration
    {
        private AnonymousUserDashboardEmbeddingConfiguration _dashboard;
        private AnonymousUserDashboardVisualEmbeddingConfiguration _dashboardVisual;
        private AnonymousUserGenerativeQnAEmbeddingConfiguration _generativeQnA;
        private AnonymousUserQSearchBarEmbeddingConfiguration _qSearchBar;

        /// <summary>
        /// Gets and sets the property Dashboard. 
        /// <para>
        /// The type of embedding experience. In this case, QuickSight dashboards.
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

        /// <summary>
        /// Gets and sets the property DashboardVisual. 
        /// <para>
        /// The type of embedding experience. In this case, QuickSight visuals.
        /// </para>
        /// </summary>
        public AnonymousUserDashboardVisualEmbeddingConfiguration DashboardVisual
        {
            get { return this._dashboardVisual; }
            set { this._dashboardVisual = value; }
        }

        // Check to see if DashboardVisual property is set
        internal bool IsSetDashboardVisual()
        {
            return this._dashboardVisual != null;
        }

        /// <summary>
        /// Gets and sets the property GenerativeQnA. 
        /// <para>
        /// The Generative Q&amp;A experience that you want to use for anonymous user embedding.
        /// </para>
        /// </summary>
        public AnonymousUserGenerativeQnAEmbeddingConfiguration GenerativeQnA
        {
            get { return this._generativeQnA; }
            set { this._generativeQnA = value; }
        }

        // Check to see if GenerativeQnA property is set
        internal bool IsSetGenerativeQnA()
        {
            return this._generativeQnA != null;
        }

        /// <summary>
        /// Gets and sets the property QSearchBar. 
        /// <para>
        /// The Q search bar that you want to use for anonymous user embedding.
        /// </para>
        /// </summary>
        public AnonymousUserQSearchBarEmbeddingConfiguration QSearchBar
        {
            get { return this._qSearchBar; }
            set { this._qSearchBar = value; }
        }

        // Check to see if QSearchBar property is set
        internal bool IsSetQSearchBar()
        {
            return this._qSearchBar != null;
        }

    }
}