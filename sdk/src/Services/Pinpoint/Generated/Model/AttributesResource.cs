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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about the type and the names of attributes that were removed
    /// from all the endpoints that are associated with an application.
    /// </summary>
    public partial class AttributesResource
    {
        private string _applicationId;
        private List<string> _attributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _attributeType;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// An array that specifies the names of the attributes that were removed from the endpoints.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Attributes
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
        /// Gets and sets the property AttributeType. 
        /// <para>
        /// The type of attribute or attributes that were removed from the endpoints. Valid values
        /// are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// endpoint-custom-attributes - Custom attributes that describe endpoints.
        /// </para>
        /// </li> <li>
        /// <para>
        /// endpoint-metric-attributes - Custom metrics that your app reports to Amazon Pinpoint
        /// for endpoints.
        /// </para>
        /// </li> <li>
        /// <para>
        /// endpoint-user-attributes - Custom attributes that describe users.
        /// </para>
        /// </li></ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AttributeType
        {
            get { return this._attributeType; }
            set { this._attributeType = value; }
        }

        // Check to see if AttributeType property is set
        internal bool IsSetAttributeType()
        {
            return this._attributeType != null;
        }

    }
}