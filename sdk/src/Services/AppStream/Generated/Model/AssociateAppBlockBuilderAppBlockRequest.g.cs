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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateAppBlockBuilderAppBlock operation. Associates
    /// the specified app block builder with the specified app block.
    /// </summary>
    public partial class AssociateAppBlockBuilderAppBlockRequest : AmazonAppStreamRequest
    {
        /// <summary>
        /// Gets and sets the property AppBlockArn. 
        /// <para>
        /// The ARN of the app block.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AppBlockArn { get; set; }

        /// <summary>
        /// Checks to see if the AppBlockArn property is set.
        /// </summary>
        internal bool IsSetAppBlockArn() => this.AppBlockArn != null;

        /// <summary>
        /// Gets and sets the property AppBlockBuilderName. 
        /// <para>
        /// The name of the app block builder.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AppBlockBuilderName { get; set; }

        /// <summary>
        /// Checks to see if the AppBlockBuilderName property is set.
        /// </summary>
        internal bool IsSetAppBlockBuilderName() => this.AppBlockBuilderName != null;
    }
}
