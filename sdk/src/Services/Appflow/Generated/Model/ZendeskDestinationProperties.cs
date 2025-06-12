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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The properties that are applied when Zendesk is used as a destination.
    /// </summary>
    public partial class ZendeskDestinationProperties
    {
        private ErrorHandlingConfig _errorHandlingConfig;
        private List<string> _idFieldNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _object;
        private WriteOperationType _writeOperationType;

        /// <summary>
        /// Gets and sets the property ErrorHandlingConfig.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0)]
        public List<string> IdFieldNames
        {
            get { return this._idFieldNames; }
            set { this._idFieldNames = value; }
        }

        // Check to see if IdFieldNames property is set
        internal bool IsSetIdFieldNames()
        {
            return this._idFieldNames != null && (this._idFieldNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Object. 
        /// <para>
        /// The object specified in the Zendesk flow destination.
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