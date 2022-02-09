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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FIS.Model
{
    /// <summary>
    /// Specifies an action for an experiment template.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/fis/latest/userguide/actions.html">Actions</a>
    /// in the <i>Fault Injection Simulator User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateExperimentTemplateActionInput
    {
        private string _actionId;
        private string _description;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private List<string> _startAfter = new List<string>();
        private Dictionary<string, string> _targets = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ActionId. 
        /// <para>
        /// The ID of the action. The format of the action ID is: aws:<i>service-name</i>:<i>action-type</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string ActionId
        {
            get { return this._actionId; }
            set { this._actionId = value; }
        }

        // Check to see if ActionId property is set
        internal bool IsSetActionId()
        {
            return this._actionId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the action.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters for the action, if applicable.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartAfter. 
        /// <para>
        /// The name of the action that must be completed before the current action starts. Omit
        /// this parameter to run the action at the start of the experiment.
        /// </para>
        /// </summary>
        public List<string> StartAfter
        {
            get { return this._startAfter; }
            set { this._startAfter = value; }
        }

        // Check to see if StartAfter property is set
        internal bool IsSetStartAfter()
        {
            return this._startAfter != null && this._startAfter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets for the action.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && this._targets.Count > 0; 
        }

    }
}