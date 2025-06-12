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
 * Do not modify this file. This file is generated from the migrationhuborchestrator-2021-08-28.normal.json service model.
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
namespace Amazon.MigrationHubOrchestrator.Model
{
    /// <summary>
    /// A structure to hold multiple values of an output.
    /// </summary>
    public partial class WorkflowStepOutputUnion
    {
        private int? _integerValue;
        private List<string> _listOfStringValue = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _stringValue;

        /// <summary>
        /// Gets and sets the property IntegerValue. 
        /// <para>
        /// The integer value. 
        /// </para>
        /// </summary>
        public int? IntegerValue
        {
            get { return this._integerValue; }
            set { this._integerValue = value; }
        }

        // Check to see if IntegerValue property is set
        internal bool IsSetIntegerValue()
        {
            return this._integerValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ListOfStringValue. 
        /// <para>
        /// The list of string value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ListOfStringValue
        {
            get { return this._listOfStringValue; }
            set { this._listOfStringValue = value; }
        }

        // Check to see if ListOfStringValue property is set
        internal bool IsSetListOfStringValue()
        {
            return this._listOfStringValue != null && (this._listOfStringValue.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// The string value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string StringValue
        {
            get { return this._stringValue; }
            set { this._stringValue = value; }
        }

        // Check to see if StringValue property is set
        internal bool IsSetStringValue()
        {
            return this._stringValue != null;
        }

    }
}