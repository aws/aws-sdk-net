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

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// This is the response object from the UpdateBillingGroup operation.
    /// </summary>
    public partial class UpdateBillingGroupResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _description;
        private long? _lastModifiedTime;
        private string _name;
        private string _pricingPlanArn;
        private string _primaryAccountId;
        private long? _size;
        private BillingGroupStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the billing group that was updated. 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the billing group. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        ///  The most recent time when the billing group was modified. 
        /// </para>
        /// </summary>
        public long LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the billing group. The names must be unique to each billing group. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
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
        /// Gets and sets the property PricingPlanArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the pricing plan to compute Amazon Web Services
        /// charges for the billing group. 
        /// </para>
        /// </summary>
        public string PricingPlanArn
        {
            get { return this._pricingPlanArn; }
            set { this._pricingPlanArn = value; }
        }

        // Check to see if PricingPlanArn property is set
        internal bool IsSetPricingPlanArn()
        {
            return this._pricingPlanArn != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryAccountId. 
        /// <para>
        ///  The account ID that serves as the main account in a billing group. 
        /// </para>
        /// </summary>
        public string PrimaryAccountId
        {
            get { return this._primaryAccountId; }
            set { this._primaryAccountId = value; }
        }

        // Check to see if PrimaryAccountId property is set
        internal bool IsSetPrimaryAccountId()
        {
            return this._primaryAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        ///  The number of accounts in the particular billing group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long Size
        {
            get { return this._size.GetValueOrDefault(); }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the billing group. Only one of the valid values can be used. 
        /// </para>
        /// </summary>
        public BillingGroupStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        ///  The reason why the billing group is in its current status. 
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}