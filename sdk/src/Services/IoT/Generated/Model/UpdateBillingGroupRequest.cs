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
    /// Container for the parameters to the UpdateBillingGroup operation.
    /// Updates information about the billing group.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateBillingGroup</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class UpdateBillingGroupRequest : AmazonIoTRequest
    {
        private string _billingGroupName;
        private BillingGroupProperties _billingGroupProperties;
        private long? _expectedVersion;

        /// <summary>
        /// Gets and sets the property BillingGroupName. 
        /// <para>
        /// The name of the billing group.
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ExpectedVersion. 
        /// <para>
        /// The expected version of the billing group. If the version of the billing group does
        /// not match the expected version specified in the request, the <c>UpdateBillingGroup</c>
        /// request is rejected with a <c>VersionConflictException</c>.
        /// </para>
        /// </summary>
        public long? ExpectedVersion
        {
            get { return this._expectedVersion; }
            set { this._expectedVersion = value; }
        }

        // Check to see if ExpectedVersion property is set
        internal bool IsSetExpectedVersion()
        {
            return this._expectedVersion.HasValue; 
        }

    }
}