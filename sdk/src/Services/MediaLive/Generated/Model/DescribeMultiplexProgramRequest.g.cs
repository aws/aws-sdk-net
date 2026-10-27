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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeMultiplexProgram operation. Get the details
    /// for a program in a multiplex.
    /// </summary>
    public partial class DescribeMultiplexProgramRequest : AmazonMediaLiveRequest
    {
        /// <summary>
        /// Gets and sets the property MultiplexId. The ID of the multiplex that the program belongs
        /// to.
        /// </summary>
        [AWSProperty(Required = true)]
        public string MultiplexId { get; set; }

        /// <summary>
        /// Checks to see if the MultiplexId property is set.
        /// </summary>
        internal bool IsSetMultiplexId() => this.MultiplexId != null;

        /// <summary>
        /// Gets and sets the property ProgramName. The name of the program.
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProgramName { get; set; }

        /// <summary>
        /// Checks to see if the ProgramName property is set.
        /// </summary>
        internal bool IsSetProgramName() => this.ProgramName != null;
    }
}
