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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Contains information about an application-specific calculation result.
    /// </summary>
    public partial class CalculationResult
    {
        /// <summary>
        /// Gets and sets the property ResultS3Uri. 
        /// <para>
        /// The Amazon S3 location of the folder for the calculation results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ResultS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the ResultS3Uri property is set.
        /// </summary>
        internal bool IsSetResultS3Uri() => this.ResultS3Uri != null;

        /// <summary>
        /// Gets and sets the property ResultType. 
        /// <para>
        /// The data format of the calculation result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ResultType { get; set; }

        /// <summary>
        /// Checks to see if the ResultType property is set.
        /// </summary>
        internal bool IsSetResultType() => this.ResultType != null;

        /// <summary>
        /// Gets and sets the property StdErrorS3Uri. 
        /// <para>
        /// The Amazon S3 location of the <c>stderr</c> error messages file for the calculation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string StdErrorS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the StdErrorS3Uri property is set.
        /// </summary>
        internal bool IsSetStdErrorS3Uri() => this.StdErrorS3Uri != null;

        /// <summary>
        /// Gets and sets the property StdOutS3Uri. 
        /// <para>
        /// The Amazon S3 location of the <c>stdout</c> file for the calculation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string StdOutS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the StdOutS3Uri property is set.
        /// </summary>
        internal bool IsSetStdOutS3Uri() => this.StdOutS3Uri != null;
    }
}
