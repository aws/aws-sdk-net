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
    /// This is the response object from the GetLimit operation.
    /// </summary>
    public partial class GetLimitResponse : AmazonWebServiceResponse
    {
        private string _amountRequirementName;
        private DateTime? _createdAt;
        private string _createdBy;
        private int? _currentCount;
        private string _description;
        private string _displayName;
        private string _farmId;
        private string _limitId;
        private int? _maxCount;
        private DateTime? _updatedAt;
        private string _updatedBy;

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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp of the date and time that the limit was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user identifier of the person that created the limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentCount. 
        /// <para>
        /// The number of resources from the limit that are being used by jobs. The result is
        /// delayed and may not be the count at the time that you called the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public int? CurrentCount
        {
            get { return this._currentCount; }
            set { this._currentCount = value; }
        }

        // Check to see if CurrentCount property is set
        internal bool IsSetCurrentCount()
        {
            return this._currentCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the limit that helps identify what the limit is used for.
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
        /// The unique identifier of the farm that contains the limit.
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
        /// Gets and sets the property LimitId. 
        /// <para>
        /// The unique identifier of the limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LimitId
        {
            get { return this._limitId; }
            set { this._limitId = value; }
        }

        // Check to see if LimitId property is set
        internal bool IsSetLimitId()
        {
            return this._limitId != null;
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
        /// The <c>maxValue</c> must not be 0. If the value is -1, there is no restriction on
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp of the date and time that the limit was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The user identifier of the person that last updated the limit.
        /// </para>
        /// </summary>
        public string UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

    }
}