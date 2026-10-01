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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The type of experience you want to embed. For anonymous users, you can embed Quick
    /// dashboards.
    /// </summary>
    public partial class AnonymousUserEmbeddingExperienceConfiguration
    {
        /// <summary>
        /// Gets and sets the property Dashboard. 
        /// <para>
        /// The type of embedding experience. In this case, Amazon Quick Sight dashboards.
        /// </para>
        /// </summary>
        public AnonymousUserDashboardEmbeddingConfiguration Dashboard { get; set; }

        /// <summary>
        /// Checks to see if the Dashboard property is set.
        /// </summary>
        internal bool IsSetDashboard() => this.Dashboard != null;

        /// <summary>
        /// Gets and sets the property DashboardVisual. 
        /// <para>
        /// The type of embedding experience. In this case, Amazon Quick Sight visuals.
        /// </para>
        /// </summary>
        public AnonymousUserDashboardVisualEmbeddingConfiguration DashboardVisual { get; set; }

        /// <summary>
        /// Checks to see if the DashboardVisual property is set.
        /// </summary>
        internal bool IsSetDashboardVisual() => this.DashboardVisual != null;

        /// <summary>
        /// Gets and sets the property GenerativeQnA. 
        /// <para>
        /// The Generative Q&amp;A experience that you want to use for anonymous user embedding.
        /// </para>
        /// </summary>
        public AnonymousUserGenerativeQnAEmbeddingConfiguration GenerativeQnA { get; set; }

        /// <summary>
        /// Checks to see if the GenerativeQnA property is set.
        /// </summary>
        internal bool IsSetGenerativeQnA() => this.GenerativeQnA != null;

        /// <summary>
        /// Gets and sets the property QSearchBar. 
        /// <para>
        /// The Q search bar that you want to use for anonymous user embedding.
        /// </para>
        /// </summary>
        public AnonymousUserQSearchBarEmbeddingConfiguration QSearchBar { get; set; }

        /// <summary>
        /// Checks to see if the QSearchBar property is set.
        /// </summary>
        internal bool IsSetQSearchBar() => this.QSearchBar != null;
    }
}
