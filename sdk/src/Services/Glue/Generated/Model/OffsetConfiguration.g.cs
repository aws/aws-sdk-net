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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Offset-based pagination configuration that defines how to handle pagination using
    /// numeric offsets and limits.
    /// </summary>
    public partial class OffsetConfiguration
    {
        /// <summary>
        /// Gets and sets the property LimitParameter. 
        /// <para>
        /// The parameter name used to specify the maximum number of results to return per page.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExtractedParameter LimitParameter { get; set; }

        /// <summary>
        /// Checks to see if the LimitParameter property is set.
        /// </summary>
        internal bool IsSetLimitParameter() => this.LimitParameter != null;

        /// <summary>
        /// Gets and sets the property OffsetParameter. 
        /// <para>
        /// The parameter name used to specify the starting position or offset for retrieving
        /// results.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExtractedParameter OffsetParameter { get; set; }

        /// <summary>
        /// Checks to see if the OffsetParameter property is set.
        /// </summary>
        internal bool IsSetOffsetParameter() => this.OffsetParameter != null;
    }
}
