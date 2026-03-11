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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePredefinedAttribute operation.
    /// Updates a predefined attribute for the specified Amazon Connect instance. A <i>predefined
    /// attribute</i> is made up of a name and a value.
    /// 
    ///  
    /// <para>
    /// For the predefined attributes per instance quota, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#connect-quotas">Amazon
    /// Connect quotas</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Use cases</b> 
    /// </para>
    ///  
    /// <para>
    /// Following are common uses cases for this API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Update routing proficiency (for example, agent certification) that has predefined
    /// values (for example, a list of possible certifications). For more information, see
    /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/predefined-attributes.html">Create
    /// predefined attributes for routing contacts to agents</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Update an attribute for business unit name that has a list of predefined business
    /// unit names used in your organization. This is a use case where information for a contact
    /// varies between transfers or conferences. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/use-contact-segment-attributes.html">Use
    /// contact segment attributes</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Endpoints</b>: See <a href="https://docs.aws.amazon.com/general/latest/gr/connect_region.html">Amazon
    /// Connect endpoints and quotas</a>.
    /// </para>
    /// </summary>
    public partial class UpdatePredefinedAttributeRequest : AmazonConnectRequest
    {
        private InputPredefinedAttributeConfiguration _attributeConfiguration;
        private string _instanceId;
        private string _name;
        private List<string> _purposes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private PredefinedAttributeValues _values;

        /// <summary>
        /// Gets and sets the property AttributeConfiguration. 
        /// <para>
        /// Custom metadata that is associated to predefined attributes to control behavior in
        /// upstream services, such as controlling how a predefined attribute should be displayed
        /// in the Amazon Connect admin website.
        /// </para>
        /// </summary>
        public InputPredefinedAttributeConfiguration AttributeConfiguration
        {
            get { return this._attributeConfiguration; }
            set { this._attributeConfiguration = value; }
        }

        // Check to see if AttributeConfiguration property is set
        internal bool IsSetAttributeConfiguration()
        {
            return this._attributeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can find the instance ID in the
        /// Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the predefined attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Purposes. 
        /// <para>
        /// Values that enable you to categorize your predefined attributes. You can use them
        /// in custom UI elements across the Amazon Connect admin website.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> Purposes
        {
            get { return this._purposes; }
            set { this._purposes = value; }
        }

        // Check to see if Purposes property is set
        internal bool IsSetPurposes()
        {
            return this._purposes != null && (this._purposes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values of the predefined attribute.
        /// </para>
        /// </summary>
        public PredefinedAttributeValues Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null;
        }

    }
}