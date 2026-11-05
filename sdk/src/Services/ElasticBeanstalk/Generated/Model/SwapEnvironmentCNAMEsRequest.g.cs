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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the SwapEnvironmentCNAMEs operation. Swaps the CNAMEs
    /// of two environments.
    /// </summary>
    public partial class SwapEnvironmentCNAMEsRequest : AmazonElasticBeanstalkRequest
    {
        /// <summary>
        /// Gets and sets the property DestinationEnvironmentId. 
        /// <para>
        /// The ID of the destination environment.
        /// </para>
        ///  
        /// <para>
        ///  Condition: You must specify at least the <c>DestinationEnvironmentID</c> or the <c>DestinationEnvironmentName</c>.
        /// You may also specify both. You must specify the <c>SourceEnvironmentId</c> with the
        /// <c>DestinationEnvironmentId</c>. 
        /// </para>
        /// </summary>
        public string DestinationEnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationEnvironmentId property is set.
        /// </summary>
        internal bool IsSetDestinationEnvironmentId() => this.DestinationEnvironmentId != null;

        /// <summary>
        /// Gets and sets the property DestinationEnvironmentName. 
        /// <para>
        /// The name of the destination environment.
        /// </para>
        ///  
        /// <para>
        ///  Condition: You must specify at least the <c>DestinationEnvironmentID</c> or the <c>DestinationEnvironmentName</c>.
        /// You may also specify both. You must specify the <c>SourceEnvironmentName</c> with
        /// the <c>DestinationEnvironmentName</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 40)]
        public string DestinationEnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the DestinationEnvironmentName property is set.
        /// </summary>
        internal bool IsSetDestinationEnvironmentName() => this.DestinationEnvironmentName != null;

        /// <summary>
        /// Gets and sets the property SourceEnvironmentId. 
        /// <para>
        /// The ID of the source environment.
        /// </para>
        ///  
        /// <para>
        ///  Condition: You must specify at least the <c>SourceEnvironmentID</c> or the <c>SourceEnvironmentName</c>.
        /// You may also specify both. If you specify the <c>SourceEnvironmentId</c>, you must
        /// specify the <c>DestinationEnvironmentId</c>. 
        /// </para>
        /// </summary>
        public string SourceEnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the SourceEnvironmentId property is set.
        /// </summary>
        internal bool IsSetSourceEnvironmentId() => this.SourceEnvironmentId != null;

        /// <summary>
        /// Gets and sets the property SourceEnvironmentName. 
        /// <para>
        /// The name of the source environment.
        /// </para>
        ///  
        /// <para>
        ///  Condition: You must specify at least the <c>SourceEnvironmentID</c> or the <c>SourceEnvironmentName</c>.
        /// You may also specify both. If you specify the <c>SourceEnvironmentName</c>, you must
        /// specify the <c>DestinationEnvironmentName</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 40)]
        public string SourceEnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the SourceEnvironmentName property is set.
        /// </summary>
        internal bool IsSetSourceEnvironmentName() => this.SourceEnvironmentName != null;
    }
}
