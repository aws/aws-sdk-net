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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// An entity associated with metrics, to allow for finding related telemetry. An entity
    /// is typically a resource or service within your system. For example, metrics from an
    /// Amazon EC2 instance could be associated with that instance as the entity. Similarly,
    /// metrics from a service that you own could be associated with that service as the entity.
    /// </summary>
    public partial class Entity
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _keyAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Additional attributes of the entity that are not used to specify the identity of the
        /// entity. A list of key-value pairs.
        /// </para>
        ///  
        /// <para>
        /// For details about how to use the attributes, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/adding-your-own-related-telemetry.html">How
        /// to add related information to telemetry</a> in the <i>CloudWatch User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KeyAttributes. 
        /// <para>
        /// The attributes of the entity which identify the specific entity, as a list of key-value
        /// pairs. Entities with the same <c>KeyAttributes</c> are considered to be the same entity.
        /// For an entity to be valid, the <c>KeyAttributes</c> must exist and be formatted correctly.
        /// </para>
        ///  
        /// <para>
        /// There are five allowed attributes (key names): <c>Type</c>, <c>ResourceType</c>, <c>Identifier</c>,
        /// <c>Name</c>, and <c>Environment</c>.
        /// </para>
        ///  
        /// <para>
        /// For details about how to use the key attributes to specify an entity, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/adding-your-own-related-telemetry.html">How
        /// to add related information to telemetry</a> in the <i>CloudWatch User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2, Max=4)]
        public Dictionary<string, string> KeyAttributes
        {
            get { return this._keyAttributes; }
            set { this._keyAttributes = value; }
        }

        // Check to see if KeyAttributes property is set
        internal bool IsSetKeyAttributes()
        {
            return this._keyAttributes != null && (this._keyAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}