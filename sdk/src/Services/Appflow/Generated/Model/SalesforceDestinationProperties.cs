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
    /// The properties that are applied when Salesforce is being used as a destination.
    /// </summary>
    public partial class SalesforceDestinationProperties
    {
        private ErrorHandlingConfig _errorHandlingConfig;
        private List<string> _idFieldNames = new List<string>();
        private string _object;
        private WriteOperationType _writeOperationType;

        /// <summary>
        /// Gets and sets the property ErrorHandlingConfig. 
        /// <para>
        ///  The settings that determine how Amazon AppFlow handles an error when placing data
        /// in the Salesforce destination. For example, this setting would determine if the flow
        /// should fail after one insertion error, or continue and attempt to insert every record
        /// regardless of the initial failure. <code>ErrorHandlingConfig</code> is a part of the
        /// destination connector details. 
        /// </para>
        /// </summary>
        public ErrorHandlingConfig ErrorHandlingConfig
        {
            get { return this._errorHandlingConfig; }
            set { this._errorHandlingConfig = value; }
        }

        // Check to see if ErrorHandlingConfig property is set
        internal bool IsSetErrorHandlingConfig()
        {
            return this._errorHandlingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property IdFieldNames. 
        /// <para>
        ///  The name of the field that Amazon AppFlow uses as an ID when performing a write operation
        /// such as update or delete. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> IdFieldNames
        {
            get { return this._idFieldNames; }
            set { this._idFieldNames = value; }
        }

        // Check to see if IdFieldNames property is set
        internal bool IsSetIdFieldNames()
        {
            return this._idFieldNames != null && this._idFieldNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Object. 
        /// <para>
        ///  The object specified in the Salesforce flow destination. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
        public string Object
        {
            get { return this._object; }
            set { this._object = value; }
        }

        // Check to see if Object property is set
        internal bool IsSetObject()
        {
            return this._object != null;
        }

        /// <summary>
        /// Gets and sets the property WriteOperationType. 
        /// <para>
        ///  This specifies the type of write operation to be performed in Salesforce. When the
        /// value is <code>UPSERT</code>, then <code>idFieldNames</code> is required. 
        /// </para>
        /// </summary>
        public WriteOperationType WriteOperationType
        {
            get { return this._writeOperationType; }
            set { this._writeOperationType = value; }
        }

        // Check to see if WriteOperationType property is set
        internal bool IsSetWriteOperationType()
        {
            return this._writeOperationType != null;
        }

    }
}