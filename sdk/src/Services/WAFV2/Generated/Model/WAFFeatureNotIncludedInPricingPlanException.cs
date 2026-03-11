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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The operation failed because the specified WAF feature isn't supported by the CloudFront
    /// pricing plan associated with the web ACL.
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class WAFFeatureNotIncludedInPricingPlanException : AmazonWAFV2Exception
    {
        private List<DisallowedFeature> _disallowedFeatures = AWSConfigs.InitializeCollections ? new List<DisallowedFeature>() : null;

        /// <summary>
        /// Default constructor for WAFFeatureNotIncludedInPricingPlanException
        /// message.
        /// </summary>
        public WAFFeatureNotIncludedInPricingPlanException() 
            : base() {}

        /// <summary>
        /// Constructs a new WAFFeatureNotIncludedInPricingPlanException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public WAFFeatureNotIncludedInPricingPlanException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of WAFFeatureNotIncludedInPricingPlanException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public WAFFeatureNotIncludedInPricingPlanException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of WAFFeatureNotIncludedInPricingPlanException
        /// </summary>
        /// <param name="innerException"></param>
        public WAFFeatureNotIncludedInPricingPlanException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of WAFFeatureNotIncludedInPricingPlanException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public WAFFeatureNotIncludedInPricingPlanException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of WAFFeatureNotIncludedInPricingPlanException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public WAFFeatureNotIncludedInPricingPlanException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the WAFFeatureNotIncludedInPricingPlanException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected WAFFeatureNotIncludedInPricingPlanException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.DisallowedFeatures = (List<DisallowedFeature>)info.GetValue("DisallowedFeatures", typeof(List<DisallowedFeature>));
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
            info.AddValue("DisallowedFeatures", this.DisallowedFeatures);
        }
#endif

        /// <summary>
        /// Gets and sets the property DisallowedFeatures. 
        /// <para>
        /// The names of the disallowed WAF features.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<DisallowedFeature> DisallowedFeatures
        {
            get { return this._disallowedFeatures; }
            set { this._disallowedFeatures = value; }
        }

        // Check to see if DisallowedFeatures property is set
        internal bool IsSetDisallowedFeatures()
        {
            return this._disallowedFeatures != null && (this._disallowedFeatures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}