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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The code execution output in JSON format.
    /// </summary>
    public partial class StatementOutput
    {
        private StatementOutputData _data;
        private string _errorName;
        private string _errorValue;
        private int? _executionCount;
        private StatementState _status;
        private List<string> _traceback = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The code execution output.
        /// </para>
        /// </summary>
        public StatementOutputData Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorName. 
        /// <para>
        /// The name of the error in the output.
        /// </para>
        /// </summary>
        public string ErrorName
        {
            get { return this._errorName; }
            set { this._errorName = value; }
        }

        // Check to see if ErrorName property is set
        internal bool IsSetErrorName()
        {
            return this._errorName != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorValue. 
        /// <para>
        /// The error value of the output.
        /// </para>
        /// </summary>
        public string ErrorValue
        {
            get { return this._errorValue; }
            set { this._errorValue = value; }
        }

        // Check to see if ErrorValue property is set
        internal bool IsSetErrorValue()
        {
            return this._errorValue != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionCount. 
        /// <para>
        /// The execution count of the output.
        /// </para>
        /// </summary>
        public int? ExecutionCount
        {
            get { return this._executionCount; }
            set { this._executionCount = value; }
        }

        // Check to see if ExecutionCount property is set
        internal bool IsSetExecutionCount()
        {
            return this._executionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the code execution output.
        /// </para>
        /// </summary>
        public StatementState Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Traceback. 
        /// <para>
        /// The traceback of the output.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Traceback
        {
            get { return this._traceback; }
            set { this._traceback = value; }
        }

        // Check to see if Traceback property is set
        internal bool IsSetTraceback()
        {
            return this._traceback != null && (this._traceback.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}