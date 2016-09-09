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
        private string _thingTypeName;
        private long? _version;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The thing attributes.
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

        /// <summary>
        /// Gets and sets the property ThingTypeName. 
        /// <para>
        /// The thing type name.
        /// </para>
        /// </summary>
        public string ThingTypeName
        {
            get { return this._thingTypeName; }
            set { this._thingTypeName = value; }
        }

        // Check to see if ThingTypeName property is set
        internal bool IsSetThingTypeName()
        {
            return this._thingTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The current version of the thing record in the registry.
        /// </para>
        ///  <note> 
        /// <para>
        /// To avoid unintentional changes to the information in the registry, you can pass the
        /// version information in the <code>expectedVersion</code> parameter of the <code>UpdateThing</code>
        /// and <code>DeleteThing</code> calls.
        /// </para>
        ///  </note>
        /// </summary>
        public long Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}