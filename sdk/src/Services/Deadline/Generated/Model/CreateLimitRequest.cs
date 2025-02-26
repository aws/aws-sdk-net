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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLimit operation.
    /// Creates a limit that manages the distribution of shared resources, such as floating
    /// licenses. A limit can throttle work assignments, help manage workloads, and track
    /// current usage. Before you use a limit, you must associate the limit with one or more
    /// queues. 
    /// 
    ///  
    /// <para>
    /// You must add the <c>amountRequirementName</c> to a step in a job template to declare
    /// the limit requirement.
    /// </para>
    /// </summary>
    public partial class CreateLimitRequest : AmazonDeadlineRequest
    {
        private string _amountRequirementName;
        private string _clientToken;
        private string _description;
        private string _displayName;
        private string _farmId;
        private int? _maxCount;

        /// <summary>
        /// Gets and sets the property AmountRequirementName. 
        /// <para>
        /// The value that you specify as the <c>name</c> in the <c>amounts</c> field of the <c>hostRequirements</c>
        /// in a step of a job template to declare the limit requirement.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string AmountRequirementName
        {
            get { return this._amountRequirementName; }
            set { this._amountRequirementName = value; }
        }

        // Check to see if AmountRequirementName property is set
        internal bool IsSetAmountRequirementName()
        {
            return this._amountRequirementName != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The unique token which the server uses to recognize retries of the same request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the limit. A description helps you identify the purpose of the limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=100)]
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The farm ID of the farm that contains the limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FarmId
        {
            get { return this._farmId; }
            set { this._farmId = value; }
        }

        // Check to see if FarmId property is set
        internal bool IsSetFarmId()
        {
            return this._farmId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxCount. 
        /// <para>
        /// The maximum number of resources constrained by this limit. When all of the resources
        /// are in use, steps that require the limit won't be scheduled until the resource is
        /// available.
        /// </para>
        ///  
        /// <para>
        /// The <c>maxCount</c> must not be 0. If the value is -1, there is no restriction on
        /// the number of resources that can be acquired for this limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=-1, Max=2147483647)]
        public int? MaxCount
        {
            get { return this._maxCount; }
            set { this._maxCount = value; }
        }

        // Check to see if MaxCount property is set
        internal bool IsSetMaxCount()
        {
            return this._maxCount.HasValue; 
        }

    }
}