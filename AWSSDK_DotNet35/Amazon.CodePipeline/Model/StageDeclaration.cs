/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents information about a stage and its definition.
    /// </summary>
    public partial class StageDeclaration
    {
        private List<ActionDeclaration> _actions = new List<ActionDeclaration>();
        private List<BlockerDeclaration> _blockers = new List<BlockerDeclaration>();
        private string _name;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions included in a stage.
        /// </para>
        /// </summary>
        public List<ActionDeclaration> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && this._actions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Blockers. 
        /// <para>
        /// The gates included in a stage.
        /// </para>
        /// </summary>
        public List<BlockerDeclaration> Blockers
        {
            get { return this._blockers; }
            set { this._blockers = value; }
        }

        // Check to see if Blockers property is set
        internal bool IsSetBlockers()
        {
            return this._blockers != null && this._blockers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the stage.
        /// </para>
        /// </summary>
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

    }
}