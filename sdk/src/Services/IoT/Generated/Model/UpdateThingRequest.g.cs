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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateThing operation. Updates the data for a
    /// thing. <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateThing</a>
    /// action. </para>
    /// </summary>
    public partial class UpdateThingRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property AttributePayload. 
        /// <para>
        /// A list of thing attributes, a JSON string containing name-value pairs. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>{\"attributes\":{\"name1\":\"value2\"}}</c> 
        /// </para>
        ///  
        /// <para>
        /// This data is used to add new attributes or update existing attributes.
        /// </para>
        /// </summary>
        public AttributePayload AttributePayload { get; set; }

        /// <summary>
        /// Checks to see if the AttributePayload property is set.
        /// </summary>
        internal bool IsSetAttributePayload() => this.AttributePayload != null;

        /// <summary>
        /// Gets and sets the property ExpectedVersion. 
        /// <para>
        /// The expected version of the thing record in the registry. If the version of the record
        /// in the registry does not match the expected version specified in the request, the
        /// <c>UpdateThing</c> request is rejected with a <c>VersionConflictException</c>.
        /// </para>
        /// </summary>
        public long? ExpectedVersion { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedVersion property is set.
        /// </summary>
        internal bool IsSetExpectedVersion() => this.ExpectedVersion.HasValue;

        /// <summary>
        /// Gets and sets the property RemoveThingType. 
        /// <para>
        /// Remove a thing type association. If <b>true</b>, the association is removed.
        /// </para>
        /// </summary>
        public bool? RemoveThingType { get; set; }

        /// <summary>
        /// Checks to see if the RemoveThingType property is set.
        /// </summary>
        internal bool IsSetRemoveThingType() => this.RemoveThingType.HasValue;

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing to update.
        /// </para>
        ///  
        /// <para>
        /// You can't change a thing's name. To change a thing's name, you must create a new thing,
        /// give it the new name, and then delete the old thing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ThingName { get; set; }

        /// <summary>
        /// Checks to see if the ThingName property is set.
        /// </summary>
        internal bool IsSetThingName() => this.ThingName != null;

        /// <summary>
        /// Gets and sets the property ThingTypeName. 
        /// <para>
        /// The name of the thing type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ThingTypeName { get; set; }

        /// <summary>
        /// Checks to see if the ThingTypeName property is set.
        /// </summary>
        internal bool IsSetThingTypeName() => this.ThingTypeName != null;
    }
}
