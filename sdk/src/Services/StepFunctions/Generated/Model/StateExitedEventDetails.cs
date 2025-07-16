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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
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
namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Contains details about an exit from a state during an execution.
    /// </summary>
    public partial class StateExitedEventDetails
    {
        private Dictionary<string, string> _assignedVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private AssignedVariablesDetails _assignedVariablesDetails;
        private string _name;
        private string _output;
        private HistoryEventExecutionDataDetails _outputDetails;

        /// <summary>
        /// Gets and sets the property AssignedVariables. 
        /// <para>
        /// Map of variable name and value as a serialized JSON representation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AssignedVariables
        {
            get { return this._assignedVariables; }
            set { this._assignedVariables = value; }
        }

        // Check to see if AssignedVariables property is set
        internal bool IsSetAssignedVariables()
        {
            return this._assignedVariables != null && (this._assignedVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssignedVariablesDetails. 
        /// <para>
        /// Provides details about input or output in an execution history event.
        /// </para>
        /// </summary>
        public AssignedVariablesDetails AssignedVariablesDetails
        {
            get { return this._assignedVariablesDetails; }
            set { this._assignedVariablesDetails = value; }
        }

        // Check to see if AssignedVariablesDetails property is set
        internal bool IsSetAssignedVariablesDetails()
        {
            return this._assignedVariablesDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the state.
        /// </para>
        ///  
        /// <para>
        /// A name must <i>not</i> contain:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// white space
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// brackets <c>&lt; &gt; { } [ ]</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// wildcard characters <c>? *</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// special characters <c>" # % \ ^ | ~ ` $ &amp; , ; : /</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// control characters (<c>U+0000-001F</c>, <c>U+007F-009F</c>, <c>U+FFFE-FFFF</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// surrogates (<c>U+D800-DFFF</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// invalid characters (<c> U+10FFFF</c>)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To enable logging with CloudWatch Logs, the name should only contain 0-9, A-Z, a-z,
        /// - and _.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
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
        /// Gets and sets the property Output. 
        /// <para>
        /// The JSON output data of the state. Length constraints apply to the payload size, and
        /// are expressed as bytes in UTF-8 encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null;
        }

        /// <summary>
        /// Gets and sets the property OutputDetails. 
        /// <para>
        /// Contains details about the output of an execution history event.
        /// </para>
        /// </summary>
        public HistoryEventExecutionDataDetails OutputDetails
        {
            get { return this._outputDetails; }
            set { this._outputDetails = value; }
        }

        // Check to see if OutputDetails property is set
        internal bool IsSetOutputDetails()
        {
            return this._outputDetails != null;
        }

    }
}