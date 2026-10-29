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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePredefinedAttribute operation. Updates a
    /// predefined attribute for the specified Connect Customer instance. A <i>predefined
    /// attribute</i> is made up of a name and a value. <para> For the predefined attributes
    /// per instance quota, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#connect-quotas">Connect
    /// Customer quotas</a>. </para> <para> <b>Use cases</b> </para> <para> Following are
    /// common uses cases for this API: </para> <ul> <li> <para> Update routing proficiency
    /// (for example, agent certification) that has predefined values (for example, a list
    /// of possible certifications). For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/predefined-attributes.html">Create
    /// predefined attributes for routing contacts to agents</a>. </para> </li> <li> <para>
    /// Update an attribute for business unit name that has a list of predefined business
    /// unit names used in your organization. This is a use case where information for a contact
    /// varies between transfers or conferences. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/use-contact-segment-attributes.html">Use
    /// contact segment attributes</a>. </para> </li> </ul> <para> <b>Endpoints</b>: See <a
    /// href="https://docs.aws.amazon.com/general/latest/gr/connect_region.html">Connect Customer
    /// endpoints and quotas</a>. </para>
    /// </summary>
    public partial class UpdatePredefinedAttributeRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AttributeConfiguration. 
        /// <para>
        /// Custom metadata that is associated to predefined attributes to control behavior in
        /// upstream services, such as controlling how a predefined attribute should be displayed
        /// in the Connect Customer admin website.
        /// </para>
        /// </summary>
        public InputPredefinedAttributeConfiguration AttributeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AttributeConfiguration property is set.
        /// </summary>
        internal bool IsSetAttributeConfiguration() => this.AttributeConfiguration != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can find the instance ID in the
        /// Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the predefined attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Purposes. 
        /// <para>
        /// Values that enable you to categorize your predefined attributes. You can use them
        /// in custom UI elements across the Connect Customer admin website.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> Purposes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Purposes property is set.
        /// </summary>
        internal bool IsSetPurposes() => this.Purposes != null && (this.Purposes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values of the predefined attribute.
        /// </para>
        /// </summary>
        public PredefinedAttributeValues Values { get; set; }

        /// <summary>
        /// Checks to see if the Values property is set.
        /// </summary>
        internal bool IsSetValues() => this.Values != null;
    }
}
