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

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// This is the response object from the GetPropertyValue operation.
    /// </summary>
    public partial class GetPropertyValueResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, PropertyLatestValue> _propertyValues = new Dictionary<string, PropertyLatestValue>();

        /// <summary>
        /// Gets and sets the property PropertyValues. 
        /// <para>
        /// An object that maps strings to the properties and latest property values in the response.
        /// Each string in the mapping must be unique to this object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, PropertyLatestValue> PropertyValues
        {
            get { return this._propertyValues; }
            set { this._propertyValues = value; }
        }

        // Check to see if PropertyValues property is set
        internal bool IsSetPropertyValues()
        {
            return this._propertyValues != null && this._propertyValues.Count > 0; 
        }

    }
}