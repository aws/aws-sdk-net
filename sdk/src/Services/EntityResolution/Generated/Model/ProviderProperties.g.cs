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

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// An object containing the <c>providerServiceARN</c>, <c>intermediateSourceConfiguration</c>,
    /// and <c>providerConfiguration</c>.
    /// </summary>
    public partial class ProviderProperties
    {
        /// <summary>
        /// Gets and sets the property IntermediateSourceConfiguration. 
        /// <para>
        /// The Amazon S3 location that temporarily stores your data while it processes. Your
        /// information won't be saved permanently.
        /// </para>
        /// </summary>
        public IntermediateSourceConfiguration IntermediateSourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IntermediateSourceConfiguration property is set.
        /// </summary>
        internal bool IsSetIntermediateSourceConfiguration() => this.IntermediateSourceConfiguration != null;

        /// <summary>
        /// Gets and sets the property ProviderConfiguration. 
        /// <para>
        /// The required configuration fields to use with the provider service.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document ProviderConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProviderConfiguration property is set.
        /// </summary>
        internal bool IsSetProviderConfiguration() => !this.ProviderConfiguration.IsNull();

        /// <summary>
        /// Gets and sets the property ProviderServiceArn. 
        /// <para>
        /// The ARN of the provider service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 255)]
        public string ProviderServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ProviderServiceArn property is set.
        /// </summary>
        internal bool IsSetProviderServiceArn() => this.ProviderServiceArn != null;
    }
}
