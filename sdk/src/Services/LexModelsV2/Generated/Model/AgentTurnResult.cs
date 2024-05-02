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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// The information about the agent turn in a test set execution.
    /// </summary>
    public partial class AgentTurnResult
    {
        private string _actualAgentPrompt;
        private string _actualElicitedSlot;
        private string _actualIntent;
        private ExecutionErrorDetails _errorDetails;
        private string _expectedAgentPrompt;

        /// <summary>
        /// Gets and sets the property ActualAgentPrompt. 
        /// <para>
        /// The actual agent prompt for the agent turn in a test set execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ActualAgentPrompt
        {
            get { return this._actualAgentPrompt; }
            set { this._actualAgentPrompt = value; }
        }

        // Check to see if ActualAgentPrompt property is set
        internal bool IsSetActualAgentPrompt()
        {
            return this._actualAgentPrompt != null;
        }

        /// <summary>
        /// Gets and sets the property ActualElicitedSlot. 
        /// <para>
        /// The actual elicited slot for the agent turn in a test set execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ActualElicitedSlot
        {
            get { return this._actualElicitedSlot; }
            set { this._actualElicitedSlot = value; }
        }

        // Check to see if ActualElicitedSlot property is set
        internal bool IsSetActualElicitedSlot()
        {
            return this._actualElicitedSlot != null;
        }

        /// <summary>
        /// Gets and sets the property ActualIntent. 
        /// <para>
        /// The actual intent for the agent turn in a test set execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ActualIntent
        {
            get { return this._actualIntent; }
            set { this._actualIntent = value; }
        }

        // Check to see if ActualIntent property is set
        internal bool IsSetActualIntent()
        {
            return this._actualIntent != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorDetails.
        /// </summary>
        public ExecutionErrorDetails ErrorDetails
        {
            get { return this._errorDetails; }
            set { this._errorDetails = value; }
        }

        // Check to see if ErrorDetails property is set
        internal bool IsSetErrorDetails()
        {
            return this._errorDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedAgentPrompt. 
        /// <para>
        /// The expected agent prompt for the agent turn in a test set execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ExpectedAgentPrompt
        {
            get { return this._expectedAgentPrompt; }
            set { this._expectedAgentPrompt = value; }
        }

        // Check to see if ExpectedAgentPrompt property is set
        internal bool IsSetExpectedAgentPrompt()
        {
            return this._expectedAgentPrompt != null;
        }

    }
}