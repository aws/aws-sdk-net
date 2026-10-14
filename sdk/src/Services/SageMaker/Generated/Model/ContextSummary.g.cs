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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Lists a summary of the properties of a context. A context provides a logical grouping
    /// of other entities.
    /// </summary>
    public partial class ContextSummary
    {
        /// <summary>
        /// Gets and sets the property ContextArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the context.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ContextArn { get; set; }

        /// <summary>
        /// Checks to see if the ContextArn property is set.
        /// </summary>
        internal bool IsSetContextArn() => this.ContextArn != null;

        /// <summary>
        /// Gets and sets the property ContextName. 
        /// <para>
        /// The name of the context.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 120)]
        public string ContextName { get; set; }

        /// <summary>
        /// Checks to see if the ContextName property is set.
        /// </summary>
        internal bool IsSetContextName() => this.ContextName != null;

        /// <summary>
        /// Gets and sets the property ContextType. 
        /// <para>
        /// The type of the context.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ContextType { get; set; }

        /// <summary>
        /// Checks to see if the ContextType property is set.
        /// </summary>
        internal bool IsSetContextType() => this.ContextType != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the context was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// When the context was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the context.
        /// </para>
        /// </summary>
        public ContextSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
