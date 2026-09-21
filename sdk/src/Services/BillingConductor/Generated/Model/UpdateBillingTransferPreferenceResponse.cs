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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
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
namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// This is the response object from the UpdateBillingTransferPreference operation.
    /// </summary>
    public partial class UpdateBillingTransferPreferenceResponse : AmazonWebServiceResponse
    {
        private AutoTransferBillingGroupCreationPreference _autoBillingTransferBillingGroupCreation;
        private long? _lastModifiedTime;
        private string _responsibilityTransferArn;

        /// <summary>
        /// Gets and sets the property AutoBillingTransferBillingGroupCreation. 
        /// <para>
        /// The updated auto billing group creation preference for the billing transfer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoTransferBillingGroupCreationPreference AutoBillingTransferBillingGroupCreation
        {
            get { return this._autoBillingTransferBillingGroupCreation; }
            set { this._autoBillingTransferBillingGroupCreation = value; }
        }

        // Check to see if AutoBillingTransferBillingGroupCreation property is set
        internal bool IsSetAutoBillingTransferBillingGroupCreation()
        {
            return this._autoBillingTransferBillingGroupCreation != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The most recent time when the preference was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResponsibilityTransferArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the billing transfer that the preference applies
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResponsibilityTransferArn
        {
            get { return this._responsibilityTransferArn; }
            set { this._responsibilityTransferArn = value; }
        }

        // Check to see if ResponsibilityTransferArn property is set
        internal bool IsSetResponsibilityTransferArn()
        {
            return this._responsibilityTransferArn != null;
        }

    }
}