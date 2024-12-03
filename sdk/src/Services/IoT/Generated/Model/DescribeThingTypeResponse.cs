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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// The output for the DescribeThingType operation.
    /// </summary>
    public partial class DescribeThingTypeResponse : AmazonWebServiceResponse
    {
        private string _thingTypeArn;
        private string _thingTypeId;
        private ThingTypeMetadata _thingTypeMetadata;
        private string _thingTypeName;
        private ThingTypeProperties _thingTypeProperties;

        /// <summary>
        /// Gets and sets the property ThingTypeArn. 
        /// <para>
        /// The thing type ARN.
        /// </para>
        /// </summary>
        public string ThingTypeArn
        {
            get { return this._thingTypeArn; }
            set { this._thingTypeArn = value; }
        }

        // Check to see if ThingTypeArn property is set
        internal bool IsSetThingTypeArn()
        {
            return this._thingTypeArn != null;
        }

        /// <summary>
        /// Gets and sets the property ThingTypeId. 
        /// <para>
        /// The thing type ID.
        /// </para>
        /// </summary>
        public string ThingTypeId
        {
            get { return this._thingTypeId; }
            set { this._thingTypeId = value; }
        }

        // Check to see if ThingTypeId property is set
        internal bool IsSetThingTypeId()
        {
            return this._thingTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property ThingTypeMetadata. 
        /// <para>
        /// The ThingTypeMetadata contains additional information about the thing type including:
        /// creation date and time, a value indicating whether the thing type is deprecated, and
        /// a date and time when it was deprecated.
        /// </para>
        /// </summary>
        public ThingTypeMetadata ThingTypeMetadata
        {
            get { return this._thingTypeMetadata; }
            set { this._thingTypeMetadata = value; }
        }

        // Check to see if ThingTypeMetadata property is set
        internal bool IsSetThingTypeMetadata()
        {
            return this._thingTypeMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property ThingTypeName. 
        /// <para>
        /// The name of the thing type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property ThingTypeProperties. 
        /// <para>
        /// The ThingTypeProperties contains information about the thing type including description,
        /// a list of searchable thing attribute names, and MQTT5 configuration.
        /// </para>
        /// </summary>
        public ThingTypeProperties ThingTypeProperties
        {
            get { return this._thingTypeProperties; }
            set { this._thingTypeProperties = value; }
        }

        // Check to see if ThingTypeProperties property is set
        internal bool IsSetThingTypeProperties()
        {
            return this._thingTypeProperties != null;
        }

    }
}