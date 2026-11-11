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
    /// Container for the parameters to the ListThings operation. Lists your things. Use the
    /// <b>attributeName</b> and <b>attributeValue</b> parameters to filter your things. For
    /// example, calling <c>ListThings</c> with attributeName=Color and attributeValue=Red
    /// retrieves all things in the registry that contain an attribute <b>Color</b> with the
    /// value <b>Red</b>. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/thing-registry.html#list-things">List
    /// Things</a> from the <i>Amazon Web Services IoT Core Developer Guide</i>. <para> Requires
    /// permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListThings</a>
    /// action. </para> <note> <para> You will not be charged for calling this API if an <c>Access
    /// denied</c> error is returned. You will also not be charged if no attributes or pagination
    /// token was provided in request and no pagination token and no results were returned.
    /// </para> </note>
    /// </summary>
    public partial class ListThingsRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The attribute name used to search for things.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string AttributeName { get; set; }

        /// <summary>
        /// Checks to see if the AttributeName property is set.
        /// </summary>
        internal bool IsSetAttributeName() => this.AttributeName != null;

        /// <summary>
        /// Gets and sets the property AttributeValue. 
        /// <para>
        /// The attribute value used to search for things.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 800)]
        public string AttributeValue { get; set; }

        /// <summary>
        /// Checks to see if the AttributeValue property is set.
        /// </summary>
        internal bool IsSetAttributeValue() => this.AttributeValue != null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// To retrieve the next set of results, the <c>nextToken</c> value from a previous response;
        /// otherwise <b>null</b> to receive the first set of results.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property ThingTypeName. 
        /// <para>
        /// The name of the thing type used to search for things.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ThingTypeName { get; set; }

        /// <summary>
        /// Checks to see if the ThingTypeName property is set.
        /// </summary>
        internal bool IsSetThingTypeName() => this.ThingTypeName != null;

        /// <summary>
        /// Gets and sets the property UsePrefixAttributeValue. 
        /// <para>
        /// When <c>true</c>, the action returns the thing resources with attribute values that
        /// start with the <c>attributeValue</c> provided.
        /// </para>
        ///  
        /// <para>
        /// When <c>false</c>, or not present, the action returns only the thing resources with
        /// attribute values that match the entire <c>attributeValue</c> provided. 
        /// </para>
        /// </summary>
        public bool? UsePrefixAttributeValue { get; set; }

        /// <summary>
        /// Checks to see if the UsePrefixAttributeValue property is set.
        /// </summary>
        internal bool IsSetUsePrefixAttributeValue() => this.UsePrefixAttributeValue.HasValue;
    }
}
