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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// This is the response object from the GetPropertyValue operation.
    /// </summary>
    public partial class GetPropertyValueResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private Dictionary<string, PropertyLatestValue> _propertyValues = AWSConfigs.InitializeCollections ? new Dictionary<string, PropertyLatestValue>() : null;
        private List<List<Dictionary<string, DataValue>>> _tabularPropertyValues = AWSConfigs.InitializeCollections ? new List<List<Dictionary<string, DataValue>>>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The string that specifies the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=17880)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyValues. 
        /// <para>
        /// An object that maps strings to the properties and latest property values in the response.
        /// Each string in the mapping must be unique to this object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, PropertyLatestValue> PropertyValues
        {
            get { return this._propertyValues; }
            set { this._propertyValues = value; }
        }

        // Check to see if PropertyValues property is set
        internal bool IsSetPropertyValues()
        {
            return this._propertyValues != null && (this._propertyValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TabularPropertyValues. 
        /// <para>
        /// A table of property values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<List<Dictionary<string, DataValue>>> TabularPropertyValues
        {
            get { return this._tabularPropertyValues; }
            set { this._tabularPropertyValues = value; }
        }

        // Check to see if TabularPropertyValues property is set
        internal bool IsSetTabularPropertyValues()
        {
            return this._tabularPropertyValues != null && (this._tabularPropertyValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}