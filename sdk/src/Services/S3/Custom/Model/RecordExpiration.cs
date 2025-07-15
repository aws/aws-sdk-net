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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// The journal table record expiration settings for a journal table in an S3 Metadata configuration.
    /// </summary>
    public partial class RecordExpiration
    {
        private int? _days;
        private ExpirationState _expiration;

        /// <summary>
        /// Gets and sets the property Days. 
        /// <para>
        ///  If you enable journal table record expiration, you can set the number of days to
        /// retain your journal table records. Journal table records must be retained for a minimum
        /// of 7 days. To set this value, specify any whole number from <c>7</c> to <c>2147483647</c>.
        /// For example, to retain your journal table records for one year, set this value to
        /// <c>365</c>. 
        /// </para>
        /// </summary>
        public int Days
        {
            get { return this._days.GetValueOrDefault(); }
            set { this._days = value; }
        }

        // Check to see if Days property is set
        internal bool IsSetDays()
        {
            return this._days.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        ///  Specifies whether journal table record expiration is enabled or disabled. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExpirationState Expiration
        {
            get { return this._expiration; }
            set { this._expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this._expiration != null;
        }

    }
}