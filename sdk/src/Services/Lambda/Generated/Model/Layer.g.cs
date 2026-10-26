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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// An <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
    /// layer</a>.
    /// </summary>
    public partial class Layer
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the function layer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CodeSize. 
        /// <para>
        /// The size of the layer archive in bytes.
        /// </para>
        /// </summary>
        public long? CodeSize { get; set; }

        /// <summary>
        /// Checks to see if the CodeSize property is set.
        /// </summary>
        internal bool IsSetCodeSize() => this.CodeSize.HasValue;

        /// <summary>
        /// Gets and sets the property SigningJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a signing job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string SigningJobArn { get; set; }

        /// <summary>
        /// Checks to see if the SigningJobArn property is set.
        /// </summary>
        internal bool IsSetSigningJobArn() => this.SigningJobArn != null;

        /// <summary>
        /// Gets and sets the property SigningProfileVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for a signing profile version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string SigningProfileVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the SigningProfileVersionArn property is set.
        /// </summary>
        internal bool IsSetSigningProfileVersionArn() => this.SigningProfileVersionArn != null;
    }
}
