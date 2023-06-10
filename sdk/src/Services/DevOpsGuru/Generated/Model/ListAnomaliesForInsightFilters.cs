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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Specifies one or more service names that are used to list anomalies.
    /// </summary>
    public partial class ListAnomaliesForInsightFilters
    {
        private ServiceCollection _serviceCollection;

        /// <summary>
        /// Gets and sets the property ServiceCollection.
        /// </summary>
        public ServiceCollection ServiceCollection
        {
            get { return this._serviceCollection; }
            set { this._serviceCollection = value; }
        }

        // Check to see if ServiceCollection property is set
        internal bool IsSetServiceCollection()
        {
            return this._serviceCollection != null;
        }

    }
}