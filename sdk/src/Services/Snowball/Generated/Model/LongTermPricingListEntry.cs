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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
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
namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Each <c>LongTermPricingListEntry</c> object contains information about a long-term
    /// pricing type.
    /// </summary>
    public partial class LongTermPricingListEntry
    {
        private string _currentActiveJob;
        private bool? _isLongTermPricingAutoRenew;
        private List<string> _jobIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _longTermPricingEndDate;
        private string _longTermPricingId;
        private DateTime? _longTermPricingStartDate;
        private string _longTermPricingStatus;
        private LongTermPricingType _longTermPricingType;
        private string _replacementJob;
        private SnowballType _snowballType;

        /// <summary>
        /// Gets and sets the property CurrentActiveJob. 
        /// <para>
        /// The current active jobs on the device the long-term pricing type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=39, Max=39)]
        public string CurrentActiveJob
        {
            get { return this._currentActiveJob; }
            set { this._currentActiveJob = value; }
        }

        // Check to see if CurrentActiveJob property is set
        internal bool IsSetCurrentActiveJob()
        {
            return this._currentActiveJob != null;
        }

        /// <summary>
        /// Gets and sets the property IsLongTermPricingAutoRenew. 
        /// <para>
        /// If set to <c>true</c>, specifies that the current long-term pricing type for the device
        /// should be automatically renewed before the long-term pricing contract expires.
        /// </para>
        /// </summary>
        public bool? IsLongTermPricingAutoRenew
        {
            get { return this._isLongTermPricingAutoRenew; }
            set { this._isLongTermPricingAutoRenew = value; }
        }

        // Check to see if IsLongTermPricingAutoRenew property is set
        internal bool IsSetIsLongTermPricingAutoRenew()
        {
            return this._isLongTermPricingAutoRenew.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobIds. 
        /// <para>
        /// The IDs of the jobs that are associated with a long-term pricing type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> JobIds
        {
            get { return this._jobIds; }
            set { this._jobIds = value; }
        }

        // Check to see if JobIds property is set
        internal bool IsSetJobIds()
        {
            return this._jobIds != null && (this._jobIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LongTermPricingEndDate. 
        /// <para>
        /// The end date the long-term pricing contract.
        /// </para>
        /// </summary>
        public DateTime? LongTermPricingEndDate
        {
            get { return this._longTermPricingEndDate; }
            set { this._longTermPricingEndDate = value; }
        }

        // Check to see if LongTermPricingEndDate property is set
        internal bool IsSetLongTermPricingEndDate()
        {
            return this._longTermPricingEndDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LongTermPricingId. 
        /// <para>
        /// The ID of the long-term pricing type for the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=41, Max=41)]
        public string LongTermPricingId
        {
            get { return this._longTermPricingId; }
            set { this._longTermPricingId = value; }
        }

        // Check to see if LongTermPricingId property is set
        internal bool IsSetLongTermPricingId()
        {
            return this._longTermPricingId != null;
        }

        /// <summary>
        /// Gets and sets the property LongTermPricingStartDate. 
        /// <para>
        /// The start date of the long-term pricing contract.
        /// </para>
        /// </summary>
        public DateTime? LongTermPricingStartDate
        {
            get { return this._longTermPricingStartDate; }
            set { this._longTermPricingStartDate = value; }
        }

        // Check to see if LongTermPricingStartDate property is set
        internal bool IsSetLongTermPricingStartDate()
        {
            return this._longTermPricingStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LongTermPricingStatus. 
        /// <para>
        /// The status of the long-term pricing type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string LongTermPricingStatus
        {
            get { return this._longTermPricingStatus; }
            set { this._longTermPricingStatus = value; }
        }

        // Check to see if LongTermPricingStatus property is set
        internal bool IsSetLongTermPricingStatus()
        {
            return this._longTermPricingStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LongTermPricingType. 
        /// <para>
        /// The type of long-term pricing that was selected for the device.
        /// </para>
        /// </summary>
        public LongTermPricingType LongTermPricingType
        {
            get { return this._longTermPricingType; }
            set { this._longTermPricingType = value; }
        }

        // Check to see if LongTermPricingType property is set
        internal bool IsSetLongTermPricingType()
        {
            return this._longTermPricingType != null;
        }

        /// <summary>
        /// Gets and sets the property ReplacementJob. 
        /// <para>
        /// A new device that replaces a device that is ordered with long-term pricing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=39, Max=39)]
        public string ReplacementJob
        {
            get { return this._replacementJob; }
            set { this._replacementJob = value; }
        }

        // Check to see if ReplacementJob property is set
        internal bool IsSetReplacementJob()
        {
            return this._replacementJob != null;
        }

        /// <summary>
        /// Gets and sets the property SnowballType. 
        /// <para>
        /// The type of Snow Family devices associated with this long-term pricing job.
        /// </para>
        /// </summary>
        public SnowballType SnowballType
        {
            get { return this._snowballType; }
            set { this._snowballType = value; }
        }

        // Check to see if SnowballType property is set
        internal bool IsSetSnowballType()
        {
            return this._snowballType != null;
        }

    }
}