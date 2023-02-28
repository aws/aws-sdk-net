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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// WriteRecords would throw this exception in the following cases: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Records with duplicate data where there are multiple records with the same dimensions,
    /// timestamps, and measure names but: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Measure values are different
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Version is not present in the request <i>or</i> the value of version in the new record
    /// is equal to or lower than the existing value
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  In this case, if Timestream rejects data, the <code>ExistingVersion</code> field
    /// in the <code>RejectedRecords</code> response will indicate the current record’s version.
    /// To force an update, you can resend the request with a version for the record set to
    /// a value greater than the <code>ExistingVersion</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Records with timestamps that lie outside the retention duration of the memory store.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Records with dimensions or measures that exceed the Timestream defined limits. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Quotas</a>
    /// in the Amazon Timestream Developer Guide. 
    /// </para>
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class RejectedRecordsException : AmazonTimestreamWriteException
    {
        private List<RejectedRecord> _rejectedRecords = new List<RejectedRecord>();

        /// <summary>
        /// Constructs a new RejectedRecordsException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public RejectedRecordsException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of RejectedRecordsException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public RejectedRecordsException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of RejectedRecordsException
        /// </summary>
        /// <param name="innerException"></param>
        public RejectedRecordsException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of RejectedRecordsException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public RejectedRecordsException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of RejectedRecordsException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public RejectedRecordsException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the RejectedRecordsException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected RejectedRecordsException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.RejectedRecords = (List<RejectedRecord>)info.GetValue("RejectedRecords", typeof(List<RejectedRecord>));
        }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception>
#if BCL35
        [System.Security.Permissions.SecurityPermission(
            System.Security.Permissions.SecurityAction.LinkDemand,
            Flags = System.Security.Permissions.SecurityPermissionFlag.SerializationFormatter)]
#endif
        [System.Security.SecurityCritical]
        // These FxCop rules are giving false-positives for this method
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2134:MethodsMustOverrideWithConsistentTransparencyFxCopRule")]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("RejectedRecords", this.RejectedRecords);
        }
#endif

        /// <summary>
        /// Gets and sets the property RejectedRecords. 
        /// <para>
        ///  
        /// </para>
        /// </summary>
        public List<RejectedRecord> RejectedRecords
        {
            get { return this._rejectedRecords; }
            set { this._rejectedRecords = value; }
        }

        // Check to see if RejectedRecords property is set
        internal bool IsSetRejectedRecords()
        {
            return this._rejectedRecords != null && this._rejectedRecords.Count > 0; 
        }

    }
}