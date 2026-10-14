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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Data format is not valid. Amazon Kinesis Analytics is not able to detect schema for
    /// the given streaming source.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class UnableToDetectSchemaException : AmazonKinesisAnalyticsException
    {
        /// <summary>
        /// Default constructor for UnableToDetectSchemaException
        /// message.
        /// </summary>
        public UnableToDetectSchemaException() : base() { }

        /// <summary>
        /// Constructs a new UnableToDetectSchemaException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public UnableToDetectSchemaException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of UnableToDetectSchemaException
        /// </summary>
        public UnableToDetectSchemaException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of UnableToDetectSchemaException
        /// </summary>
        public UnableToDetectSchemaException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of UnableToDetectSchemaException
        /// </summary>
        public UnableToDetectSchemaException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of UnableToDetectSchemaException
        /// </summary>
        public UnableToDetectSchemaException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property ProcessedInputRecords.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProcessedInputRecords { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ProcessedInputRecords property is set.
        /// </summary>
        internal bool IsSetProcessedInputRecords() => this.ProcessedInputRecords != null && (this.ProcessedInputRecords.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RawInputRecords.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RawInputRecords { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RawInputRecords property is set.
        /// </summary>
        internal bool IsSetRawInputRecords() => this.RawInputRecords != null && (this.RawInputRecords.Count > 0 || !AWSConfigs.InitializeCollections);

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the UnableToDetectSchemaException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected UnableToDetectSchemaException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.ProcessedInputRecords = (List<string>)info.GetValue("ProcessedInputRecords", typeof(List<string>));
            this.RawInputRecords = (List<string>)info.GetValue("RawInputRecords", typeof(List<string>));
        }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception>
        [System.Security.SecurityCritical]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("ProcessedInputRecords", this.ProcessedInputRecords);
            info.AddValue("RawInputRecords", this.RawInputRecords);
        }
#endif
    }
}
