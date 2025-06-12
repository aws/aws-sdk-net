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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
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
namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes the validation configuration for a field.
    /// </summary>
    public partial class FieldValidationConfiguration
    {
        private List<int> _numValues = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<string> _strValues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _type;
        private string _validationMessage;

        /// <summary>
        /// Gets and sets the property NumValues. 
        /// <para>
        /// The validation to perform on a number value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> NumValues
        {
            get { return this._numValues; }
            set { this._numValues = value; }
        }

        // Check to see if NumValues property is set
        internal bool IsSetNumValues()
        {
            return this._numValues != null && (this._numValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StrValues. 
        /// <para>
        /// The validation to perform on a string value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StrValues
        {
            get { return this._strValues; }
            set { this._strValues = value; }
        }

        // Check to see if StrValues property is set
        internal bool IsSetStrValues()
        {
            return this._strValues != null && (this._strValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The validation to perform on an object type.<code/> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationMessage. 
        /// <para>
        /// The validation message to display.
        /// </para>
        /// </summary>
        public string ValidationMessage
        {
            get { return this._validationMessage; }
            set { this._validationMessage = value; }
        }

        // Check to see if ValidationMessage property is set
        internal bool IsSetValidationMessage()
        {
            return this._validationMessage != null;
        }

    }
}