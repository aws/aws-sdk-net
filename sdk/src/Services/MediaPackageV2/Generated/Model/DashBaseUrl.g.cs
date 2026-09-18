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

namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// The base URLs to use for retrieving segments. You can specify multiple locations and
    /// indicate the priority and weight for when each should be used, for use in mutli-CDN
    /// workflows.
    /// </summary>
    public partial class DashBaseUrl
    {
        /// <summary>
        /// Gets and sets the property DvbPriority. 
        /// <para>
        /// For use with DVB-DASH profiles only. The priority of this location for servings segments.
        /// The lower the number, the higher the priority.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 15000)]
        public int? DvbPriority { get; set; }

        /// <summary>
        /// Checks to see if the DvbPriority property is set.
        /// </summary>
        internal bool IsSetDvbPriority() => this.DvbPriority.HasValue;

        /// <summary>
        /// Gets and sets the property DvbWeight. 
        /// <para>
        /// For use with DVB-DASH profiles only. The weighting for source locations that have
        /// the same priority. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 15000)]
        public int? DvbWeight { get; set; }

        /// <summary>
        /// Checks to see if the DvbWeight property is set.
        /// </summary>
        internal bool IsSetDvbWeight() => this.DvbWeight.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceLocation. 
        /// <para>
        /// The name of the source location.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ServiceLocation { get; set; }

        /// <summary>
        /// Checks to see if the ServiceLocation property is set.
        /// </summary>
        internal bool IsSetServiceLocation() => this.ServiceLocation != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// A source location for segments.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
