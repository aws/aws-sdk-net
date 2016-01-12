/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The output from the DescribeThing operation.
    /// </summary>
    public partial class DescribeThingResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _defaultClientId;
        private string _thingName;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes which are name/value pairs in JSON format. For example: 
        /// </para>
        ///  
        /// <para>
        /// {\"attributes\":{\"some-name1\":\"some-value1\"}, {\"some-name2\":\"some-value2\"},
        /// {\"some-name3\":\"some-value3\"}}
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DefaultClientId. 
        /// <para>
        /// The default client ID.
        /// </para>
        /// </summary>
        public string DefaultClientId
        {
            get { return this._defaultClientId; }
            set { this._defaultClientId = value; }
        }

        // Check to see if DefaultClientId property is set
        internal bool IsSetDefaultClientId()
        {
            return this._defaultClientId != null;
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing.
        /// </para>
        /// </summary>
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

    }
}