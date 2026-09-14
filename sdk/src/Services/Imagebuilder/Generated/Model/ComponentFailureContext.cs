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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Contains details about the component that caused the image creation process to fail.
    /// The details identify the first step that failed when the component ran.
    /// </summary>
    public partial class ComponentFailureContext
    {
        private string _action;
        private string _componentArn;
        private string _errorMessage;
        private string _phaseName;
        private string _stepName;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that the failed step runs, for example <c>ExecuteBash</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the component build version that failed.
        /// </para>
        /// </summary>
        public string ComponentArn
        {
            get { return this._componentArn; }
            set { this._componentArn = value; }
        }

        // Check to see if ComponentArn property is set
        internal bool IsSetComponentArn()
        {
            return this._componentArn != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message from the step that failed. Image Builder truncates messages that
        /// are longer than 1024 characters. The component log in Amazon CloudWatch Logs contains
        /// the full output.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=384000)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property PhaseName. 
        /// <para>
        /// The name of the phase in the component document where the failure occurred, such as
        /// <c>build</c>, <c>validate</c>, or <c>test</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string PhaseName
        {
            get { return this._phaseName; }
            set { this._phaseName = value; }
        }

        // Check to see if PhaseName property is set
        internal bool IsSetPhaseName()
        {
            return this._phaseName != null;
        }

        /// <summary>
        /// Gets and sets the property StepName. 
        /// <para>
        /// The name of the step in the component document that failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string StepName
        {
            get { return this._stepName; }
            set { this._stepName = value; }
        }

        // Check to see if StepName property is set
        internal bool IsSetStepName()
        {
            return this._stepName != null;
        }

    }
}