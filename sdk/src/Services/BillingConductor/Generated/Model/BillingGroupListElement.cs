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
    /// A representation of a billing group.
    /// </summary>
    public partial class BillingGroupListElement
    {
        private string _arn;
        private ComputationPreference _computationPreference;
        private long? _creationTime;
        private string _description;
        private long? _lastModifiedTime;
        private string _name;
        private string _primaryAccountId;
        private long? _size;
        private BillingGroupStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Number (ARN) that can be used to uniquely identify the billing
        /// group. 
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
        /// Gets and sets the property ComputationPreference.
        /// </summary>
        public ComputationPreference ComputationPreference
        {
            get { return this._computationPreference; }
            set { this._computationPreference = value; }
        }

        // Check to see if ComputationPreference property is set
        internal bool IsSetComputationPreference()
        {
            return this._computationPreference != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  The time when the billing group was created. 
        /// </para>
        /// </summary>
        public long CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the billing group. 
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
        /// The name of the billing group. 
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
        /// Gets and sets the property PrimaryAccountId. 
        /// <para>
        /// The account ID that serves as the main account in a billing group. 
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
        /// The number of accounts in the particular billing group. 
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
        /// The billing group status. Only one of the valid values can be used. 
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
        /// The reason why the billing group is in its current status. 
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