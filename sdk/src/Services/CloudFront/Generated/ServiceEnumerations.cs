/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudFront
{

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