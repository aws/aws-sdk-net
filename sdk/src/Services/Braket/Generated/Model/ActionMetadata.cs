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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
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
namespace Amazon.Braket.Model
{
    /// <summary>
    /// Contains metadata about the quantum task action, including the action type and program
    /// statistics.
    /// </summary>
    public partial class ActionMetadata
    {
        private string _actionType;
        private long? _executableCount;
        private long? _programCount;

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The type of action associated with the quantum task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ActionType
        {
            get { return this._actionType; }
            set { this._actionType = value; }
        }

        // Check to see if ActionType property is set
        internal bool IsSetActionType()
        {
            return this._actionType != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutableCount. 
        /// <para>
        /// The number of executables in a program set. This is only available for a Program Set.
        /// </para>
        /// </summary>
        public long? ExecutableCount
        {
            get { return this._executableCount; }
            set { this._executableCount = value; }
        }

        // Check to see if ExecutableCount property is set
        internal bool IsSetExecutableCount()
        {
            return this._executableCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProgramCount. 
        /// <para>
        /// The number of programs in a program set. This is only available for a Program Set.
        /// </para>
        /// </summary>
        public long? ProgramCount
        {
            get { return this._programCount; }
            set { this._programCount = value; }
        }

        // Check to see if ProgramCount property is set
        internal bool IsSetProgramCount()
        {
            return this._programCount.HasValue; 
        }

    }
}