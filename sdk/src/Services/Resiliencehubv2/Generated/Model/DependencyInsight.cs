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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Contains a single insight about a service's dependencies.
    /// </summary>
    public partial class DependencyInsight
    {
        private InsightsCategory _category;
        private string _description;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the insight. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CROSS_REGION - The insight relates to dependencies used across multiple Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NEW_DEPENDENCY - The insight relates to a recently detected dependency.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// THIRD_PARTY - The insight relates to a third-party dependency.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNEVEN_USAGE - The insight relates to a dependency with uneven usage across the service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS_SERVICE - The insight relates to a dependency on an Amazon Web Services service.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public InsightsCategory Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable explanation of the insight, describing the dependency behavior or
        /// condition that was detected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

    }
}