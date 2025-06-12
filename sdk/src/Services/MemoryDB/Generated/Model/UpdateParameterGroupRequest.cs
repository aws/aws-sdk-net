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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
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
namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateParameterGroup operation.
    /// Updates the parameters of a parameter group. You can modify up to 20 parameters in
    /// a single request by submitting a list parameter name and value pairs.
    /// </summary>
    public partial class UpdateParameterGroupRequest : AmazonMemoryDBRequest
    {
        private string _parameterGroupName;
        private List<ParameterNameValue> _parameterNameValues = AWSConfigs.InitializeCollections ? new List<ParameterNameValue>() : null;

        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        /// The name of the parameter group to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ParameterGroupName
        {
            get { return this._parameterGroupName; }
            set { this._parameterGroupName = value; }
        }

        // Check to see if ParameterGroupName property is set
        internal bool IsSetParameterGroupName()
        {
            return this._parameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterNameValues. 
        /// <para>
        /// An array of parameter names and values for the parameter update. You must supply at
        /// least one parameter name and value; subsequent arguments are optional. A maximum of
        /// 20 parameters may be updated per request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ParameterNameValue> ParameterNameValues
        {
            get { return this._parameterNameValues; }
            set { this._parameterNameValues = value; }
        }

        // Check to see if ParameterNameValues property is set
        internal bool IsSetParameterNameValues()
        {
            return this._parameterNameValues != null && (this._parameterNameValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}