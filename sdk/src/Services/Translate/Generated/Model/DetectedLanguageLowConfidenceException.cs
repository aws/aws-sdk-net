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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
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
    /// The confidence that Amazon Comprehend accurately detected the source language is low.
    /// If a low confidence level is acceptable for your application, you can use the language
    /// in the exception to call Amazon Translate again. For more information, see the <a
    /// href="https://docs.aws.amazon.com/comprehend/latest/dg/API_DetectDominantLanguage.html">DetectDominantLanguage</a>
    /// operation in the <i>Amazon Comprehend Developer Guide</i>.
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class DetectedLanguageLowConfidenceException : AmazonTranslateException
    {
        private string _detectedLanguageCode;

        /// <summary>
        /// Constructs a new DetectedLanguageLowConfidenceException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public DetectedLanguageLowConfidenceException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of DetectedLanguageLowConfidenceException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public DetectedLanguageLowConfidenceException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of DetectedLanguageLowConfidenceException
        /// </summary>
        /// <param name="innerException"></param>
        public DetectedLanguageLowConfidenceException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of DetectedLanguageLowConfidenceException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public DetectedLanguageLowConfidenceException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of DetectedLanguageLowConfidenceException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public DetectedLanguageLowConfidenceException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the DetectedLanguageLowConfidenceException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected DetectedLanguageLowConfidenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.DetectedLanguageCode = (string)info.GetValue("DetectedLanguageCode", typeof(string));
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
            info.AddValue("DetectedLanguageCode", this.DetectedLanguageCode);
        }
#endif

        /// <summary>
        /// Gets and sets the property DetectedLanguageCode. 
        /// <para>
        /// The language code of the auto-detected language from Amazon Comprehend.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=5)]
        public string DetectedLanguageCode
        {
            get { return this._detectedLanguageCode; }
            set { this._detectedLanguageCode = value; }
        }

        // Check to see if DetectedLanguageCode property is set
        internal bool IsSetDetectedLanguageCode()
        {
            return this._detectedLanguageCode != null;
        }

    }
}