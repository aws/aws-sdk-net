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
    /// Container for the parameters to the XmlTimestamps operation.
    /// This tests how timestamps are serialized, including using the default format of date-time
    /// and various @timestampFormat trait values.
    /// </summary>
    public partial class XmlTimestampsRequest : AmazonRestXmlProtocolRequest
    {
        private DateTime? _dateTime;
        private DateTime? _dateTimeOnTarget;
        private DateTime? _epochSeconds;
        private DateTime? _epochSecondsOnTarget;
        private DateTime? _httpDate;
        private DateTime? _httpDateOnTarget;
        private DateTime? _normal;

        /// <summary>
        /// Gets and sets the property DateTime.
        /// </summary>
        public DateTime? DateTime
        {
            get { return this._dateTime; }
            set { this._dateTime = value; }
        }

        // Check to see if DateTime property is set
        internal bool IsSetDateTime()
        {
            return this._dateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DateTimeOnTarget.
        /// </summary>
        public DateTime? DateTimeOnTarget
        {
            get { return this._dateTimeOnTarget; }
            set { this._dateTimeOnTarget = value; }
        }

        // Check to see if DateTimeOnTarget property is set
        internal bool IsSetDateTimeOnTarget()
        {
            return this._dateTimeOnTarget.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EpochSeconds.
        /// </summary>
        public DateTime? EpochSeconds
        {
            get { return this._epochSeconds; }
            set { this._epochSeconds = value; }
        }

        // Check to see if EpochSeconds property is set
        internal bool IsSetEpochSeconds()
        {
            return this._epochSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EpochSecondsOnTarget.
        /// </summary>
        public DateTime? EpochSecondsOnTarget
        {
            get { return this._epochSecondsOnTarget; }
            set { this._epochSecondsOnTarget = value; }
        }

        // Check to see if EpochSecondsOnTarget property is set
        internal bool IsSetEpochSecondsOnTarget()
        {
            return this._epochSecondsOnTarget.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HttpDate.
        /// </summary>
        public DateTime? HttpDate
        {
            get { return this._httpDate; }
            set { this._httpDate = value; }
        }

        // Check to see if HttpDate property is set
        internal bool IsSetHttpDate()
        {
            return this._httpDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HttpDateOnTarget.
        /// </summary>
        public DateTime? HttpDateOnTarget
        {
            get { return this._httpDateOnTarget; }
            set { this._httpDateOnTarget = value; }
        }

        // Check to see if HttpDateOnTarget property is set
        internal bool IsSetHttpDateOnTarget()
        {
            return this._httpDateOnTarget.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Normal.
        /// </summary>
        public DateTime? Normal
        {
            get { return this._normal; }
            set { this._normal = value; }
        }

        // Check to see if Normal property is set
        internal bool IsSetNormal()
        {
            return this._normal.HasValue; 
        }

    }
}