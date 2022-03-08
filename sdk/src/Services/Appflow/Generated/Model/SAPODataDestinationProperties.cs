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
    /// The properties that are applied when using SAPOData as a flow destination
    /// </summary>
    public partial class SAPODataDestinationProperties
    {
        private ErrorHandlingConfig _errorHandlingConfig;
        private List<string> _idFieldNames = new List<string>();
        private string _objectPath;
        private SuccessResponseHandlingConfig _successResponseHandlingConfig;
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
            return this._idFieldNames != null && this._idFieldNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ObjectPath. 
        /// <para>
        /// The object path specified in the SAPOData flow destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
        public string ObjectPath
        {
            get { return this._objectPath; }
            set { this._objectPath = value; }
        }

        // Check to see if ObjectPath property is set
        internal bool IsSetObjectPath()
        {
            return this._objectPath != null;
        }

        /// <summary>
        /// Gets and sets the property SuccessResponseHandlingConfig. 
        /// <para>
        /// Determines how Amazon AppFlow handles the success response that it gets from the connector
        /// after placing data.
        /// </para>
        ///  
        /// <para>
        /// For example, this setting would determine where to write the response from a destination
        /// connector upon a successful insert operation.
        /// </para>
        /// </summary>
        public SuccessResponseHandlingConfig SuccessResponseHandlingConfig
        {
            get { return this._successResponseHandlingConfig; }
            set { this._successResponseHandlingConfig = value; }
        }

        // Check to see if SuccessResponseHandlingConfig property is set
        internal bool IsSetSuccessResponseHandlingConfig()
        {
            return this._successResponseHandlingConfig != null;
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