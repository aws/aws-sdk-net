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
    /// The context for an iteration of a ForEach step.
    /// </summary>
    public partial class IterationContext
    {
        /// <summary>
        /// Gets and sets the property Index. 
        /// <para>
        /// The index of the iteration within the ForEach step.
        /// </para>
        /// </summary>
        public int? Index { get; set; }

        /// <summary>
        /// Checks to see if the Index property is set.
        /// </summary>
        internal bool IsSetIndex() => this.Index.HasValue;

        /// <summary>
        /// Gets and sets the property Item. 
        /// <para>
        /// The input item that is being processed in this iteration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 12800)]
        public string Item { get; set; }

        /// <summary>
        /// Checks to see if the Item property is set.
        /// </summary>
        internal bool IsSetItem() => this.Item != null;

        /// <summary>
        /// Gets and sets the property ParentStepName. 
        /// <para>
        /// The name of the ForEach step that generated this iteration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ParentStepName { get; set; }

        /// <summary>
        /// Checks to see if the ParentStepName property is set.
        /// </summary>
        internal bool IsSetParentStepName() => this.ParentStepName != null;
    }
}
