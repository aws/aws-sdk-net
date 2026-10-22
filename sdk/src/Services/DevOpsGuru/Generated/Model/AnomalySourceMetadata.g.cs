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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Metadata about the detection source that generates proactive anomalies. The anomaly
    /// is detected using analysis of the metric data over a period of time
    /// </summary>
    public partial class AnomalySourceMetadata
    {
        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the anomaly.
        /// </para>
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SourceResourceName. 
        /// <para>
        /// The name of the anomaly's resource.
        /// </para>
        /// </summary>
        public string SourceResourceName { get; set; }

        /// <summary>
        /// Checks to see if the SourceResourceName property is set.
        /// </summary>
        internal bool IsSetSourceResourceName() => this.SourceResourceName != null;

        /// <summary>
        /// Gets and sets the property SourceResourceType. 
        /// <para>
        /// The anomaly's resource type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string SourceResourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceResourceType property is set.
        /// </summary>
        internal bool IsSetSourceResourceType() => this.SourceResourceType != null;
    }
}
