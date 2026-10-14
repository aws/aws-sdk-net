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

namespace Amazon.JsonProtocol.Model
{
    /// <summary>
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class ErrorWithMembersException : AmazonJsonProtocolException
    {
        /// <summary>
        /// Default constructor for ErrorWithMembersException
        /// message.
        /// </summary>
        public ErrorWithMembersException() : base() { }

        /// <summary>
        /// Constructs a new ErrorWithMembersException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public ErrorWithMembersException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of ErrorWithMembersException
        /// </summary>
        public ErrorWithMembersException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of ErrorWithMembersException
        /// </summary>
        public ErrorWithMembersException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of ErrorWithMembersException
        /// </summary>
        public ErrorWithMembersException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of ErrorWithMembersException
        /// </summary>
        public ErrorWithMembersException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property Code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property ComplexData.
        /// </summary>
        public KitchenSink ComplexData { get; set; }

        /// <summary>
        /// Checks to see if the ComplexData property is set.
        /// </summary>
        internal bool IsSetComplexData() => this.ComplexData != null;

        /// <summary>
        /// Gets and sets the property IntegerField.
        /// </summary>
        public int? IntegerField { get; set; }

        /// <summary>
        /// Checks to see if the IntegerField property is set.
        /// </summary>
        internal bool IsSetIntegerField() => this.IntegerField.HasValue;

        /// <summary>
        /// Gets and sets the property ListField.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ListField { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ListField property is set.
        /// </summary>
        internal bool IsSetListField() => this.ListField != null && (this.ListField.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MapField.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> MapField { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the MapField property is set.
        /// </summary>
        internal bool IsSetMapField() => this.MapField != null && (this.MapField.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StringField. abc
        /// </summary>
        public string StringField { get; set; }

        /// <summary>
        /// Checks to see if the StringField property is set.
        /// </summary>
        internal bool IsSetStringField() => this.StringField != null;

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the ErrorWithMembersException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected ErrorWithMembersException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.Code = (string)info.GetValue("Code", typeof(string));
            this.ComplexData = (KitchenSink)info.GetValue("ComplexData", typeof(KitchenSink));
            this.IntegerField = (int?)info.GetValue("IntegerField", typeof(int?));
            this.ListField = (List<string>)info.GetValue("ListField", typeof(List<string>));
            this.MapField = (Dictionary<string, string>)info.GetValue("MapField", typeof(Dictionary<string, string>));
            this.StringField = (string)info.GetValue("StringField", typeof(string));
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
            info.AddValue("Code", this.Code);
            info.AddValue("ComplexData", this.ComplexData);
            info.AddValue("IntegerField", this.IntegerField);
            info.AddValue("ListField", this.ListField);
            info.AddValue("MapField", this.MapField);
            info.AddValue("StringField", this.StringField);
        }
#endif
    }
}
