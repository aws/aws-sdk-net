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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Container for the parameters to the SendProjectSessionAction operation.
    /// Performs a recipe step within an interactive DataBrew session that's currently open.
    /// </summary>
    public partial class SendProjectSessionActionRequest : AmazonGlueDataBrewRequest
    {
        private string _clientSessionId;
        private string _name;
        private bool? _preview;
        private RecipeStep _recipeStep;
        private int? _stepIndex;
        private ViewFrame _viewFrame;

        /// <summary>
        /// Gets and sets the property ClientSessionId. 
        /// <para>
        /// A unique identifier for an interactive session that's currently open and ready for
        /// work. The action will be performed on this session.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public string ClientSessionId
        {
            get { return this._clientSessionId; }
            set { this._clientSessionId = value; }
        }

        // Check to see if ClientSessionId property is set
        internal bool IsSetClientSessionId()
        {
            return this._clientSessionId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the project to apply the action to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Preview. 
        /// <para>
        /// If true, the result of the recipe step will be returned, but not applied.
        /// </para>
        /// </summary>
        public bool Preview
        {
            get { return this._preview.GetValueOrDefault(); }
            set { this._preview = value; }
        }

        // Check to see if Preview property is set
        internal bool IsSetPreview()
        {
            return this._preview.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecipeStep.
        /// </summary>
        public RecipeStep RecipeStep
        {
            get { return this._recipeStep; }
            set { this._recipeStep = value; }
        }

        // Check to see if RecipeStep property is set
        internal bool IsSetRecipeStep()
        {
            return this._recipeStep != null;
        }

        /// <summary>
        /// Gets and sets the property StepIndex. 
        /// <para>
        /// The index from which to preview a step. This index is used to preview the result of
        /// steps that have already been applied, so that the resulting view frame is from earlier
        /// in the view frame stack.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int StepIndex
        {
            get { return this._stepIndex.GetValueOrDefault(); }
            set { this._stepIndex = value; }
        }

        // Check to see if StepIndex property is set
        internal bool IsSetStepIndex()
        {
            return this._stepIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ViewFrame.
        /// </summary>
        public ViewFrame ViewFrame
        {
            get { return this._viewFrame; }
            set { this._viewFrame = value; }
        }

        // Check to see if ViewFrame property is set
        internal bool IsSetViewFrame()
        {
            return this._viewFrame != null;
        }

    }
}