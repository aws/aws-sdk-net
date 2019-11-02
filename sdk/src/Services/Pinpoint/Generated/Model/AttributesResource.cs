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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about the type and the names of attributes that were removed
    /// from all the endpoints that are associated with an application.
    /// </summary>
    public partial class AttributesResource
    {
        private string _applicationId;
        private List<string> _attributes = new List<string>();
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
        /// </summary>
        public List<string> Attributes
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