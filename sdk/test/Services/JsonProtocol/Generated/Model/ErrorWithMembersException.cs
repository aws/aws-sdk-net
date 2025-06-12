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
 * Do not modify this file. This file is generated from the json-protocol-2018-01-01.normal.json service model.
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
    /// 
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class ErrorWithMembersException : AmazonJsonProtocolException
    {
        private string _code;
        private KitchenSink _complexData;
        private int? _integerField;
        private List<string> _listField = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _mapField = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _stringField;

        /// <summary>
        /// Constructs a new ErrorWithMembersException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public ErrorWithMembersException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of ErrorWithMembersException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ErrorWithMembersException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of ErrorWithMembersException
        /// </summary>
        /// <param name="innerException"></param>
        public ErrorWithMembersException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of ErrorWithMembersException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public ErrorWithMembersException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of ErrorWithMembersException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public ErrorWithMembersException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


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
        // These FxCop rules are giving false-positives for this method
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2134:MethodsMustOverrideWithConsistentTransparencyFxCopRule")]
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

        /// <summary>
        /// Gets and sets the property Code.
        /// </summary>
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property ComplexData.
        /// </summary>
        public KitchenSink ComplexData
        {
            get { return this._complexData; }
            set { this._complexData = value; }
        }

        // Check to see if ComplexData property is set
        internal bool IsSetComplexData()
        {
            return this._complexData != null;
        }

        /// <summary>
        /// Gets and sets the property IntegerField.
        /// </summary>
        public int? IntegerField
        {
            get { return this._integerField; }
            set { this._integerField = value; }
        }

        // Check to see if IntegerField property is set
        internal bool IsSetIntegerField()
        {
            return this._integerField.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ListField.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ListField
        {
            get { return this._listField; }
            set { this._listField = value; }
        }

        // Check to see if ListField property is set
        internal bool IsSetListField()
        {
            return this._listField != null && (this._listField.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MapField.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> MapField
        {
            get { return this._mapField; }
            set { this._mapField = value; }
        }

        // Check to see if MapField property is set
        internal bool IsSetMapField()
        {
            return this._mapField != null && (this._mapField.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StringField. 
        /// <para>
        /// abc
        /// </para>
        /// </summary>
        public string StringField
        {
            get { return this._stringField; }
            set { this._stringField = value; }
        }

        // Check to see if StringField property is set
        internal bool IsSetStringField()
        {
            return this._stringField != null;
        }

    }
}