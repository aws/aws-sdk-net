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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the CreateFramework operation.
    /// </summary>
    public partial class CreateFrameworkResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FrameworkArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a resource. The format of the
        /// ARN depends on the resource type.
        /// </para>
        /// </summary>
        public string FrameworkArn { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkArn property is set.
        /// </summary>
        internal bool IsSetFrameworkArn() => this.FrameworkArn != null;

        /// <summary>
        /// Gets and sets the property FrameworkName. 
        /// <para>
        /// The unique name of the framework. The name must be between 1 and 256 characters, starting
        /// with a letter, and consisting of letters (a-z, A-Z), numbers (0-9), and underscores
        /// (_).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string FrameworkName { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkName property is set.
        /// </summary>
        internal bool IsSetFrameworkName() => this.FrameworkName != null;
    }
}
