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
    /// The experience that you are embedding. You can use this object to generate a url that
    /// embeds a visual into your application.
    /// </summary>
    public partial class AnonymousUserDashboardVisualEmbeddingConfiguration
    {
        private DashboardVisualId _initialDashboardVisualId;

        /// <summary>
        /// Gets and sets the property InitialDashboardVisualId. 
        /// <para>
        /// The visual ID for the visual that you want the user to see. This ID is included in
        /// the output URL. When the URL in response is accessed, QuickSight renders this visual.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Resource Name (ARN) of the dashboard that the visual belongs to must be
        /// included in the <c>AuthorizedResourceArns</c> parameter. Otherwise, the request will
        /// fail with <c>InvalidParameterValueException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DashboardVisualId InitialDashboardVisualId
        {
            get { return this._initialDashboardVisualId; }
            set { this._initialDashboardVisualId = value; }
        }

        // Check to see if InitialDashboardVisualId property is set
        internal bool IsSetInitialDashboardVisualId()
        {
            return this._initialDashboardVisualId != null;
        }

    }
}