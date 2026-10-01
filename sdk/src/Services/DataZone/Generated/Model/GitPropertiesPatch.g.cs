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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The properties used to update an existing Git connection, such as the CodeConnections
    /// ARN or the default branch.
    /// </summary>
    public partial class GitPropertiesPatch
    {
        /// <summary>
        /// Gets and sets the property CodeConnectionArn. 
        /// <para>
        /// The ARN of the CodeConnections connection used to connect to the Git repository.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
        public string CodeConnectionArn { get; set; }

        /// <summary>
        /// Checks to see if the CodeConnectionArn property is set.
        /// </summary>
        internal bool IsSetCodeConnectionArn() => this.CodeConnectionArn != null;

        /// <summary>
        /// Gets and sets the property DefaultBranch. 
        /// <para>
        /// The default branch of the Git repository.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
        public string DefaultBranch { get; set; }

        /// <summary>
        /// Checks to see if the DefaultBranch property is set.
        /// </summary>
        internal bool IsSetDefaultBranch() => this.DefaultBranch != null;
    }
}
