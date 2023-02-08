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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudFront
{

    /// <summary>
    /// Constants used for properties of type CachePolicyCookieBehavior.
    /// </summary>
    public class CachePolicyCookieBehavior : ConstantClass
    {

        /// <summary>
        /// Constant All for CachePolicyCookieBehavior
        /// </summary>
        public static readonly CachePolicyCookieBehavior All = new CachePolicyCookieBehavior("all");
        /// <summary>
        /// Constant AllExcept for CachePolicyCookieBehavior
        /// </summary>
        public static readonly CachePolicyCookieBehavior AllExcept = new CachePolicyCookieBehavior("allExcept");
        /// <summary>
        /// Constant None for CachePolicyCookieBehavior
        /// </summary>
        public static readonly CachePolicyCookieBehavior None = new CachePolicyCookieBehavior("none");
        /// <summary>
        /// Constant Whitelist for CachePolicyCookieBehavior
        /// </summary>
        public static readonly CachePolicyCookieBehavior Whitelist = new CachePolicyCookieBehavior("whitelist");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CachePolicyCookieBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CachePolicyCookieBehavior FindValue(string value)
        {
            return FindValue<CachePolicyCookieBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CachePolicyCookieBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CachePolicyHeaderBehavior.
    /// </summary>
    public class CachePolicyHeaderBehavior : ConstantClass
    {

        /// <summary>
        /// Constant None for CachePolicyHeaderBehavior
        /// </summary>
        public static readonly CachePolicyHeaderBehavior None = new CachePolicyHeaderBehavior("none");
        /// <summary>
        /// Constant Whitelist for CachePolicyHeaderBehavior
        /// </summary>
        public static readonly CachePolicyHeaderBehavior Whitelist = new CachePolicyHeaderBehavior("whitelist");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CachePolicyHeaderBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CachePolicyHeaderBehavior FindValue(string value)
        {
            return FindValue<CachePolicyHeaderBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CachePolicyHeaderBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CachePolicyQueryStringBehavior.
    /// </summary>
    public class CachePolicyQueryStringBehavior : ConstantClass
    {

        /// <summary>
        /// Constant All for CachePolicyQueryStringBehavior
        /// </summary>
        public static readonly CachePolicyQueryStringBehavior All = new CachePolicyQueryStringBehavior("all");
        /// <summary>
        /// Constant AllExcept for CachePolicyQueryStringBehavior
        /// </summary>
        public static readonly CachePolicyQueryStringBehavior AllExcept = new CachePolicyQueryStringBehavior("allExcept");
        /// <summary>
        /// Constant None for CachePolicyQueryStringBehavior
        /// </summary>
        public static readonly CachePolicyQueryStringBehavior None = new CachePolicyQueryStringBehavior("none");
        /// <summary>
        /// Constant Whitelist for CachePolicyQueryStringBehavior
        /// </summary>
        public static readonly CachePolicyQueryStringBehavior Whitelist = new CachePolicyQueryStringBehavior("whitelist");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CachePolicyQueryStringBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CachePolicyQueryStringBehavior FindValue(string value)
        {
            return FindValue<CachePolicyQueryStringBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CachePolicyQueryStringBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CachePolicyType.
    /// </summary>
    public class CachePolicyType : ConstantClass
    {

        /// <summary>
        /// Constant Custom for CachePolicyType
        /// </summary>
        public static readonly CachePolicyType Custom = new CachePolicyType("custom");
        /// <summary>
        /// Constant Managed for CachePolicyType
        /// </summary>
        public static readonly CachePolicyType Managed = new CachePolicyType("managed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CachePolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CachePolicyType FindValue(string value)
        {
            return FindValue<CachePolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CachePolicyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateSource.
    /// </summary>
    public class CertificateSource : ConstantClass
    {

        /// <summary>
        /// Constant Acm for CertificateSource
        /// </summary>
        public static readonly CertificateSource Acm = new CertificateSource("acm");
        /// <summary>
        /// Constant Cloudfront for CertificateSource
        /// </summary>
        public static readonly CertificateSource Cloudfront = new CertificateSource("cloudfront");
        /// <summary>
        /// Constant Iam for CertificateSource
        /// </summary>
        public static readonly CertificateSource Iam = new CertificateSource("iam");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateSource FindValue(string value)
        {
            return FindValue<CertificateSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContinuousDeploymentPolicyType.
    /// </summary>
    public class ContinuousDeploymentPolicyType : ConstantClass
    {

        /// <summary>
        /// Constant SingleHeader for ContinuousDeploymentPolicyType
        /// </summary>
        public static readonly ContinuousDeploymentPolicyType SingleHeader = new ContinuousDeploymentPolicyType("SingleHeader");
        /// <summary>
        /// Constant SingleWeight for ContinuousDeploymentPolicyType
        /// </summary>
        public static readonly ContinuousDeploymentPolicyType SingleWeight = new ContinuousDeploymentPolicyType("SingleWeight");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContinuousDeploymentPolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContinuousDeploymentPolicyType FindValue(string value)
        {
            return FindValue<ContinuousDeploymentPolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContinuousDeploymentPolicyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventType.
    /// </summary>
    public class EventType : ConstantClass
    {

        /// <summary>
        /// Constant OriginRequest for EventType
        /// </summary>
        public static readonly EventType OriginRequest = new EventType("origin-request");
        /// <summary>
        /// Constant OriginResponse for EventType
        /// </summary>
        public static readonly EventType OriginResponse = new EventType("origin-response");
        /// <summary>
        /// Constant ViewerRequest for EventType
        /// </summary>
        public static readonly EventType ViewerRequest = new EventType("viewer-request");
        /// <summary>
        /// Constant ViewerResponse for EventType
        /// </summary>
        public static readonly EventType ViewerResponse = new EventType("viewer-response");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventType FindValue(string value)
        {
            return FindValue<EventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Format.
    /// </summary>
    public class Format : ConstantClass
    {

        /// <summary>
        /// Constant URLEncoded for Format
        /// </summary>
        public static readonly Format URLEncoded = new Format("URLEncoded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Format(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Format FindValue(string value)
        {
            return FindValue<Format>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Format(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FrameOptionsList.
    /// </summary>
    public class FrameOptionsList : ConstantClass
    {

        /// <summary>
        /// Constant DENY for FrameOptionsList
        /// </summary>
        public static readonly FrameOptionsList DENY = new FrameOptionsList("DENY");
        /// <summary>
        /// Constant SAMEORIGIN for FrameOptionsList
        /// </summary>
        public static readonly FrameOptionsList SAMEORIGIN = new FrameOptionsList("SAMEORIGIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FrameOptionsList(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FrameOptionsList FindValue(string value)
        {
            return FindValue<FrameOptionsList>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FrameOptionsList(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FunctionRuntime.
    /// </summary>
    public class FunctionRuntime : ConstantClass
    {

        /// <summary>
        /// Constant CloudfrontJs10 for FunctionRuntime
        /// </summary>
        public static readonly FunctionRuntime CloudfrontJs10 = new FunctionRuntime("cloudfront-js-1.0");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FunctionRuntime(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FunctionRuntime FindValue(string value)
        {
            return FindValue<FunctionRuntime>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FunctionRuntime(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FunctionStage.
    /// </summary>
    public class FunctionStage : ConstantClass
    {

        /// <summary>
        /// Constant DEVELOPMENT for FunctionStage
        /// </summary>
        public static readonly FunctionStage DEVELOPMENT = new FunctionStage("DEVELOPMENT");
        /// <summary>
        /// Constant LIVE for FunctionStage
        /// </summary>
        public static readonly FunctionStage LIVE = new FunctionStage("LIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FunctionStage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FunctionStage FindValue(string value)
        {
            return FindValue<FunctionStage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FunctionStage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GeoRestrictionType.
    /// </summary>
    public class GeoRestrictionType : ConstantClass
    {

        /// <summary>
        /// Constant Blacklist for GeoRestrictionType
        /// </summary>
        public static readonly GeoRestrictionType Blacklist = new GeoRestrictionType("blacklist");
        /// <summary>
        /// Constant None for GeoRestrictionType
        /// </summary>
        public static readonly GeoRestrictionType None = new GeoRestrictionType("none");
        /// <summary>
        /// Constant Whitelist for GeoRestrictionType
        /// </summary>
        public static readonly GeoRestrictionType Whitelist = new GeoRestrictionType("whitelist");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeoRestrictionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeoRestrictionType FindValue(string value)
        {
            return FindValue<GeoRestrictionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeoRestrictionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HttpVersion.
    /// </summary>
    public class HttpVersion : ConstantClass
    {

        /// <summary>
        /// Constant Http11 for HttpVersion
        /// </summary>
        public static readonly HttpVersion Http11 = new HttpVersion("http1.1");
        /// <summary>
        /// Constant Http2 for HttpVersion
        /// </summary>
        public static readonly HttpVersion Http2 = new HttpVersion("http2");
        /// <summary>
        /// Constant Http2and3 for HttpVersion
        /// </summary>
        public static readonly HttpVersion Http2and3 = new HttpVersion("http2and3");
        /// <summary>
        /// Constant Http3 for HttpVersion
        /// </summary>
        public static readonly HttpVersion Http3 = new HttpVersion("http3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HttpVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HttpVersion FindValue(string value)
        {
            return FindValue<HttpVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HttpVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ICPRecordalStatus.
    /// </summary>
    public class ICPRecordalStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for ICPRecordalStatus
        /// </summary>
        public static readonly ICPRecordalStatus APPROVED = new ICPRecordalStatus("APPROVED");
        /// <summary>
        /// Constant PENDING for ICPRecordalStatus
        /// </summary>
        public static readonly ICPRecordalStatus PENDING = new ICPRecordalStatus("PENDING");
        /// <summary>
        /// Constant SUSPENDED for ICPRecordalStatus
        /// </summary>
        public static readonly ICPRecordalStatus SUSPENDED = new ICPRecordalStatus("SUSPENDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ICPRecordalStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ICPRecordalStatus FindValue(string value)
        {
            return FindValue<ICPRecordalStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ICPRecordalStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ItemSelection.
    /// </summary>
    public class ItemSelection : ConstantClass
    {

        /// <summary>
        /// Constant All for ItemSelection
        /// </summary>
        public static readonly ItemSelection All = new ItemSelection("all");
        /// <summary>
        /// Constant None for ItemSelection
        /// </summary>
        public static readonly ItemSelection None = new ItemSelection("none");
        /// <summary>
        /// Constant Whitelist for ItemSelection
        /// </summary>
        public static readonly ItemSelection Whitelist = new ItemSelection("whitelist");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ItemSelection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ItemSelection FindValue(string value)
        {
            return FindValue<ItemSelection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ItemSelection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Method.
    /// </summary>
    public class Method : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for Method
        /// </summary>
        public static readonly Method DELETE = new Method("DELETE");
        /// <summary>
        /// Constant GET for Method
        /// </summary>
        public static readonly Method GET = new Method("GET");
        /// <summary>
        /// Constant HEAD for Method
        /// </summary>
        public static readonly Method HEAD = new Method("HEAD");
        /// <summary>
        /// Constant OPTIONS for Method
        /// </summary>
        public static readonly Method OPTIONS = new Method("OPTIONS");
        /// <summary>
        /// Constant PATCH for Method
        /// </summary>
        public static readonly Method PATCH = new Method("PATCH");
        /// <summary>
        /// Constant POST for Method
        /// </summary>
        public static readonly Method POST = new Method("POST");
        /// <summary>
        /// Constant PUT for Method
        /// </summary>
        public static readonly Method PUT = new Method("PUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Method(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Method FindValue(string value)
        {
            return FindValue<Method>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Method(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MinimumProtocolVersion.
    /// </summary>
    public class MinimumProtocolVersion : ConstantClass
    {

        /// <summary>
        /// Constant SSLv3 for MinimumProtocolVersion
        /// </summary>
        public static readonly MinimumProtocolVersion SSLv3 = new MinimumProtocolVersion("SSLv3");
        /// <summary>
        /// Constant TLSv1 for MinimumProtocolVersion
        /// </summary>
        public static readonly MinimumProtocolVersion TLSv1 = new MinimumProtocolVersion("TLSv1");
        /// <summary>
        /// Constant TLSv1_2016 for MinimumProtocolVersion
        /// </summary>
        public static readonly MinimumProtocolVersion TLSv1_2016 = new MinimumProtocolVersion("TLSv1_2016");
        /// <summary>
        /// Constant TLSv11_2016 for MinimumProtocolVersion
        /// </summary>
        public static readonly MinimumProtocolVersion TLSv11_2016 = new MinimumProtocolVersion("TLSv1.1_2016");
        /// <summary>
        /// Constant TLSv12_2018 for MinimumProtocolVersion
        /// </summary>
        public static readonly MinimumProtocolVersion TLSv12_2018 = new MinimumProtocolVersion("TLSv1.2_2018");
        /// <summary>
        /// Constant TLSv12_2019 for MinimumProtocolVersion
        /// </summary>
        public static readonly MinimumProtocolVersion TLSv12_2019 = new MinimumProtocolVersion("TLSv1.2_2019");
        /// <summary>
        /// Constant TLSv12_2021 for MinimumProtocolVersion
        /// </summary>
        public static readonly MinimumProtocolVersion TLSv12_2021 = new MinimumProtocolVersion("TLSv1.2_2021");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MinimumProtocolVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MinimumProtocolVersion FindValue(string value)
        {
            return FindValue<MinimumProtocolVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MinimumProtocolVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OriginAccessControlOriginTypes.
    /// </summary>
    public class OriginAccessControlOriginTypes : ConstantClass
    {

        /// <summary>
        /// Constant Mediastore for OriginAccessControlOriginTypes
        /// </summary>
        public static readonly OriginAccessControlOriginTypes Mediastore = new OriginAccessControlOriginTypes("mediastore");
        /// <summary>
        /// Constant S3 for OriginAccessControlOriginTypes
        /// </summary>
        public static readonly OriginAccessControlOriginTypes S3 = new OriginAccessControlOriginTypes("s3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OriginAccessControlOriginTypes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OriginAccessControlOriginTypes FindValue(string value)
        {
            return FindValue<OriginAccessControlOriginTypes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OriginAccessControlOriginTypes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OriginAccessControlSigningBehaviors.
    /// </summary>
    public class OriginAccessControlSigningBehaviors : ConstantClass
    {

        /// <summary>
        /// Constant Always for OriginAccessControlSigningBehaviors
        /// </summary>
        public static readonly OriginAccessControlSigningBehaviors Always = new OriginAccessControlSigningBehaviors("always");
        /// <summary>
        /// Constant Never for OriginAccessControlSigningBehaviors
        /// </summary>
        public static readonly OriginAccessControlSigningBehaviors Never = new OriginAccessControlSigningBehaviors("never");
        /// <summary>
        /// Constant NoOverride for OriginAccessControlSigningBehaviors
        /// </summary>
        public static readonly OriginAccessControlSigningBehaviors NoOverride = new OriginAccessControlSigningBehaviors("no-override");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OriginAccessControlSigningBehaviors(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OriginAccessControlSigningBehaviors FindValue(string value)
        {
            return FindValue<OriginAccessControlSigningBehaviors>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OriginAccessControlSigningBehaviors(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OriginAccessControlSigningProtocols.
    /// </summary>
    public class OriginAccessControlSigningProtocols : ConstantClass
    {

        /// <summary>
        /// Constant Sigv4 for OriginAccessControlSigningProtocols
        /// </summary>
        public static readonly OriginAccessControlSigningProtocols Sigv4 = new OriginAccessControlSigningProtocols("sigv4");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OriginAccessControlSigningProtocols(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OriginAccessControlSigningProtocols FindValue(string value)
        {
            return FindValue<OriginAccessControlSigningProtocols>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OriginAccessControlSigningProtocols(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OriginProtocolPolicy.
    /// </summary>
    public class OriginProtocolPolicy : ConstantClass
    {

        /// <summary>
        /// Constant HttpOnly for OriginProtocolPolicy
        /// </summary>
        public static readonly OriginProtocolPolicy HttpOnly = new OriginProtocolPolicy("http-only");
        /// <summary>
        /// Constant HttpsOnly for OriginProtocolPolicy
        /// </summary>
        public static readonly OriginProtocolPolicy HttpsOnly = new OriginProtocolPolicy("https-only");
        /// <summary>
        /// Constant MatchViewer for OriginProtocolPolicy
        /// </summary>
        public static readonly OriginProtocolPolicy MatchViewer = new OriginProtocolPolicy("match-viewer");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OriginProtocolPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OriginProtocolPolicy FindValue(string value)
        {
            return FindValue<OriginProtocolPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OriginProtocolPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OriginRequestPolicyCookieBehavior.
    /// </summary>
    public class OriginRequestPolicyCookieBehavior : ConstantClass
    {

        /// <summary>
        /// Constant All for OriginRequestPolicyCookieBehavior
        /// </summary>
        public static readonly OriginRequestPolicyCookieBehavior All = new OriginRequestPolicyCookieBehavior("all");
        /// <summary>
        /// Constant None for OriginRequestPolicyCookieBehavior
        /// </summary>
        public static readonly OriginRequestPolicyCookieBehavior None = new OriginRequestPolicyCookieBehavior("none");
        /// <summary>
        /// Constant Whitelist for OriginRequestPolicyCookieBehavior
        /// </summary>
        public static readonly OriginRequestPolicyCookieBehavior Whitelist = new OriginRequestPolicyCookieBehavior("whitelist");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OriginRequestPolicyCookieBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OriginRequestPolicyCookieBehavior FindValue(string value)
        {
            return FindValue<OriginRequestPolicyCookieBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OriginRequestPolicyCookieBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OriginRequestPolicyHeaderBehavior.
    /// </summary>
    public class OriginRequestPolicyHeaderBehavior : ConstantClass
    {

        /// <summary>
        /// Constant AllViewer for OriginRequestPolicyHeaderBehavior
        /// </summary>
        public static readonly OriginRequestPolicyHeaderBehavior AllViewer = new OriginRequestPolicyHeaderBehavior("allViewer");
        /// <summary>
        /// Constant AllViewerAndWhitelistCloudFront for OriginRequestPolicyHeaderBehavior
        /// </summary>
        public static readonly OriginRequestPolicyHeaderBehavior AllViewerAndWhitelistCloudFront = new OriginRequestPolicyHeaderBehavior("allViewerAndWhitelistCloudFront");
        /// <summary>
        /// Constant None for OriginRequestPolicyHeaderBehavior
        /// </summary>
        public static readonly OriginRequestPolicyHeaderBehavior None = new OriginRequestPolicyHeaderBehavior("none");
        /// <summary>
        /// Constant Whitelist for OriginRequestPolicyHeaderBehavior
        /// </summary>
        public static readonly OriginRequestPolicyHeaderBehavior Whitelist = new OriginRequestPolicyHeaderBehavior("whitelist");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OriginRequestPolicyHeaderBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OriginRequestPolicyHeaderBehavior FindValue(string value)
        {
            return FindValue<OriginRequestPolicyHeaderBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OriginRequestPolicyHeaderBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OriginRequestPolicyQueryStringBehavior.
    /// </summary>
    public class OriginRequestPolicyQueryStringBehavior : ConstantClass
    {

        /// <summary>
        /// Constant All for OriginRequestPolicyQueryStringBehavior
        /// </summary>
        public static readonly OriginRequestPolicyQueryStringBehavior All = new OriginRequestPolicyQueryStringBehavior("all");
        /// <summary>
        /// Constant None for OriginRequestPolicyQueryStringBehavior
        /// </summary>
        public static readonly OriginRequestPolicyQueryStringBehavior None = new OriginRequestPolicyQueryStringBehavior("none");
        /// <summary>
        /// Constant Whitelist for OriginRequestPolicyQueryStringBehavior
        /// </summary>
        public static readonly OriginRequestPolicyQueryStringBehavior Whitelist = new OriginRequestPolicyQueryStringBehavior("whitelist");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OriginRequestPolicyQueryStringBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OriginRequestPolicyQueryStringBehavior FindValue(string value)
        {
            return FindValue<OriginRequestPolicyQueryStringBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OriginRequestPolicyQueryStringBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OriginRequestPolicyType.
    /// </summary>
    public class OriginRequestPolicyType : ConstantClass
    {

        /// <summary>
        /// Constant Custom for OriginRequestPolicyType
        /// </summary>
        public static readonly OriginRequestPolicyType Custom = new OriginRequestPolicyType("custom");
        /// <summary>
        /// Constant Managed for OriginRequestPolicyType
        /// </summary>
        public static readonly OriginRequestPolicyType Managed = new OriginRequestPolicyType("managed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OriginRequestPolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OriginRequestPolicyType FindValue(string value)
        {
            return FindValue<OriginRequestPolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OriginRequestPolicyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PriceClass.
    /// </summary>
    public class PriceClass : ConstantClass
    {

        /// <summary>
        /// Constant PriceClass_100 for PriceClass
        /// </summary>
        public static readonly PriceClass PriceClass_100 = new PriceClass("PriceClass_100");
        /// <summary>
        /// Constant PriceClass_200 for PriceClass
        /// </summary>
        public static readonly PriceClass PriceClass_200 = new PriceClass("PriceClass_200");
        /// <summary>
        /// Constant PriceClass_All for PriceClass
        /// </summary>
        public static readonly PriceClass PriceClass_All = new PriceClass("PriceClass_All");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PriceClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PriceClass FindValue(string value)
        {
            return FindValue<PriceClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PriceClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RealtimeMetricsSubscriptionStatus.
    /// </summary>
    public class RealtimeMetricsSubscriptionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for RealtimeMetricsSubscriptionStatus
        /// </summary>
        public static readonly RealtimeMetricsSubscriptionStatus Disabled = new RealtimeMetricsSubscriptionStatus("Disabled");
        /// <summary>
        /// Constant Enabled for RealtimeMetricsSubscriptionStatus
        /// </summary>
        public static readonly RealtimeMetricsSubscriptionStatus Enabled = new RealtimeMetricsSubscriptionStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RealtimeMetricsSubscriptionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RealtimeMetricsSubscriptionStatus FindValue(string value)
        {
            return FindValue<RealtimeMetricsSubscriptionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RealtimeMetricsSubscriptionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReferrerPolicyList.
    /// </summary>
    public class ReferrerPolicyList : ConstantClass
    {

        /// <summary>
        /// Constant NoReferrer for ReferrerPolicyList
        /// </summary>
        public static readonly ReferrerPolicyList NoReferrer = new ReferrerPolicyList("no-referrer");
        /// <summary>
        /// Constant NoReferrerWhenDowngrade for ReferrerPolicyList
        /// </summary>
        public static readonly ReferrerPolicyList NoReferrerWhenDowngrade = new ReferrerPolicyList("no-referrer-when-downgrade");
        /// <summary>
        /// Constant Origin for ReferrerPolicyList
        /// </summary>
        public static readonly ReferrerPolicyList Origin = new ReferrerPolicyList("origin");
        /// <summary>
        /// Constant OriginWhenCrossOrigin for ReferrerPolicyList
        /// </summary>
        public static readonly ReferrerPolicyList OriginWhenCrossOrigin = new ReferrerPolicyList("origin-when-cross-origin");
        /// <summary>
        /// Constant SameOrigin for ReferrerPolicyList
        /// </summary>
        public static readonly ReferrerPolicyList SameOrigin = new ReferrerPolicyList("same-origin");
        /// <summary>
        /// Constant StrictOrigin for ReferrerPolicyList
        /// </summary>
        public static readonly ReferrerPolicyList StrictOrigin = new ReferrerPolicyList("strict-origin");
        /// <summary>
        /// Constant StrictOriginWhenCrossOrigin for ReferrerPolicyList
        /// </summary>
        public static readonly ReferrerPolicyList StrictOriginWhenCrossOrigin = new ReferrerPolicyList("strict-origin-when-cross-origin");
        /// <summary>
        /// Constant UnsafeUrl for ReferrerPolicyList
        /// </summary>
        public static readonly ReferrerPolicyList UnsafeUrl = new ReferrerPolicyList("unsafe-url");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReferrerPolicyList(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReferrerPolicyList FindValue(string value)
        {
            return FindValue<ReferrerPolicyList>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReferrerPolicyList(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResponseHeadersPolicyAccessControlAllowMethodsValues.
    /// </summary>
    public class ResponseHeadersPolicyAccessControlAllowMethodsValues : ConstantClass
    {

        /// <summary>
        /// Constant ALL for ResponseHeadersPolicyAccessControlAllowMethodsValues
        /// </summary>
        public static readonly ResponseHeadersPolicyAccessControlAllowMethodsValues ALL = new ResponseHeadersPolicyAccessControlAllowMethodsValues("ALL");
        /// <summary>
        /// Constant DELETE for ResponseHeadersPolicyAccessControlAllowMethodsValues
        /// </summary>
        public static readonly ResponseHeadersPolicyAccessControlAllowMethodsValues DELETE = new ResponseHeadersPolicyAccessControlAllowMethodsValues("DELETE");
        /// <summary>
        /// Constant GET for ResponseHeadersPolicyAccessControlAllowMethodsValues
        /// </summary>
        public static readonly ResponseHeadersPolicyAccessControlAllowMethodsValues GET = new ResponseHeadersPolicyAccessControlAllowMethodsValues("GET");
        /// <summary>
        /// Constant HEAD for ResponseHeadersPolicyAccessControlAllowMethodsValues
        /// </summary>
        public static readonly ResponseHeadersPolicyAccessControlAllowMethodsValues HEAD = new ResponseHeadersPolicyAccessControlAllowMethodsValues("HEAD");
        /// <summary>
        /// Constant OPTIONS for ResponseHeadersPolicyAccessControlAllowMethodsValues
        /// </summary>
        public static readonly ResponseHeadersPolicyAccessControlAllowMethodsValues OPTIONS = new ResponseHeadersPolicyAccessControlAllowMethodsValues("OPTIONS");
        /// <summary>
        /// Constant PATCH for ResponseHeadersPolicyAccessControlAllowMethodsValues
        /// </summary>
        public static readonly ResponseHeadersPolicyAccessControlAllowMethodsValues PATCH = new ResponseHeadersPolicyAccessControlAllowMethodsValues("PATCH");
        /// <summary>
        /// Constant POST for ResponseHeadersPolicyAccessControlAllowMethodsValues
        /// </summary>
        public static readonly ResponseHeadersPolicyAccessControlAllowMethodsValues POST = new ResponseHeadersPolicyAccessControlAllowMethodsValues("POST");
        /// <summary>
        /// Constant PUT for ResponseHeadersPolicyAccessControlAllowMethodsValues
        /// </summary>
        public static readonly ResponseHeadersPolicyAccessControlAllowMethodsValues PUT = new ResponseHeadersPolicyAccessControlAllowMethodsValues("PUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResponseHeadersPolicyAccessControlAllowMethodsValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResponseHeadersPolicyAccessControlAllowMethodsValues FindValue(string value)
        {
            return FindValue<ResponseHeadersPolicyAccessControlAllowMethodsValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResponseHeadersPolicyAccessControlAllowMethodsValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResponseHeadersPolicyType.
    /// </summary>
    public class ResponseHeadersPolicyType : ConstantClass
    {

        /// <summary>
        /// Constant Custom for ResponseHeadersPolicyType
        /// </summary>
        public static readonly ResponseHeadersPolicyType Custom = new ResponseHeadersPolicyType("custom");
        /// <summary>
        /// Constant Managed for ResponseHeadersPolicyType
        /// </summary>
        public static readonly ResponseHeadersPolicyType Managed = new ResponseHeadersPolicyType("managed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResponseHeadersPolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResponseHeadersPolicyType FindValue(string value)
        {
            return FindValue<ResponseHeadersPolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResponseHeadersPolicyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SslProtocol.
    /// </summary>
    public class SslProtocol : ConstantClass
    {

        /// <summary>
        /// Constant SSLv3 for SslProtocol
        /// </summary>
        public static readonly SslProtocol SSLv3 = new SslProtocol("SSLv3");
        /// <summary>
        /// Constant TLSv1 for SslProtocol
        /// </summary>
        public static readonly SslProtocol TLSv1 = new SslProtocol("TLSv1");
        /// <summary>
        /// Constant TLSv11 for SslProtocol
        /// </summary>
        public static readonly SslProtocol TLSv11 = new SslProtocol("TLSv1.1");
        /// <summary>
        /// Constant TLSv12 for SslProtocol
        /// </summary>
        public static readonly SslProtocol TLSv12 = new SslProtocol("TLSv1.2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SslProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SslProtocol FindValue(string value)
        {
            return FindValue<SslProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SslProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SSLSupportMethod.
    /// </summary>
    public class SSLSupportMethod : ConstantClass
    {

        /// <summary>
        /// Constant SniOnly for SSLSupportMethod
        /// </summary>
        public static readonly SSLSupportMethod SniOnly = new SSLSupportMethod("sni-only");
        /// <summary>
        /// Constant StaticIp for SSLSupportMethod
        /// </summary>
        public static readonly SSLSupportMethod StaticIp = new SSLSupportMethod("static-ip");
        /// <summary>
        /// Constant Vip for SSLSupportMethod
        /// </summary>
        public static readonly SSLSupportMethod Vip = new SSLSupportMethod("vip");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SSLSupportMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SSLSupportMethod FindValue(string value)
        {
            return FindValue<SSLSupportMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SSLSupportMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ViewerProtocolPolicy.
    /// </summary>
    public class ViewerProtocolPolicy : ConstantClass
    {

        /// <summary>
        /// Constant AllowAll for ViewerProtocolPolicy
        /// </summary>
        public static readonly ViewerProtocolPolicy AllowAll = new ViewerProtocolPolicy("allow-all");
        /// <summary>
        /// Constant HttpsOnly for ViewerProtocolPolicy
        /// </summary>
        public static readonly ViewerProtocolPolicy HttpsOnly = new ViewerProtocolPolicy("https-only");
        /// <summary>
        /// Constant RedirectToHttps for ViewerProtocolPolicy
        /// </summary>
        public static readonly ViewerProtocolPolicy RedirectToHttps = new ViewerProtocolPolicy("redirect-to-https");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ViewerProtocolPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ViewerProtocolPolicy FindValue(string value)
        {
            return FindValue<ViewerProtocolPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ViewerProtocolPolicy(string value)
        {
            return FindValue(value);
        }
    }

}