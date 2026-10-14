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

namespace Amazon.B2bi.Model
{
    /// <summary>
    /// This is the response object from the GenerateMapping operation.
    /// </summary>
    public partial class GenerateMappingResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property MappingAccuracy. 
        /// <para>
        /// Returns a percentage that estimates the accuracy of the generated mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public float? MappingAccuracy { get; set; }

        /// <summary>
        /// Checks to see if the MappingAccuracy property is set.
        /// </summary>
        internal bool IsSetMappingAccuracy() => this.MappingAccuracy.HasValue;

        /// <summary>
        /// Gets and sets the property MappingTemplate. 
        /// <para>
        /// Returns a mapping template based on your inputs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MappingTemplate { get; set; }

        /// <summary>
        /// Checks to see if the MappingTemplate property is set.
        /// </summary>
        internal bool IsSetMappingTemplate() => this.MappingTemplate != null;
    }
}
