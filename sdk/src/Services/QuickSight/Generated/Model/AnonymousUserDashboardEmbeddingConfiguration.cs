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
    /// Information about the dashboard that you want to embed.
    /// </summary>
    public partial class AnonymousUserDashboardEmbeddingConfiguration
    {
        private string _initialDashboardId;

        /// <summary>
        /// Gets and sets the property InitialDashboardId. 
        /// <para>
        /// The dashboard ID for the dashboard that you want the user to see first. This ID is
        /// included in the output URL. When the URL in response is accessed, Amazon QuickSight
        /// renders this dashboard.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Resource Name (ARN) of this dashboard must be included in the <c>AuthorizedResourceArns</c>
        /// parameter. Otherwise, the request will fail with <c>InvalidParameterValueException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string InitialDashboardId
        {
            get { return this._initialDashboardId; }
            set { this._initialDashboardId = value; }
        }

        // Check to see if InitialDashboardId property is set
        internal bool IsSetInitialDashboardId()
        {
            return this._initialDashboardId != null;
        }

    }
}