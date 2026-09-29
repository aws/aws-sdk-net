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

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Container for the parameters to the SendProjectSessionAction operation. Performs a
    /// recipe step within an interactive DataBrew session that's currently open.
    /// </summary>
    public partial class SendProjectSessionActionRequest : AmazonGlueDataBrewRequest
    {
        /// <summary>
        /// Gets and sets the property ClientSessionId. 
        /// <para>
        /// A unique identifier for an interactive session that's currently open and ready for
        /// work. The action will be performed on this session.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string ClientSessionId { get; set; }

        /// <summary>
        /// Checks to see if the ClientSessionId property is set.
        /// </summary>
        internal bool IsSetClientSessionId() => this.ClientSessionId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the project to apply the action to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Preview. 
        /// <para>
        /// If true, the result of the recipe step will be returned, but not applied.
        /// </para>
        /// </summary>
        public bool? Preview { get; set; }

        /// <summary>
        /// Checks to see if the Preview property is set.
        /// </summary>
        internal bool IsSetPreview() => this.Preview.HasValue;

        /// <summary>
        /// Gets and sets the property RecipeStep.
        /// </summary>
        public RecipeStep RecipeStep { get; set; }

        /// <summary>
        /// Checks to see if the RecipeStep property is set.
        /// </summary>
        internal bool IsSetRecipeStep() => this.RecipeStep != null;

        /// <summary>
        /// Gets and sets the property StepIndex. 
        /// <para>
        /// The index from which to preview a step. This index is used to preview the result of
        /// steps that have already been applied, so that the resulting view frame is from earlier
        /// in the view frame stack.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? StepIndex { get; set; }

        /// <summary>
        /// Checks to see if the StepIndex property is set.
        /// </summary>
        internal bool IsSetStepIndex() => this.StepIndex.HasValue;

        /// <summary>
        /// Gets and sets the property ViewFrame.
        /// </summary>
        public ViewFrame ViewFrame { get; set; }

        /// <summary>
        /// Checks to see if the ViewFrame property is set.
        /// </summary>
        internal bool IsSetViewFrame() => this.ViewFrame != null;
    }
}
