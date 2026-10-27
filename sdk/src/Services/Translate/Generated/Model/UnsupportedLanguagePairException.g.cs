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

namespace Amazon.Translate.Model
{
    /// <summary>
    /// Amazon Translate does not support translation from the language of the source text
    /// into the requested target language. For more information, see <a href="https://docs.aws.amazon.com/translate/latest/dg/what-is-languages.html">Supported
    /// languages</a>.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class UnsupportedLanguagePairException : AmazonTranslateException
    {
        /// <summary>
        /// Default constructor for UnsupportedLanguagePairException
        /// message.
        /// </summary>
        public UnsupportedLanguagePairException() : base() { }

        /// <summary>
        /// Constructs a new UnsupportedLanguagePairException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public UnsupportedLanguagePairException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of UnsupportedLanguagePairException
        /// </summary>
        public UnsupportedLanguagePairException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of UnsupportedLanguagePairException
        /// </summary>
        public UnsupportedLanguagePairException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of UnsupportedLanguagePairException
        /// </summary>
        public UnsupportedLanguagePairException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of UnsupportedLanguagePairException
        /// </summary>
        public UnsupportedLanguagePairException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property SourceLanguageCode. 
        /// <para>
        /// The language code for the language of the input text. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 5)]
        public string SourceLanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the SourceLanguageCode property is set.
        /// </summary>
        internal bool IsSetSourceLanguageCode() => this.SourceLanguageCode != null;

        /// <summary>
        /// Gets and sets the property TargetLanguageCode. 
        /// <para>
        /// The language code for the language of the translated text. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 5)]
        public string TargetLanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the TargetLanguageCode property is set.
        /// </summary>
        internal bool IsSetTargetLanguageCode() => this.TargetLanguageCode != null;

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the UnsupportedLanguagePairException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected UnsupportedLanguagePairException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.SourceLanguageCode = (string)info.GetValue("SourceLanguageCode", typeof(string));
            this.TargetLanguageCode = (string)info.GetValue("TargetLanguageCode", typeof(string));
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
            info.AddValue("SourceLanguageCode", this.SourceLanguageCode);
            info.AddValue("TargetLanguageCode", this.TargetLanguageCode);
        }
#endif
    }
}
