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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// A class for modeling different type of tasks. Task implementation varies based on
    /// the <code>TaskType</code>.
    /// </summary>
    public partial class Task
    {
        private ConnectorOperator _connectorOperator;
        private string _destinationField;
        private List<string> _sourceFields = new List<string>();
        private Dictionary<string, string> _taskProperties = new Dictionary<string, string>();
        private TaskType _taskType;

        /// <summary>
        /// Gets and sets the property ConnectorOperator. 
        /// <para>
        ///  The operation to be performed on the provided source fields. 
        /// </para>
        /// </summary>
        public ConnectorOperator ConnectorOperator
        {
            get { return this._connectorOperator; }
            set { this._connectorOperator = value; }
        }

        // Check to see if ConnectorOperator property is set
        internal bool IsSetConnectorOperator()
        {
            return this._connectorOperator != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationField. 
        /// <para>
        ///  A field in a destination connector, or a field value against which Amazon AppFlow
        /// validates a source field. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DestinationField
        {
            get { return this._destinationField; }
            set { this._destinationField = value; }
        }

        // Check to see if DestinationField property is set
        internal bool IsSetDestinationField()
        {
            return this._destinationField != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFields. 
        /// <para>
        ///  The source fields to which a particular task is applied. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SourceFields
        {
            get { return this._sourceFields; }
            set { this._sourceFields = value; }
        }

        // Check to see if SourceFields property is set
        internal bool IsSetSourceFields()
        {
            return this._sourceFields != null && this._sourceFields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TaskProperties. 
        /// <para>
        ///  A map used to store task-related information. The execution service looks for particular
        /// information based on the <code>TaskType</code>. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> TaskProperties
        {
            get { return this._taskProperties; }
            set { this._taskProperties = value; }
        }

        // Check to see if TaskProperties property is set
        internal bool IsSetTaskProperties()
        {
            return this._taskProperties != null && this._taskProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TaskType. 
        /// <para>
        ///  Specifies the particular task implementation that Amazon AppFlow performs. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TaskType TaskType
        {
            get { return this._taskType; }
            set { this._taskType = value; }
        }

        // Check to see if TaskType property is set
        internal bool IsSetTaskType()
        {
            return this._taskType != null;
        }

    }
}