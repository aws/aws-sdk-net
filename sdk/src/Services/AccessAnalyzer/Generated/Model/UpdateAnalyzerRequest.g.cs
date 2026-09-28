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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAnalyzer operation. Modifies the configuration
    /// of an existing analyzer. <note> <para> This action is not supported for external access
    /// analyzers. </para> </note>
    /// </summary>
    public partial class UpdateAnalyzerRequest : AmazonAccessAnalyzerRequest
    {
        /// <summary>
        /// Gets and sets the property AnalyzerName. 
        /// <para>
        /// The name of the analyzer to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AnalyzerName { get; set; }

        /// <summary>
        /// Checks to see if the AnalyzerName property is set.
        /// </summary>
        internal bool IsSetAnalyzerName() => this.AnalyzerName != null;

        /// <summary>
        /// Gets and sets the property Configuration.
        /// </summary>
        public AnalyzerConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;
    }
}
