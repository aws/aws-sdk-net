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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// The object containing the values of a single calculated attribute value.
    /// </summary>
    public partial class CalculatedAttributeValue
    {
        private string _calculatedAttributeName;
        private string _displayName;
        private string _isDataPartial;
        private DateTime? _lastObjectTimestamp;
        private string _profileId;
        private string _value;

        /// <summary>
        /// Gets and sets the property CalculatedAttributeName. 
        /// <para>
        /// The unique name of the calculated attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CalculatedAttributeName
        {
            get { return this._calculatedAttributeName; }
            set { this._calculatedAttributeName = value; }
        }

        // Check to see if CalculatedAttributeName property is set
        internal bool IsSetCalculatedAttributeName()
        {
            return this._calculatedAttributeName != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the calculated attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property IsDataPartial. 
        /// <para>
        /// Indicates whether the calculated attribute's value is based on partial data. If the
        /// data is partial, it is set to true.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string IsDataPartial
        {
            get { return this._isDataPartial; }
            set { this._isDataPartial = value; }
        }

        // Check to see if IsDataPartial property is set
        internal bool IsSetIsDataPartial()
        {
            return this._isDataPartial != null;
        }

        /// <summary>
        /// Gets and sets the property LastObjectTimestamp. 
        /// <para>
        /// The timestamp of the newest object included in the calculated attribute calculation.
        /// </para>
        /// </summary>
        public DateTime? LastObjectTimestamp
        {
            get { return this._lastObjectTimestamp; }
            set { this._lastObjectTimestamp = value; }
        }

        // Check to see if LastObjectTimestamp property is set
        internal bool IsSetLastObjectTimestamp()
        {
            return this._lastObjectTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The profile id belonging to this calculated attribute value.
        /// </para>
        /// </summary>
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the calculated attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}