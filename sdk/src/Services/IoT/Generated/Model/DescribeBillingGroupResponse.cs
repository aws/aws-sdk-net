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
    /// This is the response object from the DescribeBillingGroup operation.
    /// </summary>
    public partial class DescribeBillingGroupResponse : AmazonWebServiceResponse
    {
        private string _billingGroupArn;
        private string _billingGroupId;
        private BillingGroupMetadata _billingGroupMetadata;
        private string _billingGroupName;
        private BillingGroupProperties _billingGroupProperties;
        private long? _version;

        /// <summary>
        /// Gets and sets the property BillingGroupArn. 
        /// <para>
        /// The ARN of the billing group.
        /// </para>
        /// </summary>
        public string BillingGroupArn
        {
            get { return this._billingGroupArn; }
            set { this._billingGroupArn = value; }
        }

        // Check to see if BillingGroupArn property is set
        internal bool IsSetBillingGroupArn()
        {
            return this._billingGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property BillingGroupId. 
        /// <para>
        /// The ID of the billing group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string BillingGroupId
        {
            get { return this._billingGroupId; }
            set { this._billingGroupId = value; }
        }

        // Check to see if BillingGroupId property is set
        internal bool IsSetBillingGroupId()
        {
            return this._billingGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property BillingGroupMetadata. 
        /// <para>
        /// Additional information about the billing group.
        /// </para>
        /// </summary>
        public BillingGroupMetadata BillingGroupMetadata
        {
            get { return this._billingGroupMetadata; }
            set { this._billingGroupMetadata = value; }
        }

        // Check to see if BillingGroupMetadata property is set
        internal bool IsSetBillingGroupMetadata()
        {
            return this._billingGroupMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property BillingGroupName. 
        /// <para>
        /// The name of the billing group.
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the billing group.
        /// </para>
        /// </summary>
        public long? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}