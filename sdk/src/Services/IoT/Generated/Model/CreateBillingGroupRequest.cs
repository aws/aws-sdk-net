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
    /// Container for the parameters to the CreateBillingGroup operation.
    /// Creates a billing group. If this call is made multiple times using the same billing
    /// group name and configuration, the call will succeed. If this call is made with the
    /// same billing group name but different configuration a <c>ResourceAlreadyExistsException</c>
    /// is thrown.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateBillingGroup</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class CreateBillingGroupRequest : AmazonIoTRequest
    {
        private string _billingGroupName;
        private BillingGroupProperties _billingGroupProperties;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property BillingGroupName. 
        /// <para>
        /// The name you wish to give to the billing group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property BillingGroupProperties. 
        /// <para>
        /// The properties of the billing group.
        /// </para>
        /// </summary>
        public BillingGroupProperties BillingGroupProperties
        {
            get { return this._billingGroupProperties; }
            set { this._billingGroupProperties = value; }
        }

        // Check to see if BillingGroupProperties property is set
        internal bool IsSetBillingGroupProperties()
        {
            return this._billingGroupProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata which can be used to manage the billing group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}