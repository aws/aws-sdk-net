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
    /// Container for the parameters to the CreateThing operation.
    /// Creates a thing record in the registry. If this call is made multiple times using
    /// the same thing name and configuration, the call will succeed. If this call is made
    /// with the same thing name but different configuration a <c>ResourceAlreadyExistsException</c>
    /// is thrown.
    /// 
    ///  <note> 
    /// <para>
    /// This is a control plane operation. See <a href="https://docs.aws.amazon.com/iot/latest/developerguide/iot-authorization.html">Authorization</a>
    /// for information about authorizing control plane actions.
    /// </para>
    ///  </note> 
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateThing</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class CreateThingRequest : AmazonIoTRequest
    {
        private AttributePayload _attributePayload;
        private string _billingGroupName;
        private string _thingName;
        private string _thingTypeName;

        /// <summary>
        /// Gets and sets the property AttributePayload. 
        /// <para>
        /// The attribute payload, which consists of up to three name/value pairs in a JSON document.
        /// For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>{\"attributes\":{\"string1\":\"string2\"}}</c> 
        /// </para>
        /// </summary>
        public AttributePayload AttributePayload
        {
            get { return this._attributePayload; }
            set { this._attributePayload = value; }
        }

        // Check to see if AttributePayload property is set
        internal bool IsSetAttributePayload()
        {
            return this._attributePayload != null;
        }

        /// <summary>
        /// Gets and sets the property BillingGroupName. 
        /// <para>
        /// The name of the billing group the thing will be added to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string BillingGroupName
        {
            get { return this._billingGroupName; }
            set { this._billingGroupName = value; }
        }

        // Check to see if BillingGroupName property is set
        internal bool IsSetBillingGroupName()
        {
            return this._billingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing to create.
        /// </para>
        ///  
        /// <para>
        /// You can't change a thing's name after you create it. To change a thing's name, you
        /// must create a new thing, give it the new name, and then delete the old thing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// The name of the thing type associated with the new thing.
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

    }
}