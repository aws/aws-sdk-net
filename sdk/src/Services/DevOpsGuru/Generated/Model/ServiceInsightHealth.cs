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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Contains the number of open proactive and reactive insights in an analyzed Amazon
    /// Web Services service.
    /// </summary>
    public partial class ServiceInsightHealth
    {
        private int? _openProactiveInsights;
        private int? _openReactiveInsights;

        /// <summary>
        /// Gets and sets the property OpenProactiveInsights. 
        /// <para>
        /// The number of open proactive insights in the Amazon Web Services service
        /// </para>
        /// </summary>
        public int? OpenProactiveInsights
        {
            get { return this._openProactiveInsights; }
            set { this._openProactiveInsights = value; }
        }

        // Check to see if OpenProactiveInsights property is set
        internal bool IsSetOpenProactiveInsights()
        {
            return this._openProactiveInsights.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpenReactiveInsights. 
        /// <para>
        /// The number of open reactive insights in the Amazon Web Services service
        /// </para>
        /// </summary>
        public int? OpenReactiveInsights
        {
            get { return this._openReactiveInsights; }
            set { this._openReactiveInsights = value; }
        }

        // Check to see if OpenReactiveInsights property is set
        internal bool IsSetOpenReactiveInsights()
        {
            return this._openReactiveInsights.HasValue; 
        }

    }
}