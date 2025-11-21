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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Lightsail throws this exception when an operation is performed on resources in an
    /// opt-in Region that is currently being set up.
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class RegionSetupInProgressException : AmazonLightsailException
    {
        private string _code;
        private string _docs;
        private string _tip;

        /// <summary>
        /// Constructs a new RegionSetupInProgressException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public RegionSetupInProgressException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of RegionSetupInProgressException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public RegionSetupInProgressException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of RegionSetupInProgressException
        /// </summary>
        /// <param name="innerException"></param>
        public RegionSetupInProgressException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of RegionSetupInProgressException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public RegionSetupInProgressException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of RegionSetupInProgressException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public RegionSetupInProgressException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the RegionSetupInProgressException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected RegionSetupInProgressException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.Code = (string)info.GetValue("Code", typeof(string));
            this.Docs = (string)info.GetValue("Docs", typeof(string));
            this.Tip = (string)info.GetValue("Tip", typeof(string));
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
            info.AddValue("Docs", this.Docs);
            info.AddValue("Tip", this.Tip);
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
        /// Gets and sets the property Docs. 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/understanding-regions-and-availability-zones-in-amazon-lightsail.html">Regions
        /// and Availability Zones for Lightsail</a> 
        /// </para>
        /// </summary>
        public string Docs
        {
            get { return this._docs; }
            set { this._docs = value; }
        }

        // Check to see if Docs property is set
        internal bool IsSetDocs()
        {
            return this._docs != null;
        }

        /// <summary>
        /// Gets and sets the property Tip. 
        /// <para>
        /// Opt-in Regions typically take a few minutes to finish setting up before you can work
        /// with them. Wait a few minutes and try again.
        /// </para>
        /// </summary>
        public string Tip
        {
            get { return this._tip; }
            set { this._tip = value; }
        }

        // Check to see if Tip property is set
        internal bool IsSetTip()
        {
            return this._tip != null;
        }

    }
}