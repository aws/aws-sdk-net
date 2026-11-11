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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains the use case.
    /// </summary>
    public partial class UseCase
    {
        /// <summary>
        /// Gets and sets the property UseCaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the use case.
        /// </para>
        /// </summary>
        public string UseCaseArn { get; set; }

        /// <summary>
        /// Checks to see if the UseCaseArn property is set.
        /// </summary>
        internal bool IsSetUseCaseArn() => this.UseCaseArn != null;

        /// <summary>
        /// Gets and sets the property UseCaseId. 
        /// <para>
        /// The identifier for the use case.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string UseCaseId { get; set; }

        /// <summary>
        /// Checks to see if the UseCaseId property is set.
        /// </summary>
        internal bool IsSetUseCaseId() => this.UseCaseId != null;

        /// <summary>
        /// Gets and sets the property UseCaseType. 
        /// <para>
        /// The type of use case to associate to the integration association. Each integration
        /// association can have only one of each use case type.
        /// </para>
        /// </summary>
        public UseCaseType UseCaseType { get; set; }

        /// <summary>
        /// Checks to see if the UseCaseType property is set.
        /// </summary>
        internal bool IsSetUseCaseType() => this.UseCaseType != null;
    }
}
