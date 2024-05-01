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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
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
namespace Amazon.RestXmlProtocol.Model
{
    /// <summary>
    /// This is the response object from the TimestampFormatHeaders operation.
    /// </summary>
    public partial class TimestampFormatHeadersResponse : AmazonWebServiceResponse
    {
        private DateTime? _defaultFormat;
        private DateTime? _memberDateTime;
        private DateTime? _memberEpochSeconds;
        private DateTime? _memberHttpDate;
        private DateTime? _targetDateTime;
        private DateTime? _targetEpochSeconds;
        private DateTime? _targetHttpDate;

        /// <summary>
        /// Gets and sets the property DefaultFormat.
        /// </summary>
        public DateTime? DefaultFormat
        {
            get { return this._defaultFormat; }
            set { this._defaultFormat = value; }
        }

        // Check to see if DefaultFormat property is set
        internal bool IsSetDefaultFormat()
        {
            return this._defaultFormat.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemberDateTime.
        /// </summary>
        public DateTime? MemberDateTime
        {
            get { return this._memberDateTime; }
            set { this._memberDateTime = value; }
        }

        // Check to see if MemberDateTime property is set
        internal bool IsSetMemberDateTime()
        {
            return this._memberDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemberEpochSeconds.
        /// </summary>
        public DateTime? MemberEpochSeconds
        {
            get { return this._memberEpochSeconds; }
            set { this._memberEpochSeconds = value; }
        }

        // Check to see if MemberEpochSeconds property is set
        internal bool IsSetMemberEpochSeconds()
        {
            return this._memberEpochSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemberHttpDate.
        /// </summary>
        public DateTime? MemberHttpDate
        {
            get { return this._memberHttpDate; }
            set { this._memberHttpDate = value; }
        }

        // Check to see if MemberHttpDate property is set
        internal bool IsSetMemberHttpDate()
        {
            return this._memberHttpDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetDateTime.
        /// </summary>
        public DateTime? TargetDateTime
        {
            get { return this._targetDateTime; }
            set { this._targetDateTime = value; }
        }

        // Check to see if TargetDateTime property is set
        internal bool IsSetTargetDateTime()
        {
            return this._targetDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetEpochSeconds.
        /// </summary>
        public DateTime? TargetEpochSeconds
        {
            get { return this._targetEpochSeconds; }
            set { this._targetEpochSeconds = value; }
        }

        // Check to see if TargetEpochSeconds property is set
        internal bool IsSetTargetEpochSeconds()
        {
            return this._targetEpochSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetHttpDate.
        /// </summary>
        public DateTime? TargetHttpDate
        {
            get { return this._targetHttpDate; }
            set { this._targetHttpDate = value; }
        }

        // Check to see if TargetHttpDate property is set
        internal bool IsSetTargetHttpDate()
        {
            return this._targetHttpDate.HasValue; 
        }

    }
}