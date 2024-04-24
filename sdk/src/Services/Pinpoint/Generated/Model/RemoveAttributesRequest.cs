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
    /// Container for the parameters to the RemoveAttributes operation.
    /// Removes one or more custom attributes, of the same attribute type, from the application.
    /// Existing endpoints still have the attributes but Amazon Pinpoint will stop capturing
    /// new or changed values for these attributes.
    /// </summary>
    public partial class RemoveAttributesRequest : AmazonPinpointRequest
    {
        private string _applicationId;
        private string _attributeType;
        private UpdateAttributesRequest _updateAttributesRequest;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application. This identifier is displayed as the <b>Project
        /// ID</b> on the Amazon Pinpoint console.
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
        /// Gets and sets the property AttributeType.  
        /// <para>
        /// The type of attribute or attributes to remove. Valid values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// endpoint-custom-attributes - Custom attributes that describe endpoints, such as the
        /// date when an associated user opted in or out of receiving communications from you
        /// through a specific type of channel.
        /// </para>
        /// </li> <li>
        /// <para>
        /// endpoint-metric-attributes - Custom metrics that your app reports to Amazon Pinpoint
        /// for endpoints, such as the number of app sessions or the number of items left in a
        /// cart.
        /// </para>
        /// </li> <li>
        /// <para>
        /// endpoint-user-attributes - Custom attributes that describe users, such as first name,
        /// last name, and age.
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

        /// <summary>
        /// Gets and sets the property UpdateAttributesRequest.
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateAttributesRequest UpdateAttributesRequest
        {
            get { return this._updateAttributesRequest; }
            set { this._updateAttributesRequest = value; }
        }

        // Check to see if UpdateAttributesRequest property is set
        internal bool IsSetUpdateAttributesRequest()
        {
            return this._updateAttributesRequest != null;
        }

    }
}